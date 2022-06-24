namespace MB.Extensions
{
    /// <summary>
    /// Extensions for DateTime
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// The minimum value for small date time 
        /// </summary>
        public static readonly DateTime MinSmallDateTimeValue = new DateTime(1900, 01, 01);
        /// <summary>
        /// The maximum value for small date time 
        /// </summary>
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

        /// <summary>
        /// Converts utc date to specific timeZone.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="timeZone">The time zone.</param>
        /// <returns></returns>
        public static DateTime ToTimeZone(this DateTime date, TimeZoneInfo timeZone)
        {
            return TimeZoneInfo.ConvertTime(new DateTime(date.Ticks, DateTimeKind.Utc), timeZone);
        }
    }
}
