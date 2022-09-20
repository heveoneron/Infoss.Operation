namespace Infoss.Operation.EstimateProfitLossModel
{
    public class EstimateProfitLossDetailDemurrageContainerDetailResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int EPLDetailDmrContainerId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int DayContainer { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public decimal AmountContainer20 { get; set; } = 0;
        public decimal AmountContainer40 { get; set; } = 0;
        public int IdLama { get; set; } = 0;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedOn { get; set; } = DateTime.Today;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Today;
    }
}
