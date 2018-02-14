using Core.Domain.Entities;
using Core.MVC.ViewModels;

namespace Core.MVC.Utility.Profile
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
