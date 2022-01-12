using System;
using System.Collections.Generic;
using System.Linq;

namespace DicomServer
{
    /// <summary>
    /// Helper class to aggregate inner exception objects.
    /// </summary>
    public static class AggregatedExceptionsHelper
    {
        /// <summary>
        /// Aggregate inner exception messages.
        /// </summary>
        /// <param name="exception">The exception object</param>
        /// <returns>Aggregated exception messages string</returns>
        public static String GetAllMessages(this Exception exception)
        {
            var messages = exception.FromHierarchy(ex => ex.InnerException)
                .Select(ex => ex.Message);
            return String.Join(Environment.NewLine, messages);
        }

        private static IEnumerable<TSource> FromHierarchy<TSource>(
            this TSource source,
            Func<TSource, TSource> nextItem,
            Func<TSource, bool> canContinue)
        {
            for (var current = source; canContinue(current); current = nextItem(current))
                yield return current;
        }

        private static IEnumerable<TSource> FromHierarchy<TSource>(
            this TSource source,
            Func<TSource, TSource> nextItem)
            where TSource : class
        {
            return FromHierarchy(source, nextItem, s => s != null);
        }
    }
}
