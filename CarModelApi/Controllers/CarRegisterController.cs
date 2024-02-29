using CarModelRegister.Application.Domain.Interface;
using CarModelRegister.Application.Domain.Request;
using Microsoft.AspNetCore.Mvc;

namespace CarModelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CarRegisterController : ControllerBase
    {
        private readonly ICarModelService _carModelService;

        public CarRegisterController(ICarModelService carModelService)
        {
            _carModelService = carModelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _carModelService.GetAll();
            return Ok(result);
        }


        [HttpPost]

        public async Task<IActionResult> PostCar([FromBody] CarRequest request)
        {
           var result = await _carModelService.AddCar(request);
           return Ok(result);
        }


        [HttpDelete]

        public void DeleteCar()
        {
            
        }

       






    }
}
