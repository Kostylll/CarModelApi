using CarModelRegister.Application.Domain.Interface;
using CarModelRegister.Application.Domain.Request;
using CarModelRegister.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarModelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialController : ControllerBase
    {
        private readonly IFinancialServices _financialServices;


        public FinancialController(FinancialServices financialServices)
        {
            _financialServices = financialServices;
        }

        [HttpPost]
        public async Task<IActionResult> PostFinancial([FromBody] FinancialRequest request)
        {
            var result = await _financialServices.Caculate(request);
            return Ok(result);

        }
    }
}
