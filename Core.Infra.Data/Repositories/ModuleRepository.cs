using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Infra.Data.Context;

namespace Core.Infra.Data.Repositories
{
    public class ModuleRepository : GenericRepository<Module>, IModuleRepository
    {
        public ModuleRepository(CoreContext context) : base(context)
        {
        }
    }
}
