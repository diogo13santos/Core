using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Infra.Data.Context;

namespace Core.Infra.Data.Repositories
{
    public class ResourceRepository : GenericRepository<Resource>, IResourceRepository
    {
        public ResourceRepository(CoreContext context) : base(context)
        {
        }
    }
}
