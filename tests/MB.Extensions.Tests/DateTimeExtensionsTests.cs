using FluentAssertions;

namespace MB.Extensions.Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void ToSmallDateTime_WorksForValidMinDate()
        {
            var myDate = new DateTime(2000, 01, 01);
            var result = myDate.ToSmallDateTime();
            result.Should().Be(myDate);
        }

        [Fact]
        public void ToSmallDateTime_WorksForInvalidMinDate()
        {
            var myDate = new DateTime(1800, 01, 01);
            var result = myDate.ToSmallDateTime();
            result.Should().Be(DateTimeExtensions.MinSmallDateTimeValue);
        }

        [Fact]
        public void ToSmallDateTime_WorksForValidMaxDate()
        {
            var myDate = new DateTime(2000, 01, 01);
            var result = myDate.ToSmallDateTime();
            result.Should().Be(myDate);
        }

        [Fact]
        public void ToSmallDateTime_WorksForInvalidMaxDate()
        {
            var myDate = new DateTime(2080, 01, 01);
            var result = myDate.ToSmallDateTime();
            result.Should().Be(DateTimeExtensions.MaxSmallDateTimeValue);
        }
    }
}