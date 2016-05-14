
using System.Collections.Generic;
using System.Linq;

namespace Common.ApiObjects.Response
{
    /// <summary>
    /// paged list which returned by betblogger api methods
    /// </summary>
    /// <typeparam name="T"> api paged list generic</typeparam>
    public class PagedListResponse<T>
    {
        public IEnumerable<T> Items { get; set; }

        public bool IsFirstPage => Start == 0;

        public bool IsLastPage => RecordsTotal - (Start * Length) < Length;

        public int Start { get; set; }

        public int Length { set; get; }

        public int RecordsTotal { get; set; }

    }
}
