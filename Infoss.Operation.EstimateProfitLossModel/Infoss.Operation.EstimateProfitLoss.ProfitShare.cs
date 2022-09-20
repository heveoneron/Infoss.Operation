namespace Infoss.Operation.EstimateProfitLossModel
{
    public class ProfitShare
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int CustomerId { get; set; } = 0;
        public int CustomerTypeId { get; set; } = 0;
        public int Sequence { get; set; } = 0;
        public decimal SFeet20 { get; set; } = 0;
        public decimal SFeet40 { get; set; } = 0;
        public decimal SFeetHQ { get; set; } = 0;
        public decimal SFeetM3 { get; set; } = 0;
        public decimal SRate20 { get; set; } = 0;
        public decimal SRate40 { get; set; } = 0;
        public decimal SRateHQ { get; set; } = 0;
        public decimal SRateM3 { get; set; } = 0;
        public decimal BFeet20 { get; set; } = 0;
        public decimal BFeet40 { get; set; } = 0;
        public decimal BFeetHQ { get; set; } = 0;
        public decimal BFeetM3 { get; set; } = 0;
        public decimal BRate20 { get; set; } = 0;
        public decimal BRate40 { get; set; } = 0;
        public decimal BRateHQ { get; set; } = 0;
        public decimal BRateM3 { get; set; } = 0;
        public decimal Percentage { get; set; } = 0;
        public string ModifiedBy { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;

    }

    public class RequestProfitShare
    {
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int CustomerId { get; set; } = 0;
        public int CustomerTypeId { get; set; } = 0;
        public int Sequence { get; set; } = 0;
        public decimal SFeet20 { get; set; } = 0;
        public decimal SFeet40 { get; set; } = 0;
        public decimal SFeetHQ { get; set; } = 0;
        public decimal SFeetM3 { get; set; } = 0;
        public decimal SRate20 { get; set; } = 0;
        public decimal SRate40 { get; set; } = 0;
        public decimal SRateHQ { get; set; } = 0;
        public decimal SRateM3 { get; set; } = 0;
        public decimal BFeet20 { get; set; } = 0;
        public decimal BFeet40 { get; set; } = 0;
        public decimal BFeetHQ { get; set; } = 0;
        public decimal BFeetM3 { get; set; } = 0;
        public decimal BRate20 { get; set; } = 0;
        public decimal BRate40 { get; set; } = 0;
        public decimal BRateHQ { get; set; } = 0;
        public decimal BRateM3 { get; set; } = 0;
        public decimal Percentage { get; set; } = 0;
        public string CreatedBy { get; set; } = string.Empty;
    }

}