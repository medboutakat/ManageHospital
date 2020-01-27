using AutoMapper;
using ManageHospitalApi.Models;
using ManageHospitalData.Entities;

namespace ManageHospitalApi
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

            CreateMap<Assutance, AssutanceModel>();
            CreateMap<AppointementModel, Appointement>();

            CreateMap<Assutance, AssutanceModel>();
            CreateMap<AssutanceModel, Assutance>();

            CreateMap<Appointement, AppointementModel>();
            CreateMap<AppointementModel, Appointement>();

            CreateMap<AppointementStatus, AppointementStatusModel>();
            CreateMap<AppointementStatusModel, AppointementStatus>();

            CreateMap<Contact, ContactModel>();
            CreateMap<ContactModel, Contact>();


            CreateMap<Doctor, DoctorModel>();
            CreateMap<DoctorModel, Doctor>();


            CreateMap<DoctorCategory, DoctorCategoryModel>();
            CreateMap<DoctorCategoryModel, DoctorCategory>();



            CreateMap<Documents, DocumentsModel>();
            CreateMap<DocumentsModel, Documents>();

            CreateMap<Hospital, HospitalModel>();
            CreateMap<HospitalModel, Hospital>().
                ForMember(d => d.Contact, act => act.MapFrom(src => src.ContactModel));
              //ForMember(d => d.HospitalCategory, act => act.MapFrom(src => src.HospitalCategoryModel));

            CreateMap<HospitalCategory, HospitalCategoryModel>();
            CreateMap<HospitalCategoryModel, HospitalCategory>();





        }
    }

}
