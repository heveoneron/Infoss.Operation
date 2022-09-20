using Infoss.Operation.EstimateProfitLossService.Filter;

namespace Infoss.Operation.EstimateProfitLossService.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);

    }
}
