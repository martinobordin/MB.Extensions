namespace MB.Extensions
{
    public static class CollectionExtensions
    {
        public static void ForEach<T>(this IEnumerable<T>? source, Action<T> action)
        {
            if (source is null)
            {
                return;
            }

            foreach (var item in source)
            {
                action(item);
            }
        }

        public static async Task ForEachAsync<T>(this IEnumerable<T>? source, Func<T, Task> action, CancellationToken cancellationToken = default)
        {
            if (source is null)
            {
                return;
            }

            foreach (var item in source)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await action.Invoke(item).ConfigureAwait(false);
            }
        }
    }
}