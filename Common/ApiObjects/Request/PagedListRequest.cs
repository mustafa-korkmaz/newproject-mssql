
namespace Common.ApiObjects.Request
{
    /// <summary>
    /// paged list which returned by betblogger api methods
    /// </summary>
    /// <typeparam name="T"> api paged list generic</typeparam>
    public class PagedListRequest
    {
        /// <summary>
        /// start index for apiPageList items
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// length of apiPageList items (items.count)
        /// </summary>
        public int Length { get; set; }
    }
}
