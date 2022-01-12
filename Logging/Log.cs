using NLog;

namespace DicomServer
{
    /// <summary>
    /// This class provides the application's logging facilities.
    /// </summary>
    public static class Log
    {
        #region Private Variables

        /// <summary>
        /// The application's logging object.
        /// </summary>
        private static Logger _applog;

        /// <summary>
        /// The database's logging object.
        /// </summary>
        private static Logger _databaselog;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the application's logging object.
        /// </summary>
        /// <value>The application's logging object.</value>
        public static Logger ApplicationLog
        {
            get
            {
                if (_applog == null)
                    _applog = LogManager.GetLogger("APPLICATION");

                return _applog;
            }
            set { _applog = value; }
        }

        /// <summary>
        /// Gets the database's logging object.
        /// </summary>
        /// <value>The database's logging object.</value>
        public static Logger DatabaseLog
        {
            get
            {
                if (_databaselog == null)
                    _databaselog = LogManager.GetLogger("DATABASE");

                return _databaselog;
            }
            set { _databaselog = value; }
        }

        #endregion
    }
}
