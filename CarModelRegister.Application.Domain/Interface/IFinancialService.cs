using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Domain.Interface
{
    public interface IFinancialService
    {
        Task<bool> Caculate(string Financial);
    }
}
