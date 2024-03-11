using CarModelRegister.Application.Abstraction.Repository;
using CarModelRegister.Application.Domain.Aggregates;
using CarModelRegister.Application.Infra.Data.DBContext;

namespace CarModelRegister.Application.Infra.Data.Repository
{
    public class FinancialRepository : Repository<Financial>, IFinancialRepository
    {
        public FinancialRepository(CarModelDbContext context) : base (context) { }
            

    }
}
