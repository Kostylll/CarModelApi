using CarModelRegister.Application.Domain.Aggregates;
using CarModelRegister.Application.Domain.Interface;
using CarModelRegister.Application.Domain.Request;
using CarModelRegister.Application.Domain.Response;
using CarModelRegister.Application.Infra.Data.DBContext;
using CarModelRegister.Application.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Services
{
    public class CarModelServices : ICarModelService
    {
        private readonly CarModelDbContext _context;
        private readonly ICarRepository _carRepository;

        public CarModelServices(ICarRepository carRepository,CarModelDbContext context)
        {
            _carRepository = carRepository;
            _context = context;
        }

        public async Task<bool> AddCar(CarRequest request)
        {
            var car = new Car()
            {
                Model = request.Model,
                Color = request.Color,
                Price = request.Price,
                Description = request.Description,
                Type = request.Type,



            };
            await _carRepository.AddAsync(car);
            await _carRepository.SaveChangesAsync();

            return true;
        }

        public async Task<List<CarResponse>> GetAll()
        {
            var carViewModeList = new List<CarResponse>();
            var cars = await _carRepository.GetAllAsync();

            foreach (var car in cars) {

                var carViewModel = new CarResponse();

                carViewModel.Model = car.Model;
                carViewModel.Color = car.Color; 
                carViewModel.Price = car.Price;
                carViewModel.Description = car.Description;
                carViewModel.Type = car.Type;
                
            
                carViewModeList.Add(carViewModel);
                
            
            }
            return carViewModeList;
        }

        public Task<CarResponse> GetCar(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveCar(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCar(CarRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
