namespace MB.Extensions
{
    /// <summary>
    /// Extensions for string
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Truncates the specified maxlenght.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="maxlenght">The maxlenght.</param>
        /// <param name="truncateChars">The truncate chars.</param>
        /// <returns></returns>
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
