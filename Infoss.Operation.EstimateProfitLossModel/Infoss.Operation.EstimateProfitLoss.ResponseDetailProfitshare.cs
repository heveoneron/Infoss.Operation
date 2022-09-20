namespace Infoss.Operation.EstimateProfitLossModel
{
    public class EstimateProfitLossDetailProfitshareResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int EPLDetailId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int CustomerId { get; set; } = 0;
        public int CustomerTypeId { get; set; } = 0;
        public int Sequence { get; set; } = 0;
        public decimal Feet20 { get; set; } = 0;
        public decimal Feet40 { get; set; } = 0;
        public decimal FeetHQ { get; set; } = 0;
        public decimal FeetM3 { get; set; } = 0;
        public decimal Rate20 { get; set; } = 0;
        public decimal Rate40 { get; set; } = 0;
        public decimal RateHQ { get; set; } = 0;
        public decimal RateM3 { get; set; } = 0;
        public decimal BFeet20 { get; set; } = 0;
        public decimal BFeet40 { get; set; } = 0;
        public decimal BFeetHQ { get; set; } = 0;
        public decimal BFeetM3 { get; set; } = 0;
        public decimal BRate20 { get; set; } = 0;
        public decimal BRate40 { get; set; } = 0;
        public decimal BRateHQ { get; set; } = 0;
        public decimal BRateM3 { get; set; } = 0;
        public decimal Percentage { get; set; } = 0;
        public int IdLama { get; set; } = 0;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedOn { get; set; } = DateTime.Today;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Today;

    }
}
