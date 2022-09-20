namespace Infoss.Operation.EstimateProfitLossModel
{
    public class EstimateProfitLossDetailDemurrageResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int EPLDetailId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int CustomerTypeId { get; set; } = 0;
        public int CustomerId { get; set; } = 0;
        public DateTime DateBackContainer { get; set; }
        public int Freetime { get; set; } = 0;
        public int Fase { get; set; } = 0;
        public int TotalContainer20 { get; set; } = 0;
        public int TotalContainer40 { get; set; } = 0;
        public string DiscType { get; set; } = string.Empty;
        public decimal DiscAmount { get; set; } = 0;
        public int IdLama { get; set; } = 0;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedOn { get; set; } = DateTime.Today;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Today;
        public List<EstimateProfitLossDetailDemurrageContainerResponse> EstimateProfitLossDetailDemurrageContainers { get; set; } = new List<EstimateProfitLossDetailDemurrageContainerResponse>();

    }
}
