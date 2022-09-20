using Infoss.Operation.EstimateProfitLossService.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Infoss.Operation.EstimateProfitLossService.Repositories
{
    public interface IEstimateProfitLossRepository
    {
        public Task<PageSetResponse<EstimateProfitLossResponse>> ReadHeader(int PageNumber, int PageSize, int CountryId, int CompanyId, int BranchId);
        public Task<Response<EstimateProfitLossResponse>> CreateHeader(EstimateProfitLossRequest estimateProfitLossRequest);
        public Task<Response<EstimateProfitLossResponse>> UpdateHeader(EstimateProfitLossRequest estimateProfitLossRequest);
        public Task<Response<EstimateProfitLossResponse>> DeleteHeader(int Id, int Status);
        public Task<Response<EstimateProfitLossResponse2>> Read(int id);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> Create(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> Update(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> Delete(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid);

        public Task<Response<EstimateProfitLossRequestDetailGrid>> getStorage(int IdEflDetail);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> CreateStorage(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, AddStorage addStorage);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> UpdateStorage(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, AddStorage addStorage);

        public Task<Response<EstimateProfitLossRequestDetailGrid>> getHandlingFee(int IdEflDetail);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> CreateHandlingFee(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, HandlingFee handlingFee);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> UpdateHandlingFee(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, HandlingFee handlingFee);

        public Task<Response<EstimateProfitLossRequestDetailGrid>> getProfitShare(int IdEflDetail);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> CreateProfitShare(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, ProfitShare profitShare);
        public Task<Response<EstimateProfitLossRequestDetailGrid>> UpdateProfitShare(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, ProfitShare profitShare);

    }
}
