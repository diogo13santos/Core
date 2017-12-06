using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Infra.Data.Context;

namespace Core.Infra.Data.Repositories
{
    public class PrivilegeRepository : GenericRepository<Privilege>, IPrivilegeRepository
    {
        public PrivilegeRepository(CoreContext context) : base(context)
        {
        }
    }
}
