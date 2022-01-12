using RIS.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace DicomServer
{
    /// <summary>
    /// This class provides helpers to query the application's starting directory.
    /// </summary>
    public class DirectoryHelpers
    {
        #region Private Variables

        /// <summary>
        /// The application's starting directory.
        /// </summary>
        private static String _startdir;

        #endregion

        #region Public Methods

        /// <summary>
        /// Query the application's starting directory.
        /// </summary>
        /// <returns>The application's starting directory.</returns>
        public static String GetStartDirectory()
        {
            if (_startdir == null)
            {
                _startdir = Process.GetCurrentProcess().StartInfo.WorkingDirectory;
                if (String.IsNullOrEmpty(_startdir))
                {
                    _startdir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName()
                        .CodeBase);
                    _startdir = _startdir.Substring(6);
                }
            }

            return _startdir;
        }

        #endregion
    }

    /// <summary>
    /// This class provides helpers to provide a safe tenant directory.
    /// </summary>
    public static class TenantPathHelpers
    {
        /// <summary>
        /// Gets the safe tenant directory.
        /// </summary>
        /// <returns>The tenant's safe directory.</returns>
        public static String GetTenantPath(this Tenant tenant)
        {
            var invalidCharacters = Regex.Escape(new String(Path.GetInvalidFileNameChars()));
            var invalidRegularExpressionString = String.Format(@"([{0}]*\.+$)|([{0}]+)", invalidCharacters);

            return ""; //Regex.Replace(tenant.TenantName, invalidRegularExpressionString, "_");
        }
    }
}
