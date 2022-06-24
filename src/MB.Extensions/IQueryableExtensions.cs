using MB.Extensions.Models;

namespace MB.Extensions
{
    /// <summary>
    /// Extensions for IQueryable
    /// </summary>
    public static class IQueryableExtensions
    {
        /// <summary>
        /// Converts the source items to paged list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        public static PagedList<T> ToPagedList<T>(this IQueryable<T> source, int pageNumber, int pageSize)
        {
            return new PagedList<T>(source, pageNumber, pageSize);
        }
    }
}