namespace MB.Extensions
{
    /// <summary>
    /// Extensions for DateTime
    /// </summary>
    public static class DateTimeExtensions
    {
        public static readonly DateTime MinSmallDateTimeValue = new DateTime(1900, 01, 01);
        public static readonly DateTime MaxSmallDateTimeValue = new DateTime(2079, 06, 06);

        /// <summary>
        /// Converts date to smalldatetime.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static DateTime ToSmallDateTime(this DateTime date)
        {
            var convertedDateTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);

            if (convertedDateTime > MaxSmallDateTimeValue)
            {
                return MaxSmallDateTimeValue;
            }

            if (convertedDateTime < MinSmallDateTimeValue)
            {
                return MinSmallDateTimeValue;
            }

            return convertedDateTime;
        }

        /// <summary>
        /// Trims the milliseconds from date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static DateTime TrimMilliseconds(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0, date.Kind);
        }
    }
}
