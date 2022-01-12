using System;
using System.Globalization;
using System.Linq;

namespace Dicom.Data
{
    /// <summary>
    /// This class parses the DICOM date/time range information 
    /// to create .NET <see cref="DateTime"/> objects.
    /// </summary>
    public class DateTimeRangeQuery
    {
        #region Public Properties

        /// <summary>
        /// Gets/sets the lower .NET <see cref="DateTime"/> object.
        /// </summary>
        /// <value>The lower .NET <see cref="DateTime"/> object.</value>
        public DateTime From { get; internal set; }

        /// <summary>
        /// Gets/sets the higher .NET <see cref="DateTime"/> object.
        /// </summary>
        /// <value>The higher .NET <see cref="DateTime"/> object.</value>
        public DateTime To { get; internal set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Parses the DICOM date/time range information.
        /// </summary>
        /// <param name="dateString">The DICOM date string.</param>
        /// <param name="timeString">The DICOM time string.</param>
        /// <returns>The range object containing .NET <see cref="DateTime"/> objects.</returns>
        public static DateTimeRangeQuery Parse(String dateString, String timeString = null)
        {
            DateTimeRangeQuery query = null;

            var minValue = new DateTime(1800, 1, 1);
            var maxValue = new DateTime(9999, 1, 1);

            if (!dateString.Contains('-'))
            {
                var from = ParseDate(dateString, minValue);
                var to = new DateTime(from.Year, from.Month, from.Day, 23, 59, 59, 999);

                query = new DateTimeRangeQuery {From = from, To = to};
            }
            else
            {
                var rangeValues = dateString.Split(new char[] {'-'}, 2);

                DateTime from = minValue;
                DateTime to = maxValue;

                if (rangeValues.Length == 2)
                {
                    from = ParseDate(rangeValues[0], from);
                    to = ParseDate(rangeValues[1], to);

                    if (to.Hour == 0 && to.Minute == 0 && to.Second == 0)
                        to = new DateTime(to.Year, to.Month, to.Day, 23, 59, 59, 999);
                }

                query = new DateTimeRangeQuery {From = from, To = to};
            }

            if (String.IsNullOrWhiteSpace(timeString))
                return query;

            if (!timeString.Contains('-'))
            {
                var from = ParseTime(timeString, TimeSpan.Zero);
                var to = from;

                query.From = query.From.Add(from);
                query.To = query.To.Add(to);
            }
            else
            {
                var rangeValues = timeString.Split(new char[] {'-'}, 2);

                var from = TimeSpan.Zero;
                var to = new TimeSpan(0, 23, 59, 59, 999);

                query.To = new DateTime(query.To.Year, query.To.Month, query.To.Day);

                if (rangeValues.Length == 2)
                {
                    from = ParseTime(rangeValues[0], from);
                    to = ParseTime(rangeValues[1], to);

                    query.From = query.From.Add(from);
                    query.To = query.To.Add(to);
                }
            }

            return query;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Parses the DICOM date information.
        /// </summary>
        /// <param name="valueString">The DICOM date string.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The .NET <see cref="DateTime"/> object.</returns>
        private static DateTime ParseDate(String valueString, DateTime defaultValue)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(valueString))
                    return defaultValue;

                if (valueString.Length == 8)
                {
                    return DateTime.ParseExact(valueString, "yyyyMMdd", CultureInfo.InvariantCulture,
                        DateTimeStyles.AssumeLocal);
                }
                else
                {
                    return DateTime.ParseExact(valueString, "yyyyMMdd hh:mm", CultureInfo.InvariantCulture,
                        DateTimeStyles.AssumeLocal);
                }
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Parses the DICOM time information.
        /// </summary>
        /// <param name="valueString">The DICOM time string.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The .NET <see cref="TimeSpan"/> object.</returns>
        private static TimeSpan ParseTime(String valueString, TimeSpan defaultValue)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(valueString))
                    return defaultValue;

                if (valueString.Length == 10)
                {
                    var paddedString = valueString.Substring(0, 2) + ":" +
                                       valueString.Substring(2, 2) + ":" +
                                       valueString.Substring(4, 2) + "." +
                                       valueString.Substring(7, 3);

                    return TimeSpan.ParseExact(valueString, @"hhmmss\.fff", CultureInfo.InvariantCulture);
                }
                else
                {
                    return TimeSpan.ParseExact(valueString, "hhmmss", CultureInfo.InvariantCulture);
                }
            }
            catch
            {
                return defaultValue;
            }
        }

        #endregion
    }
}
