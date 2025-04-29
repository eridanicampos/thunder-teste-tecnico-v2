using Thunders.TechTest.Domain.Entities;
using Thunders.TechTest.Domain.Interfaces.Repositories;
using Thunders.TechTest.Infrastructure.Data;
using Thunders.TechTest.Infrastructure.Repositories.Commons;

namespace Thunders.TechTest.Infrastructure.Repositories
{
    public class PracaRepository : GenericAsyncRepository<Praca>, IPracaRepository
    {
        public PracaRepository(PedagioDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
