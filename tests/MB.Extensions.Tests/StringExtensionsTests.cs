using FluentAssertions;

namespace MB.Extensions.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Truncate_WorksForNullString()
        {
            string? myString = null;
            var result = myString.Truncate(10);
            result.Should().BeNull();
        }

        [Fact]
        public void Truncate_WorksForWhiteSpaceString()
        {
            var myString = string.Empty;
            var result = myString.Truncate(10);
            result.Should().BeEmpty();
        }

        [Fact]
        public void Truncate_WorksForLongString()
        {
            var myString = "thisisalongstring";
            var result = myString.Truncate(10);
            result.Should().Be("thisisalon");
        }

        [Fact]
        public void Truncate_WorksForLongStringWithTruncateChars()
        {
            var myString = "thisisalongstring";
            var result = myString.Truncate(10, "...");
            result.Should().Be("thisisalon...");
        }

        [Fact]
        public void Truncate_WorksForShortString()
        {
            var myString = "thisstring";
            var result = myString.Truncate(10);
            result.Should().Be("thisstring");
        }

        [Fact]
        public void Truncate_WorksForShortStringWithTruncateChars()
        {
            var myString = "thisstring";
            var result = myString.Truncate(10, "...");
            result.Should().Be("thisstring");
        }

        [Fact]
        public void Base64EncodeDecode_Works()
        {
            var myString = "thisstring";
            var myStringEncoded = "dGhpc3N0cmluZw==";
            
            myString.Base64Encode().Should().Be(myStringEncoded);
            myStringEncoded.Base64Decode().Should().Be(myString);
        }
    }
}