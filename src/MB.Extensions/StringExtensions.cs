using System;

namespace MB.Extensions
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxlenght, string truncateChars = "")
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            if (value.Length > maxlenght)
            {
                return string.Concat(value.AsSpan(0, maxlenght), truncateChars);
            }
            return value;
        }
    }
}
