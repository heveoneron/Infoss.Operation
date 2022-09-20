using System.Data;
using System.Data.SqlClient;
using Dapper;
using Infoss.Operation.EstimateProfitLossService.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Infoss.Operation.EstimateProfitLossService.Repositories
{
    public class EstimateProfitLossRepository : IEstimateProfitLossRepository
    {   
        private string connectionString = string.Empty;

        public EstimateProfitLossRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("SqlConnection");
        }
        string ResponseMessageDetailEPL(int code, bool typeMessage, string actionMessage, string statusMessage)
        {
            string message;
            switch (code)
            {
                case 2:
                    if (typeMessage)
                    {
                        message = "Inc Shipper";
                    }
                    else
                    {
                        message = "Cost Rebaate";
                    }
                    break;
                case 5:
                    if (typeMessage)
                    {
                        message = "Inc Agent";
                    }
                    else
                    {
                        message = "Cost Agent";
                    }
                    break;
                case 11:
                    message = "Cost SSLine";
                    break;
                case 6:
                    message = "Cost EMKL";
                    break;
                case 7:
                    message = "Cost Depo ";
                    break;
                default:
                    if (typeMessage)
                    {
                        message = "EPL Header";
                    }
                    else
                    {
                        message = "EPL Detail";

                    }
                    break;
            }

            return $"{actionMessage} {message} {statusMessage}"; ;
        }


        #region Detail Repository
        public async Task<Response<EstimateProfitLossResponse2>> Read(int id)
        {
            var results = new Response<EstimateProfitLossResponse2>();

            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CountryId", 101);
                parameters.Add("@CompanyId", 32);
                parameters.Add("@BranchId", 12);
                parameters.Add("@Id", id);
                parameters.Add("@PageNo", 0);
                parameters.Add("@PageSize", 0);

                using (var connection = new SqlConnection(connectionString))
                {
                    using (var multi = (await connection.QueryMultipleAsync("operation.SP_EstimateProfitLoss_Read", parameters, commandType: CommandType.StoredProcedure)))
                    {
                        var estimateProfitLossResponse = (await multi.ReadAsync<EstimateProfitLossResponse2>()).First();
                        var estimateProfitLossDetails = (await multi.ReadAsync<EstimateProfitLossDetailResponse>()).ToList();

                        var estimateProfitLossDetailDemurrages = (await multi.ReadAsync<EstimateProfitLossDetailDemurrageResponse>()).ToList();
                        var estimateProfitLossDetailDemurrageContainers = (await multi.ReadAsync<EstimateProfitLossDetailDemurrageContainerResponse>()).ToList();
                        var estimateProfitLossDetailDemurrageContainerDetails = (await multi.ReadAsync<EstimateProfitLossDetailDemurrageContainerDetailResponse>()).ToList();
                        var estimateProfitLossDetailHandlings = (await multi.ReadAsync<EstimateProfitLossDetailHandlingResponse>()).ToList();
                        var estimateProfitLossDetailProfitshare = (await multi.ReadAsync<EstimateProfitLossDetailProfitshareResponse>()).ToList();
                        var estimateProfitLossDetailStorage = (await multi.ReadAsync<EstimateProfitLossDetailStorageResponse>()).ToList();

                        EstimateProfitLossResponse2 estimateProfitLossResponse2 = new EstimateProfitLossResponse2();
                        estimateProfitLossResponse2 = estimateProfitLossResponse;
                        estimateProfitLossResponse2.EstimateProfitLossDetails = estimateProfitLossDetails;
                        if (estimateProfitLossResponse2.EstimateProfitLossDetails.Count > 0)
                        {
                            estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailDemurages = estimateProfitLossDetailDemurrages;
                            if (estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailDemurages.Count > 0)
                            {
                                estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailDemurages[0].EstimateProfitLossDetailDemurrageContainers = estimateProfitLossDetailDemurrageContainers;
                                if (estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailDemurages[0].EstimateProfitLossDetailDemurrageContainers.Count > 0)
                                {
                                    estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailDemurages[0].EstimateProfitLossDetailDemurrageContainers[0].EstimateProfitLossDetailDemurrageContainerDetails = estimateProfitLossDetailDemurrageContainerDetails;

                                }
                            }

                            estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailHandlings = estimateProfitLossDetailHandlings;
                            estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailProfitshares = estimateProfitLossDetailProfitshare;
                            estimateProfitLossResponse2.EstimateProfitLossDetails[0].EstimateProfitLossResponseDetailStorages = estimateProfitLossDetailStorage;
                        }

                        /*return estimateProfitLossResponse2;*/
                        results.status = 200;
                        results.succeeded = true;
                        results.message = "Get Data Success";
                        results.message = ResponseMessageDetailEPL(0, false, "Get", "Success");
                        results.data = estimateProfitLossResponse2;
                        return results;
                    }
                }
            }
            catch (Exception ex)
            {
                results.status = 500;
                results.succeeded = false;
                results.errors = ex.Message;
                results.message = ResponseMessageDetailEPL(0, false, "Get", "Failed");
                return results;
            }
        }
        public async Task<Response<EstimateProfitLossRequestDetailGrid>> Create(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid)
        {
            var results = new Response<EstimateProfitLossRequestDetailGrid>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@EPLId", estimateProfitLossDetailGrid.EPLId);
                parameters.Add("@Sequence", estimateProfitLossDetailGrid.Sequence);
                parameters.Add("@CustomerId", estimateProfitLossDetailGrid.CustomerId);
                parameters.Add("@CountryId", estimateProfitLossDetailGrid.CountryId);
                parameters.Add("@CompanyId", estimateProfitLossDetailGrid.CompanyId);
                parameters.Add("@BranchId", estimateProfitLossDetailGrid.BranchId);
                parameters.Add("@customerTypeId", estimateProfitLossDetailGrid.CustomerTypeId);
                parameters.Add("@accountId", estimateProfitLossDetailGrid.AccountId);
                parameters.Add("@Description", estimateProfitLossDetailGrid.Description);
                parameters.Add("@AmountUSD", estimateProfitLossDetailGrid.AmountUSD);
                parameters.Add("@AmountIDR", estimateProfitLossDetailGrid.AmountIDR);
                parameters.Add("@Quantity", estimateProfitLossDetailGrid.Quantity);
                parameters.Add("@PerQty", estimateProfitLossDetailGrid.PerQty);
                if (estimateProfitLossDetailGrid.CustomerTypeId != 5)
                {
                    parameters.Add("@IsSplitIncCost", estimateProfitLossDetailGrid.IsSplitIncCost);
                    parameters.Add("@IsCostToCost", estimateProfitLossDetailGrid.IsCostToCost);
                    parameters.Add("@IsAdditional", estimateProfitLossDetailGrid.IsAdditional);
                }

                if(estimateProfitLossDetailGrid.CustomerTypeId == 5)
                {
                    parameters.Add("@AmountCrr", estimateProfitLossDetailGrid.AmountCrr);
                }

                parameters.Add("@OriginalRate", estimateProfitLossDetailGrid.OriginalRate);
                parameters.Add("@OriginalUsd", estimateProfitLossDetailGrid.OriginalUsd);
                parameters.Add("@IsCostTrucking", estimateProfitLossDetailGrid.IsCostTrucking);
                parameters.Add("@IsIgnoreItem", estimateProfitLossDetailGrid.IsIgnoreItem);
                parameters.Add("@IsIncome", estimateProfitLossDetailGrid.IsIncome);
                parameters.Add("@CreatedBy", estimateProfitLossDetailGrid.User);

                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = (await connection.ExecuteAsync("operation.SP_EstimateProfitLossDetail_Create_Detail", parameters, commandType: CommandType.StoredProcedure));
                    results.status = 200;
                    results.succeeded = true;
                    results.message = ResponseMessageDetailEPL(estimateProfitLossDetailGrid.CustomerTypeId, estimateProfitLossDetailGrid.IsIncome, "Create", "Success");

                    return results;
                }
            }
            catch (Exception ex)
            {
                results.status = 500;
                results.succeeded = false;
                results.errors = ex.Message;
                results.message = ResponseMessageDetailEPL(estimateProfitLossDetailGrid.CustomerTypeId, estimateProfitLossDetailGrid.IsIncome, "Create", "Failed");
                return results;
            }
        }

        public async Task<Response<EstimateProfitLossRequestDetailGrid>> Update(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid)
        {
            var results = new Response<EstimateProfitLossRequestDetailGrid>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@EPLId", estimateProfitLossDetailGrid.EPLId);
                    parameters.Add("@Sequence", estimateProfitLossDetailGrid.Sequence);
                    parameters.Add("@CustomerId", estimateProfitLossDetailGrid.CustomerId);
                    parameters.Add("@CountryId", estimateProfitLossDetailGrid.CountryId);
                    parameters.Add("@CompanyId", estimateProfitLossDetailGrid.CompanyId);
                    parameters.Add("@BranchId", estimateProfitLossDetailGrid.BranchId);
                    parameters.Add("@customerTypeId", estimateProfitLossDetailGrid.CustomerTypeId);
                    parameters.Add("@accountId", estimateProfitLossDetailGrid.AccountId);
                    parameters.Add("@Description", estimateProfitLossDetailGrid.Description);
                    parameters.Add("@AmountUSD", estimateProfitLossDetailGrid.AmountUSD);
                    parameters.Add("@AmountIDR", estimateProfitLossDetailGrid.AmountIDR);
                    parameters.Add("@Quantity", estimateProfitLossDetailGrid.Quantity);
                    parameters.Add("@PerQty", estimateProfitLossDetailGrid.PerQty);

                    if (estimateProfitLossDetailGrid.CustomerTypeId != 5)
                    {
                        parameters.Add("@IsSplitIncCost", estimateProfitLossDetailGrid.IsSplitIncCost);
                        parameters.Add("@IsCostToCost", estimateProfitLossDetailGrid.IsCostToCost);
                        parameters.Add("@IsAdditional", estimateProfitLossDetailGrid.IsAdditional);
                    }

                    if (estimateProfitLossDetailGrid.CustomerTypeId == 5)
                    {
                        parameters.Add("@AmountCrr", estimateProfitLossDetailGrid.AmountCrr);
                    }

                    parameters.Add("@OriginalRate", estimateProfitLossDetailGrid.OriginalRate);
                    parameters.Add("@OriginalUsd", estimateProfitLossDetailGrid.OriginalUsd);
                    parameters.Add("@IsCostTrucking", estimateProfitLossDetailGrid.IsCostTrucking);
                    parameters.Add("@IsIgnoreItem", estimateProfitLossDetailGrid.IsIgnoreItem);
                    parameters.Add("@ModifiedBy", estimateProfitLossDetailGrid.User);

                    var affectedRows = await connection.ExecuteAsync("operation.SP_EstimateProfitLossDetail_Update_Detail", parameters, commandType: CommandType.StoredProcedure);
                    results.status = 200;
                    results.succeeded = true;
                    results.message = ResponseMessageDetailEPL(0, false, "Update", $"Success {affectedRows}");
                    return results;
                }
            }
            catch (Exception ex)
            {
                results.status = 500;
                results.succeeded = false;
                results.errors = ex.Message;
                results.message = ResponseMessageDetailEPL(0, false, "Update", "Failed");
                return results;
            }
        }

        public async Task<Response<EstimateProfitLossRequestDetailGrid>> Delete(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid)
        {
            var results = new Response<EstimateProfitLossRequestDetailGrid>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@EPLId", estimateProfitLossDetailGrid.EPLId);
                    parameters.Add("@Sequence", estimateProfitLossDetailGrid.Sequence);
                    parameters.Add("@ModifiedBy", estimateProfitLossDetailGrid.User);

                    var affectedRows = await connection.ExecuteAsync("operation.SP_EstimateProfitLossDetail_Delete_Detail", parameters, commandType: CommandType.StoredProcedure);
                    results.status = 200;
                    results.succeeded = true;
                    results.message = ResponseMessageDetailEPL(0, false, "Delete", $"Success {affectedRows}");
                    return results;
                }
            }
            catch (Exception ex)
            {
                results.status = 500;
                results.succeeded = false;
                results.errors = ex.Message;
                results.message = ResponseMessageDetailEPL(0, false, "Delete", "Failed");
                return results;
            }
        }

        #endregion

        #region Header Repository
        public async Task<PageSetResponse<EstimateProfitLossResponse>> ReadHeader(int PageNumber, int PageSize, int CountryId, int CompanyId, int BranchId)
        {
            var results = new PageSetResponse<EstimateProfitLossResponse>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PageNo", PageNumber);
                parameters.Add("@PageSize", PageSize);
                parameters.Add("@CountryId", CountryId);
                parameters.Add("@CompanyId", CompanyId);
                parameters.Add("@BranchId", BranchId);
                parameters.Add("@RecordCount", dbType: DbType.Int32, direction: ParameterDirection.Output);

                using (var connection = new SqlConnection(connectionString))
                {
                    using (var multi = (await connection.QueryMultipleAsync("operation.SP_EstimateProfitLoss_Read_Header", parameters, commandType: CommandType.StoredProcedure)))
                    {
                        results.Data = (await multi.ReadAsync<EstimateProfitLossResponse>()).ToList();
                        results.CountData = parameters.Get<int>("@RecordCount");
                        if(results.Data == null)
                        {
                            results.Code = 204;
                        }
                        return results;
                    }
                }
            }
            catch (Exception ex)
            {
                results.Code = 500;
                results.Message = ex.Message;
                return results;
            }
        }

        public async Task<Response<EstimateProfitLossResponse>> CreateHeader(EstimateProfitLossRequest estimateProfitLossRequest)
        {
            var results = new Response<EstimateProfitLossResponse>();
            var resID = new EstimateProfitLossResponse();
            
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ShipmentId", estimateProfitLossRequest.ShipmentId);
                parameters.Add("@CountryId", estimateProfitLossRequest.CountryId);
                parameters.Add("@CompanyId ", estimateProfitLossRequest.CompanyId);
                parameters.Add("@BranchId", estimateProfitLossRequest.BranchId);
                parameters.Add("@ExRateId", estimateProfitLossRequest.ExRateId);
                parameters.Add("@Rate", estimateProfitLossRequest.Rate);
                parameters.Add("@ExRateDate", estimateProfitLossRequest.ExRateDate);
                parameters.Add("@CreatedBy", estimateProfitLossRequest.User);
                parameters.Add("@RETURNVALUE", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = await connection.ExecuteAsync("operation.SP_EstimateProfitLoss_Create_Header", parameters, commandType: CommandType.StoredProcedure);
                    resID.Id = parameters.Get<int>("@RETURNVALUE");
                    results.status = 200;
                    results.succeeded = true;
                    results.message = ResponseMessageDetailEPL(0, false, "Create", "Success");
                    results.data = resID;

                    return results;
                }
            }
            catch (Exception ex)
            {
                results.status = 500;
                results.succeeded = false;
                results.errors = ex.Message;
                results.message = ResponseMessageDetailEPL(0, false, "Create", "Failed");
                return results;
            }
        }

        public async Task<Response<EstimateProfitLossResponse>> UpdateHeader(EstimateProfitLossRequest estimateProfitLossRequest)
        {
            var results = new Response<EstimateProfitLossResponse>();

            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", estimateProfitLossRequest.Id);
                parameters.Add("@ShipmentId", estimateProfitLossRequest.ShipmentId);
                parameters.Add("@CountryId", estimateProfitLossRequest.CountryId);
                parameters.Add("@CompanyId ", estimateProfitLossRequest.CompanyId);
                parameters.Add("@BranchId", estimateProfitLossRequest.BranchId);
                parameters.Add("@Rate", estimateProfitLossRequest.Rate);
                parameters.Add("@ExRateDate", estimateProfitLossRequest.ExRateDate);
                parameters.Add("@ModifiedBy", estimateProfitLossRequest.User);

                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = await connection.ExecuteAsync("operation.SP_EstimateProfitLoss_Update_Header", parameters, commandType: CommandType.StoredProcedure);
                    results.status = 200;
                    results.succeeded = true;
                    results.message = ResponseMessageDetailEPL(0, true, "Update", "Success");

                    return results;
                }
            }
            catch (Exception ex)
            {
                results.status = 500;
                results.succeeded = false;
                results.errors = ex.Message;
                results.message = ResponseMessageDetailEPL(0, true, "Update", "Failed");
                return results;
            }
        }

        public async Task<Response<EstimateProfitLossResponse>> DeleteHeader(int Id, int Status)
        {
            var results = new Response<EstimateProfitLossResponse>();
            string statusMessage = (Status == 1) ? "Delete":"UnDelete";
            
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                parameters.Add("@Deleted", Status);
                parameters.Add("@typeAction", "DELETE");
                parameters.Add("@ModifiedBy", "16");

                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = await connection.ExecuteAsync("operation.SP_EstimateProfitLoss_Update_Header", parameters, commandType: CommandType.StoredProcedure);
                    results.status = 200;
                    results.succeeded = true;
                    results.message = ResponseMessageDetailEPL(0, true, statusMessage, "Success");

                    return results;
                }
            }
            catch (Exception ex)
            {
                results.status = 500;
                results.succeeded = false;
                results.errors = ex.Message;
                results.message = ResponseMessageDetailEPL(0, true, statusMessage, "Failed");
                return results;
            }
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> getStorage(int IdEflDetail)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> CreateStorage(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, AddStorage addStorage)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> UpdateStorage(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, AddStorage addStorage)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> getHandlingFee(int IdEflDetail)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> CreateHandlingFee(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, HandlingFee handlingFee)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> UpdateHandlingFee(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, HandlingFee handlingFee)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> getProfitShare(int IdEflDetail)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> CreateProfitShare(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, ProfitShare profitShare)
        {
            throw new NotImplementedException();
        }

        public Task<Response<EstimateProfitLossRequestDetailGrid>> UpdateProfitShare(EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid, ProfitShare profitShare)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
