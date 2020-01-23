using AutoMapper;
using ManageHospitalData.Entities;
using WebApi.Models;

namespace ManageHospital.WebUI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>(); 
        }
    }
}
