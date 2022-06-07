using FluentAssertions;

namespace MB.Extensions.Tests
{
    public class IEnumerableExtensionsTests
    {
        [Fact]
        public void ForEach_WorksForNullIEnumerable()
        {
            IEnumerable<string>? list = null;
            var callCount = 0;
            list.ForEach(x => callCount++);
            callCount.Should().Be(0);
        }

        [Fact]
        public async Task ForEach_WorksForNotNullIEnumerable()
        {
            IEnumerable<string>? list = null;
            var callCount = 0;
            await list.ForEachAsync(x => Task.Run(() => callCount++));
            callCount.Should().Be(0);
        }

        [Fact]
        public void ForEachAsync_WorksForNullIEnumerable()
        {
            IEnumerable<string>? list = new List<string> { "a", "b", "c"};
            var callCount = 0;
            list.ForEach(x => callCount++);
            callCount.Should().Be(list.Count());
        }

        [Fact]
        public async Task ForEachAsync_WorksForNotNullIEnumerable()
        {
            IEnumerable<string>? list = new List<string> { "a", "b", "c" };
            var callCount = 0;
            await list.ForEachAsync(x => Task.Run(() => callCount++));
            callCount.Should().Be(list.Count());
        }
    }
}