using CarModelRegister.Application.Domain.Request;
using CarModelRegister.Application.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Domain.Interface
{
    public interface ICarModelService
    {
        Task<bool> AddCar(CarRequest request);
        Task<int> RemoveCar(string id);
        Task<bool> UpdateCar(CarRequest request);
        Task<CarResponse> GetCar(string id);
        Task<List<CarResponse>> GetAll();


    }
}
