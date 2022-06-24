using System.Text;

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
        public static string Truncate(this string? value, int maxlenght, string truncateChars = "")
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

        /// <summary>
        /// Encode string to base64.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <returns></returns>
        public static string Base64Encode(this string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Decode string from base64.
        /// </summary>
        /// <param name="base64EncodedData">The base64 encoded data.</param>
        /// <returns></returns>
        public static string Base64Decode(this string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }


        /// <summary>
        /// Gets the name of the valid file system.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="replaceChar">The replace character.</param>
        /// <returns></returns>
        public static string GetValidFileSystemName(this string filename, char replaceChar = '_')
        {
            var invalidFileNameChars = Path.GetInvalidFileNameChars();
            foreach (var c in invalidFileNameChars)
            {
                filename = filename.Replace(c, replaceChar);
            }

            return filename;
        }
    }
}
