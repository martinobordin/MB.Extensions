namespace MB.Extensions
{
    /// <summary>
    /// Extensions for IEnumerable
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        ///  Execute action for each item in the source IEnumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="action">The action.</param>
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

        /// <summary>
        /// Execute async action for each item in the source IEnumerable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="action">The action.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
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