namespace MB.Extensions
{
    /// <summary>
    /// Extensions for streams
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// Converts to bytearray.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static byte[] ToByteArray(this Stream input)
        {
            using (var ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}