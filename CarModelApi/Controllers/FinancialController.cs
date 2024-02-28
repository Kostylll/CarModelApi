using Microsoft.AspNetCore.Mvc;

namespace CarModelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostFinancial()
        {
            return Ok();
        }
    }
}
