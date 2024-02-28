using CarModelRegister.Application.Abstraction.Repository;
using CarModelRegister.Application.Domain.Aggregates;
using CarModelRegister.Application.Infra.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Infra.Data.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarModelDbContext context) : base(context)
        {
        }
    }

}
