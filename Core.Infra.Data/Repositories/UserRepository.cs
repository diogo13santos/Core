using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Infra.Data.Context;

namespace Core.Infra.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CoreContext context) : base(context)
        {
        }
    }
}
