namespace MB.Extensions.Models
{
    /// <summary>
    /// Represents paging info
    /// </summary>
    public class PagingInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingInfo"/> class.
        /// </summary>
        public PagingInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingInfo"/> class.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="totalItemCount">The total item count.</param>
        public PagingInfo(int pageNumber, int pageSize, int totalItemCount)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItemCount = totalItemCount;
        }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>
        /// The page number.
        /// </value>
        public int PageNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the size of the page.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        public int PageSize
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the total item count.
        /// </summary>
        /// <value>
        /// The total item count.
        /// </value>
        public int TotalItemCount
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the page count.
        /// </summary>
        /// <value>
        /// The page count.
        /// </value>
        public int PageCount
        {
            get
            {
                return TotalItemCount > 0
                    ? (int)Math.Ceiling(TotalItemCount / (double)PageSize)
                    : 0;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has previous page.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has previous page; otherwise, <c>false</c>.
        /// </value>
        public bool HasPreviousPage
        {
            get
            {
                return PageNumber > 0;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has next page.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has next page; otherwise, <c>false</c>.
        /// </value>
        public bool HasNextPage
        {
            get
            {
                return PageNumber < PageCount - 1;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is first page.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is first page; otherwise, <c>false</c>.
        /// </value>
        public bool IsFirstPage
        {
            get
            {
                return PageNumber == 0;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is last page.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is last page; otherwise, <c>false</c>.
        /// </value>
        public bool IsLastPage
        {
            get
            {
                return PageNumber == PageCount - 1;
            }
        }

        /// <summary>
        /// Gets the first item on page.
        /// </summary>
        /// <value>
        /// The first item on page.
        /// </value>
        public int FirstItemOnPage
        {
            get
            {
                return PageNumber * PageSize;
            }
        }

        /// <summary>
        /// Gets the last item on page.
        /// </summary>
        /// <value>
        /// The last item on page.
        /// </value>
        public int LastItemOnPage
        {
            get
            {
                var numberOfLastItemOnPage = FirstItemOnPage + PageSize - 1;
                return numberOfLastItemOnPage > TotalItemCount
                    ? TotalItemCount
                    : numberOfLastItemOnPage;
            }
        }
    }
}
