namespace Infoss.Operation.EstimateProfitLossModel
{
    public class ResponseInvoice
    {
        public int Id { get; set; } = 0;
        public string InvoiceNo { get; set; } = "0";
        public string InvoiceName { get; set; } = "0";
        public DateTime InvoiceDate { get; set; } = DateTime.Today;
        public string InvoiceType { get; set; } = "0";
        public string IsDeleted { get; set; } = "0";
        public decimal IsActive { get; set; } = 0;
        public DateTime ExpiredDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Today;
        public string CreatedBy { get; set; } = string.Empty;

    }

    public class responsePaginationInvoice
    {
        public IEnumerable<ResponseInvoice> list { get; set; }
        public int pageSize { get; set; }
        public int PageNo{ get; set; }
        public int RecordCount { get; set; }

    }
}
