namespace Infoss.Operation.EstimateProfitLossModel
{
    public class EstimateProfitLossDetailDemurrageContainerResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int EPLDetailDemurrageId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public string ContainerNo { get; set; } = string.Empty;
        public int IdLama { get; set; } = 0;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedOn { get; set; } = DateTime.Today;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Today;
        public List<EstimateProfitLossDetailDemurrageContainerDetailResponse> EstimateProfitLossDetailDemurrageContainerDetails { get; set; } = new List<EstimateProfitLossDetailDemurrageContainerDetailResponse>();

    }
}
