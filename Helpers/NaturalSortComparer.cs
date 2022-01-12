using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DicomServer
{
    /// <summary>
    /// This class create a comparer that sort using a natural order.
    /// </summary>
    public class NaturalSortComparer<T> : IComparer<String>, IDisposable
    {
        #region Private Variables

        /// <summary>
        /// The dictionary used for the natural sorting.
        /// </summary>
        private Dictionary<String, String[]> _table = new Dictionary<String, String[]>();

        /// <summary>
        /// The sorting order.
        /// </summary>
        private readonly bool _isAscending;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalSortComparer{T}"/> class.
        /// </summary>
        /// <param name="inAscendingOrder">The provided sorting order.</param>
        public NaturalSortComparer(bool inAscendingOrder = true)
        {
            _isAscending = inAscendingOrder;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The comparing function.
        /// </summary>
        /// <param name="x">The string to compare.</param>
        /// <param name="y">The string to compare.</param>
        public int Compare(String x, String y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The comparing function.
        /// </summary>
        /// <param name="x">The string to compare.</param>
        /// <param name="y">The string to compare.</param>
        int IComparer<String>.Compare(String x, String y)
        {
            if (x == y)
                return 0;

            String[] x1, y1;

            if (!_table.TryGetValue(x, out x1))
            {
                x1 = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
                _table.Add(x, x1);
            }

            if (!_table.TryGetValue(y, out y1))
            {
                y1 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");
                _table.Add(y, y1);
            }

            int returnVal;

            for (int i = 0; i < x1.Length && i < y1.Length; i++)
            {
                if (x1[i] != y1[i])
                {
                    returnVal = PartCompare(x1[i], y1[i]);
                    return _isAscending ? returnVal : -returnVal;
                }
            }

            if (y1.Length > x1.Length)
                returnVal = 1;
            else if (x1.Length > y1.Length)
                returnVal = -1;
            else
                returnVal = 0;

            return _isAscending ? returnVal : -returnVal;
        }

        #endregion

        #region Private Methods

        private static int PartCompare(String left, String right)
        {
            int x, y;
            if (!int.TryParse(left, out x))
                return left.CompareTo(right);

            if (!int.TryParse(right, out y))
                return left.CompareTo(right);

            return x.CompareTo(y);
        }

        #endregion

        /// <summary> 
        /// Disposes the object and frees resources for the Garbage Collector. 
        /// </summary> 
        public void Dispose()
        {
            _table.Clear();
            _table = null;
        }
    }
}
