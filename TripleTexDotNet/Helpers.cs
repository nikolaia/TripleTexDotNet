using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TripleTexDotNet
{
    public static class Helpers
    {
        public static string ObjectToCsvString(object o)
        {
            var properties = o.GetType().GetProperties();
            var sb = new StringBuilder();

            foreach (var prp in properties.Where(prp => prp.CanRead))
            {
                sb.Append(prp.GetValue(o, null)).Append(';');
            }
            sb.Length--; // Remove last ";"
            sb.AppendLine();

            return sb.ToString();
        }

        public static object[] ObjectToObjectArray(object o)
        {
            var properties = o.GetType().GetProperties();
            var sb = properties.Where(prp => prp.CanRead).Select(prp => prp.GetValue(o, null)).ToArray();

            return sb;
        }

        public static string DateTimeToString(DateTime time)
        {
            return time.ToString("yyyy-MM-dd");
        }

        public static DateTime StringToDateTime(string time)
        {
            return DateTime.ParseExact(time, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
    }
}
