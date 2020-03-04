using AutoMapper;
using  ManageHospital.WebUI.Models;
using ManageHospitalData.Entities;

namespace  ManageHospital.WebUI
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {

            CreateMap<User, UserModel>()
            .ForMember(dest =>
                dest.FirstName,
                opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest =>
                dest.LastName,
                opt => opt.MapFrom(src => src.LastName));

            CreateMap<UserModel, User>();
             
            CreateMap<Assutance, AssutanceModel>().ReverseMap();

            CreateMap<Appointement, AppointementModel>().ReverseMap();

            CreateMap<AppointementStatus, AppointementStatusModel>().ReverseMap();

            CreateMap<Contact, ContactModel>().ReverseMap();

            CreateMap<Doctor, DoctorModel>().ReverseMap(); 

            CreateMap<DoctorCategory, DoctorCategoryModel>().ReverseMap(); 

            CreateMap<Documents, DocumentsModel>().ReverseMap(); 

            CreateMap<Hospital, HospitalModel>();
            CreateMap<HospitalModel, Hospital>().
                ForMember(d => d.Contact, act => act.MapFrom(src => src.ContactModel));
            //ForMember(d => d.HospitalCategory, act => act.MapFrom(src => src.HospitalCategoryModel));

            CreateMap<HospitalCategory, HospitalCategoryModel>().ReverseMap();

            CreateMap<Region, RegionModel>().ReverseMap();

            CreateMap<City, CityModel>().ReverseMap();
        }
    }

}
