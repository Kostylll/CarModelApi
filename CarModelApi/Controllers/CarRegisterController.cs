using Microsoft.AspNetCore.Mvc;

namespace CarModelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CarRegisterController : ControllerBase
    {


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        [HttpPost]

        public async Task<IActionResult> PostCar()
        {
            return Ok();
        }

        [HttpDelete]

        public void DeleteCar()
        {
            
        }

       






    }
}
