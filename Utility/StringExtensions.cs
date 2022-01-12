using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Repositories
{
    public static class stringExtensions
    {
        public static byte[] GetBytes(this string str)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            return UE.GetBytes(str);
        }
        public static string Getstring(this byte[] data)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            return UE.GetString(data);
        }

        public static bool ContainsInvariant(this string sourceString, string filter)
        {
            return sourceString.ToLowerInvariant().Contains(filter);
        }

        public static string Slice(this string source, int start, int end)
        {
            if (end < 0) // Keep this for negative end support
            {
                end = source.Length + end;
            }
            int len = end - start;               // Calculate length
            return source.Substring(start, len); // Return Substring of length
        }
    }
}
