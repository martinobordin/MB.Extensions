namespace MB.Extensions
{
    public static class DateTimeExtensions
    {
        public static readonly DateTime MinSmallDateTimeValue = new DateTime(1900, 01, 01);
        public static readonly DateTime MaxSmallDateTimeValue = new DateTime(2079, 06, 06);

        public static DateTime ToSmallDateTime(this DateTime value)
        {
            var convertedDateTime = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);

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

        public static DateTime TrimMilliseconds(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, dt.Kind);
        }
    }
}
