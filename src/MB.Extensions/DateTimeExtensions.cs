namespace MB.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime ToSmallDateTime(this DateTime value)
        {
            DateTime minSmallDateTimeValue = new DateTime(1900, 01, 01);
            DateTime maxSmallDateTimeValue = new DateTime(2079, 06, 06);

            var convertedDateTime = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0);

            if (convertedDateTime > maxSmallDateTimeValue)
            {
                return maxSmallDateTimeValue;
            }

            if (convertedDateTime < minSmallDateTimeValue)
            {
                return minSmallDateTimeValue;
            }

            return convertedDateTime;
        }

        public static DateTime TrimMilliseconds(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, dt.Kind);
        }
    }
}
