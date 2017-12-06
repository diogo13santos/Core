using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Infra.Data.Context;

namespace Core.Infra.Data.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(CoreContext context) : base(context)
        {
        }
    }
}
