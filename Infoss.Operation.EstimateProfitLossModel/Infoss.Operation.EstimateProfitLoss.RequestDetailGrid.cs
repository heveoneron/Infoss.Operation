namespace Infoss.Operation.EstimateProfitLossModel
{
    public class EstimateProfitLossRequestDetailGrid
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int EPLId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public int Sequence { get; set; } = 0;
        public bool IsIncome { get; set; }
        public int CustomerId { get; set; } = 0;
        public int CustomerTypeId { get; set; } = 0;
        public int AccountId { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public bool CodingQuantity { get; set; }
        public int Type { get; set; } = 0;
        public decimal Quantity { get; set; } = 0;
        public decimal PerQty { get; set; } = 0;
        public int AmountCrr { get; set; } = 0;
        public decimal AmountUSD { get; set; } = 0;
        public decimal AmountIDR { get; set; } = 0;
        public bool Sign { get; set; }
        public bool DataFrom { get; set; }
        public int MemoNo { get; set; } = 0;
        public bool StatusMemo { get; set; }
        public DateTime CreatedMemoOn { get; set; }
        public bool PaidPR { get; set; }
        public bool IsSplitIncCost { get; set; }
        public int IdLama { get; set; } = 0;
        public bool IsCostToCost { get; set; }
        public int truck_detail_id { get; set; } = 0;
        public bool IsCostTrucking { get; set; }
        public bool IsAdditional { get; set; }
        public bool IsIgnoreItem { get; set; }
        public int KendaraanId { get; set; } = 0;
        public string KendaraanNopol { get; set; } = string.Empty;
        public int EmployeeId { get; set; } = 0;
        public string EmployeeName { get; set; } = string.Empty;
        public int MrgId { get; set; } = 0;
        public DateTime DeliveryDate { get; set; }
        public decimal OriginalUsd { get; set; } = 0;
        public decimal OriginalRate { get; set; } = 0;
        public int BookingDetailId { get; set; } = 0;
        public string User { get; set; } = string.Empty;

        public AddStorage? addStorage { get; set; }
        public HandlingFee? handlingFee { get; set; }
        public ProfitShare? profitShare { get; set; }
        

    }
}
