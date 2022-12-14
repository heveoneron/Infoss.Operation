using Infoss.Operation.EstimateProfitLossService.Filter;
using Infoss.Operation.EstimateProfitLossService.Helpers;
using Infoss.Operation.EstimateProfitLossService.Repositories;
using Infoss.Operation.EstimateProfitLossService.Services;
using Infoss.Operation.EstimateProfitLossService.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Infoss.Operation.EstimateProfitLossService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceRepository InvoiceRepository;
        public IConfigurationRoot Configuration { get; }
        private readonly IUriService uriService;


        public InvoiceController(IUriService uriService)
        {
            IConfiguration Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();
            this.uriService = uriService;

            InvoiceRepository = new InvoiceRepository(Configuration);
        }

        #region Data Header
        // GET: <EstimateProfitLossController>
        [Route("ApiV1/Invoice/Header/{id}")]
        [HttpGet]
        //public async Task<ActionResult> GetHeader([FromBody] PaginationFilter filter, string Id)
        public async Task<ActionResult> GetHeaderByID([FromRoute] string id)
        {
            //var route = Request.Path.Value;
            //var validFilter = new PaginationFilter(1, 10);
            //var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            //var resRepo = await InvoiceRepository.ReadHeaderByID(validFilter.PageNumber, validFilter.PageSize, filter.CountryId, filter.CompanyId, filter.BranchId, Id);
            var resRepo = await InvoiceRepository.ReadHeaderByID(id);
            if (resRepo.status == 500)
            {
                //var response = new Response<ResponseInvoice>();
                //response.status = resRepo.Code;
                //response.message = resRepo.Message;
                //response.succeeded = false;

                return StatusCode(StatusCodes.Status500InternalServerError, resRepo);
            }
            return Ok(resRepo);
            //var pagedReponse = PaginationHelper.CreatePagedReponse<ResponseInvoice>(resRepo.Data, validFilter, resRepo.CountData, uriService, route);
            //return Ok(pagedReponse);
        }

        //[Route("ApiV1/Header/Create")]
        //[HttpPost]
        //public async Task<ActionResult> CreateHeader([FromBody] EstimateProfitLossRequest estimateProfitLossRequest)
        //{
        //    var result = await estimateProfitLossRepository.CreateHeader(estimateProfitLossRequest);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}

        //[Route("ApiV1/Header")]
        //[HttpPut]
        //public async Task<ActionResult> UpdateHeader([FromBody] EstimateProfitLossRequest estimateProfitLossRequest)
        //{
        //    var result = await estimateProfitLossRepository.UpdateHeader(estimateProfitLossRequest);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}

        //// PUT <EstimateProfitLossController>/  
        //[Route("ApiV1/Header/Delete")]
        //[HttpPut]
        //public async Task<ActionResult> DeleteHeader([FromBody] EstimateProfitLossRequest estimateProfitLossRequest)
        //{
        //    var result = await estimateProfitLossRepository.DeleteHeader(estimateProfitLossRequest.Id, 1);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}

        //// PUT <EstimateProfitLossController>/HeaderData/Delete
        //[Route("ApiV1/Header/UnDelete")]
        //[HttpPut]
        //public async Task<ActionResult> UnDeleteHeader([FromBody] EstimateProfitLossRequest estimateProfitLossRequest)
        //{

        //    var result = await estimateProfitLossRepository.DeleteHeader(estimateProfitLossRequest.Id, 0);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}
        #endregion

        #region Detail

        //[Route("ApiV1/Detail/{id}")]
        //[HttpGet]
        //public async Task<ActionResult> Get(int id)
        //{
        //    var result = await estimateProfitLossRepository.Read(id);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}

        //[Route("ApiV1/Detail")]
        //[HttpPost]
        //public async Task<ActionResult> Post([FromBody] EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid)
        //{
        //    var result = await estimateProfitLossRepository.Create(estimateProfitLossDetailGrid);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}

        //// PUT <EstimateProfitLossController>/5
        //[Route("ApiV1/Detail")]
        //[HttpPut]
        //public async Task<ActionResult> Put([FromBody] EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid)
        //{
        //    var result = await estimateProfitLossRepository.Update(estimateProfitLossDetailGrid);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}

        //// DELETE <EstimateProfitLossController>/5
        //[Route("ApiV1/Detail")]
        //[HttpDelete]
        //public async Task<ActionResult> Delete([FromBody] EstimateProfitLossRequestDetailGrid estimateProfitLossDetailGrid)
        //{

        //    var result = await estimateProfitLossRepository.Delete(estimateProfitLossDetailGrid);
        //    if (result.status == 500)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, result);

        //    }
        //    return Ok(result);
        //}
        #endregion
    }
}
