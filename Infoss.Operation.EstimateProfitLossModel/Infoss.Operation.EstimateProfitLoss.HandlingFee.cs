namespace Infoss.Operation.EstimateProfitLossModel
{
    public class HandlingFee
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int EPLDetailId { get; set; } = 0;
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
        public string ModifiedBy { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
    }

}