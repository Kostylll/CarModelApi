using CarModelRegister.Application.Domain.Aggregates;
using CarModelRegister.Application.Domain.Interface;
using CarModelRegister.Application.Domain.Request;
using CarModelRegister.Application.Infra.Data.DBContext;
using CarModelRegister.Application.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Services
{
    public class FinancialServices : IFinancialServices
    {
        private readonly CarModelDbContext _context;
        private readonly IFinancialRepository _financialRepository;

        public FinancialServices(IFinancialRepository financialRepository, CarModelDbContext context)
        {
            _financialRepository = financialRepository;
            _context = context;
        }

        public async Task<bool> Caculate(FinancialRequest request)
        {
            var user = new Financial()
            {
                Name = request.Name, 
                SecondName = request.SecondName,
                Document = request.Document,
                Email = request.Email,
                Age = request.Age.ToString(),
                

            };

            await _financialRepository.AddAsync(user);
            await _financialRepository.SaveChangesAsync();
            return true;


        }
    }
}
