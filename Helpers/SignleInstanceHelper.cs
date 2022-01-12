using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace DicomServer
{
    // SingleProgamInstance uses a mutex synchronization object
    // to ensure that only one copy of process is running at
    // a particular time.  It also allows for UI identification
    // of the intial process by bring that window to the foreground.
    public class SingleProgramInstance : IDisposable
    {
        //Win32 API calls necessary to raise an unowned process main window
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        //private members 
        private Mutex _processSync;

        private bool _owned = false;


        public SingleProgramInstance()
        {
            // Initialize a named mutex and attempt to get ownership immediately 
            _processSync = new Mutex(
                true, // desire initial ownership
                Assembly.GetExecutingAssembly().GetName().Name,
                out _owned);
        }

        public SingleProgramInstance(string identifier)
        {
            // Initialize a named mutex and attempt to get ownership immediately.
            // Use an additional identifier to lower our chances of another process creating
            // a mutex with the same name.
            _processSync = new Mutex(
                true, // desire initial ownership
                Assembly.GetExecutingAssembly().GetName().Name + identifier,
                out _owned);
        }

        ~SingleProgramInstance()
        {
            // Release mutex (if necessary) 
            // This should have been accomplished using Dispose() 
            Release();
        }

        public bool IsSingleInstance
        {
            // If we don't own the mutex then we are not the first instance.
            get { return _owned; }
        }

        public void RaiseOtherProcess(Process proc, Assembly executingAssembly)
        {
            if (proc == null)
                throw new ArgumentException("proc");

            if (executingAssembly == null)
                throw new ArgumentException("executingAssembly");

            // Using Process.ProcessName does not function properly when
            // the name exceeds 15 characters. Using the assembly name
            // takes care of this problem and is more accurate than other
            // work arounds.
            var assemblyName = executingAssembly.GetName().Name;
            foreach (var otherProc in Process.GetProcessesByName(assemblyName))
            {
                // Ignore this process
                if (proc.Id != otherProc.Id)
                {
                    // Found a "same named process".
                    // Assume it is the one we want brought to the foreground.
                    // Use the Win32 API to bring it to the foreground.
                    var hWnd = otherProc.MainWindowHandle;
                    if (IsIconic(hWnd))
                        ShowWindowAsync(hWnd, SW_RESTORE);

                    SetForegroundWindow(hWnd);
                    return;
                }
            }
        }

        private void Release()
        {
            if (!_owned)
                return;

            // If we own the mutex than release it so that
            // other "same" processes can now start.
            _processSync.ReleaseMutex();
            _owned = false;
        }

        #region Implementation of IDisposable

        public void Dispose()
        {
            // Release mutex (if necessary) and notify 
            // the garbage collector to ignore the destructor
            Release();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
