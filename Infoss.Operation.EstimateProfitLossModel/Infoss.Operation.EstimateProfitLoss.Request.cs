namespace Infoss.Operation.EstimateProfitLossModel
{
    public class EstimateProfitLossRequest
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int EPLNo { get; set; } = 0;
        public int ShipmentId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public decimal Rate { get; set; } = 0;
        public string ExRateDate { get; set; } = string.Empty;
        public decimal EstUSDShipCons { get; set; } = 0;
        public decimal EstIDRShipCons { get; set; } = 0;
        public decimal EstUSDAgent { get; set; } = 0;
        public decimal EstIDRAgent { get; set; } = 0;
        public int TimeCloseEPL { get; set; } = 0;
        public bool CloseEPL { get; set; }
        public DateTime ClosedEPLOn { get; set; }
        public int Period { get; set; } = 0;
        public int YearPeriod { get; set; } = 0;
        public int ExRateId { get; set; } = 0;
        public int IdLama { get; set; } = 0;
        public int Printing { get; set; } = 0;
        public DateTime PrintedOn { get; set; }
        public int Deleted { get; set; } = 0;
        public DateTime DeletedOn { get; set; }
        public string User { get; set; } = string.Empty;


    }

    public class QueryParameters
    {
        public int pageNo { get; set; }
        public int pageSize { get; set; }
    }
}