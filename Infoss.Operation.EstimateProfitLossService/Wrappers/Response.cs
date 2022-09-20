namespace Infoss.Operation.EstimateProfitLossService.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
        }
        public Response(T datas)
        {
            status = 200;
            succeeded = true;
            message = string.Empty;
            errors = string.Empty;
            data = datas;
        }
        public int status { get; set; }
        public T data { get; set; }
        public bool succeeded { get; set; }
        public string errors { get; set; }
        public string message { get; set; }
    }

    public class PageSetResponse<T>
    {
        public PageSetResponse()
        {
        }

        public PageSetResponse(List<T> data)
        {
            Code = 200;
            Message = string.Empty;
            CountData= 0;
            Data = data;
        }

        public int Code { get; set; }
        public int CountData { get; set; }
        public List<T> Data { get; set; }
        public string Message { get; set; }

    }
}
