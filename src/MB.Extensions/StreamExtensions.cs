namespace MB.Extensions
{
    /// <summary>
    /// Extensions for streams
    /// </summary>
    public static class StreamExtensions
    {
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