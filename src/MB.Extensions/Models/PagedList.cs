namespace MB.Extensions.Models
{

    /// <summary>
    /// Represents a paged list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedList<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{T}"/> class.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// pageNumber
        /// or
        /// pageSize
        /// </exception>
        public PagedList(IEnumerable<T> items, int pageNumber, int pageSize)
        {
            if (pageNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageNumber));
            }

            if (pageSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize));
            }

            var list = items.ToList();
            var totalItemCount = list.Count;
            this.PagingInfo = new PagingInfo(pageNumber, pageSize, totalItemCount);

            Result = list.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{T}"/> class.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// pageNumber
        /// or
        /// pageSize
        /// </exception>
        public PagedList(IQueryable<T> items, int pageNumber, int pageSize)
        {
            if (pageNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageNumber));
            }

            if (pageSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize));
            }

            var totalItemCount = items?.Count() ?? 0;
            this.PagingInfo = new PagingInfo(pageNumber, pageSize, totalItemCount);

            this.Result = items?.Skip(pageNumber * pageSize).Take(pageSize).ToList() ?? new List<T>();
        }

        /// <summary>
        /// Gets the paging information.
        /// </summary>
        /// <value>
        /// The paging information.
        /// </value>
        public PagingInfo PagingInfo { get; private set; }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public List<T> Result { get; private set; }
    }
}
