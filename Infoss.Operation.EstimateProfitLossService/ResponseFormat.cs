namespace Infoss.Operation.EstimateProfitLossService
{
    public class ResponseFormat
    {
        public int Code { get; set; }
        public string Message { get; set; } = string.Empty;
        public Array? Datas { get; set; }
    }
}
