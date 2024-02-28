using CarModelRegister.Application.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Services
{
    public class FinancialServices : IFinancialService
    {
        public Task<bool> Caculate(string Financial)
        {
            throw new NotImplementedException();
        }
    }
}
