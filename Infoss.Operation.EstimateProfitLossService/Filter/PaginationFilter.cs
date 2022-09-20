namespace Infoss.Operation.EstimateProfitLossService.Filter
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int CountryId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }

        public PaginationFilter()
        {
            this.PageNumber = 1;
            this.PageSize = 10;
        }
        public PaginationFilter(int numPage, int sizePage)
        {

            this.PageNumber = numPage;
            this.PageSize = sizePage;
        }
    }

}
