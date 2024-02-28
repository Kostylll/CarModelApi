using CarModelRegister.Application.Abstraction.Interface;
using CarModelRegister.Application.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Infra.Data.Repository
{
    public interface ICarRepository : IRepository<Car>
    {
       
    }
}
