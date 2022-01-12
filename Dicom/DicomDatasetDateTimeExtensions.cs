using System;
using System.Globalization;

namespace Dicom.Data
{
    /// <summary>
    /// This class extends the DICOM dataset class to allow retrieval of 
    /// nullable <see cref="DateTime"/> objects.
    /// </summary>
    public static class DicomDatasetDateTimeExtensions
    {
        #region Private Variables

        /// <summary>
        /// The parseable DICOM date formats.
        /// </summary>
        private static String[] _dateFormats;

        /// <summary>
        /// The parseable DICOM date formats.
        /// </summary>
        private static String[] _timeFormats;

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes the date formats.
        /// </summary>
        private static void InitDateFormats()
        {
            if (_dateFormats != null)
                return;

            _dateFormats = new String[6];
            _dateFormats[0] = "yyyyMMdd";
            _dateFormats[1] = "yyyy.MM.dd";
            _dateFormats[2] = "yyyy/MM/dd";
            _dateFormats[3] = "yyyy";
            _dateFormats[4] = "yyyyMM";
            _dateFormats[5] = "yyyy.MM";
        }

        /// <summary>
        /// Initializes the time formats.
        /// </summary>
        private static void InitTimeFormats()
        {
            if (_timeFormats != null)
                return;

            _timeFormats = new String[31];
            _timeFormats[0] = "HHmmss";
            _timeFormats[1] = "HH";
            _timeFormats[2] = "HHmm";
            _timeFormats[3] = "HHmmssf";
            _timeFormats[4] = "HHmmssff";
            _timeFormats[5] = "HHmmssfff";
            _timeFormats[6] = "HHmmssffff";
            _timeFormats[7] = "HHmmssfffff";
            _timeFormats[8] = "HHmmssffffff";
            _timeFormats[9] = "HHmmss.f";
            _timeFormats[10] = "HHmmss.ff";
            _timeFormats[11] = "HHmmss.fff";
            _timeFormats[12] = "HHmmss.ffff";
            _timeFormats[13] = "HHmmss.fffff";
            _timeFormats[14] = "HHmmss.ffffff";
            _timeFormats[15] = "HH.mm";
            _timeFormats[16] = "HH.mm.ss";
            _timeFormats[17] = "HH.mm.ss.f";
            _timeFormats[18] = "HH.mm.ss.ff";
            _timeFormats[19] = "HH.mm.ss.fff";
            _timeFormats[20] = "HH.mm.ss.ffff";
            _timeFormats[21] = "HH.mm.ss.fffff";
            _timeFormats[22] = "HH.mm.ss.ffffff";
            _timeFormats[23] = "HH:mm";
            _timeFormats[24] = "HH:mm:ss";
            _timeFormats[25] = "HH:mm:ss:f";
            _timeFormats[26] = "HH:mm:ss:ff";
            _timeFormats[27] = "HH:mm:ss:fff";
            _timeFormats[28] = "HH:mm:ss:ffff";
            _timeFormats[29] = "HH:mm:ss:fffff";
            _timeFormats[30] = "HH:mm:ss:ffffff";
            _timeFormats[25] = "HH:mm:ss.f";
            _timeFormats[26] = "HH:mm:ss.ff";
            _timeFormats[27] = "HH:mm:ss.fff";
            _timeFormats[28] = "HH:mm:ss.ffff";
            _timeFormats[29] = "HH:mm:ss.fffff";
            _timeFormats[30] = "HH:mm:ss.ffffff";
        }

        /// <summary>
        /// Parses the provided DICOM date string.
        /// </summary>
        /// <param name="date">The DICOM date string.</param>
        /// <returns>A nullable .NET <see cref="DateTime"/> object containing
        /// the parsed date in case of a success.</returns>
        private static DateTime? ParseDate(String date)
        {
            try
            {
                return DateTime.ParseExact(date, _dateFormats,
                    CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Parses the provided DICOM time string.
        /// </summary>
        /// <param name="time">The DICOM date string.</param>
        /// <returns>A nullable .NET <see cref="DateTime"/> object containing
        /// the parsed time in case of a success.</returns>
        private static DateTime? ParseTime(String time)
        {
            try
            {
                return DateTime.ParseExact(time, _timeFormats,
                    CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Parses the date from provided DICOM date tag object.
        /// </summary>
        /// <param name="dataset">The DICOM dataset.</param>
        /// <param name="date">The DICOM date tag object.</param>
        /// <returns>A nullable .NET <see cref="DateTime"/> object containing
        /// the parsed date in case of a success.</returns>
        public static DateTime? GetNullableDateTime(this DicomDataset dataset, DicomTag date)
        {
            return GetNullableDateTime(dataset, date, null);
        }

        /// <summary>
        /// Parses the date and time from provided DICOM date and time tag objects.
        /// </summary>
        /// <param name="dataset">The DICOM dataset.</param>
        /// <param name="date">The DICOM date tag object.</param>
        /// <param name="time">The DICOM time tag object.</param>
        /// <returns>A nullable .NET <see cref="DateTime"/> object containing
        /// the parsed date and time in case of a success.</returns>
        public static DateTime? GetNullableDateTime(this DicomDataset dataset, DicomTag date, DicomTag time)
        {
            InitDateFormats();
            InitTimeFormats();

            var dd = date != null && dataset.Contains(date) ? dataset.Get<DicomDate>(date, null) : null;
            var dt = time != null && dataset.Contains(time) ? dataset.Get<DicomTime>(time, null) : null;

            var da = dd != null && dd.Count > 0 ? ParseDate(dd.Get<String>(0)) : null;
            var tm = dt != null && dt.Count > 0 ? ParseTime(dt.Get<String>(0)) : null;

            // No date? Don't care about time.
            if (!da.HasValue)
                return null;

            return new DateTime(da.Value.Year, da.Value.Month, da.Value.Day,
                tm.HasValue ? tm.Value.Hour : 0,
                tm.HasValue ? tm.Value.Minute : 0,
                tm.HasValue ? tm.Value.Second : 0);
        }

        #endregion
    }
}
