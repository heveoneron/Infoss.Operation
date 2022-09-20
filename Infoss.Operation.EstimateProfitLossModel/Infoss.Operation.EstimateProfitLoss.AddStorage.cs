namespace Infoss.Operation.EstimateProfitLossModel
{
    public class AddStorage
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int EPLDetailId { get; set; } = 0;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int StorageDetailId { get; set; } = 0;
        public decimal AmountIDR { get; set; } = 0;
        public decimal AmountUSD { get; set; } = 0;
        public int StorageId { get; set; } = 0;
        public string ModifiedBy { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
    }

}