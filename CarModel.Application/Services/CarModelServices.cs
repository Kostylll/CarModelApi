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

        public Task<bool> AddCar(CarRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarResponse>> GetAll()
        {
            throw new NotImplementedException();
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
