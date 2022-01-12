﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Process helper with asynchronous interface
/// - Based on https://gist.github.com/georg-jung/3a8703946075d56423e418ea76212745
/// - And on https://stackoverflow.com/questions/470256/process-waitforexit-asynchronously
/// </summary>
/// 
namespace RIS.Utility
{

    public static class ProcessAsyncHelper
    {
        /// <summary>
        /// Run a process asynchronously
        /// <para>To capture STDOUT, set StartInfo.RedirectStandardOutput to TRUE</para>
        /// <para>To capture STDERR, set StartInfo.RedirectStandardError to TRUE</para>
        /// </summary>
        /// <param name="startInfo">ProcessStartInfo object</param>
        /// <param name="timeoutMs">The timeout in milliseconds (null for no timeout)</param>
        /// <returns>Result object</returns>
        public static async Task<Result> RunAsync(ProcessStartInfo startInfo, int? timeoutMs = null)
        {
            Result result = new Result();

            using (var process = new Process() { StartInfo = startInfo, EnableRaisingEvents = true })
            {
                // List of tasks to wait for a whole process exit
                List<Task> processTasks = new List<Task>();

                // === EXITED Event handling ===
                var processExitEvent = new TaskCompletionSource<object>();
                process.Exited += (sender, args) =>
                {
                    processExitEvent.TrySetResult(true);
                };
                processTasks.Add(processExitEvent.Task);

                // === STDOUT handling ===
                var stdOutBuilder = new StringBuilder();
                if (process.StartInfo.RedirectStandardOutput)
                {
                    var stdOutCloseEvent = new TaskCompletionSource<bool>();

                    process.OutputDataReceived += (s, e) =>
                    {
                        if (e.Data == null)
                        {
                            stdOutCloseEvent.TrySetResult(true);
                        }
                        else
                        {
                            stdOutBuilder.AppendLine(e.Data);
                        }
                    };

                    processTasks.Add(stdOutCloseEvent.Task);
                }
                else
                {
                    // STDOUT is not redirected, so we won't look for it
                }

                // === STDERR handling ===
                var stdErrBuilder = new StringBuilder();
                if (process.StartInfo.RedirectStandardError)
                {
                    var stdErrCloseEvent = new TaskCompletionSource<bool>();

                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (e.Data == null)
                        {
                            stdErrCloseEvent.TrySetResult(true);
                        }
                        else
                        {
                            stdErrBuilder.AppendLine(e.Data);
                        }
                    };

                    processTasks.Add(stdErrCloseEvent.Task);
                }
                else
                {
                    // STDERR is not redirected, so we won't look for it
                }

                // === START OF PROCESS ===
                if (!process.Start())
                {
                    result.ExitCode = process.ExitCode;
                    return result;
                }

                // Reads the output stream first as needed and then waits because deadlocks are possible
                if (process.StartInfo.RedirectStandardOutput)
                {
                    process.BeginOutputReadLine();
                }
                else
                {
                    // No STDOUT
                }

                if (process.StartInfo.RedirectStandardError)
                {
                    process.BeginErrorReadLine();
                }
                else
                {
                    // No STDERR
                }

                // === ASYNC WAIT OF PROCESS ===

                // Process completion = exit AND stdout (if defined) AND stderr (if defined)
                Task processCompletionTask = Task.WhenAll(processTasks);

                // Task to wait for exit OR timeout (if defined)
                Task<Task> awaitingTask = timeoutMs.HasValue
                    ? Task.WhenAny(Task.Delay(timeoutMs.Value), processCompletionTask)
                    : Task.WhenAny(processCompletionTask);

                // Let's now wait for something to end...
                if ((await awaitingTask.ConfigureAwait(false)) == processCompletionTask)
                {
                    // -> Process exited cleanly
                    result.ExitCode = process.ExitCode;
                }
                else
                {
                    // -> Timeout, let's kill the process
                    try
                    {
                        process.Kill();
                    }
                    catch
                    {
                        // ignored
                    }
                }

                // Read stdout/stderr
                result.StdOut = stdOutBuilder.ToString();
                result.StdErr = stdErrBuilder.ToString();
            }

            return result;
        }

    }
}
