namespace ShopShoes.Model.Paging
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; set; }
        public int TotalCount { get; set; }
        public PaginatedList(List<T> item, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalCount = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(item);
        }
        public static PaginatedList<T> Create(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

    }
}
