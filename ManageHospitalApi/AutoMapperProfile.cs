using AutoMapper;
using ManageHospitalModels.Models;
using ManageHospitalData.Entities;

namespace ManageHospitalApi
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Contact, ContactModel>().ReverseMap();

            CreateMap<User, UserModel>()
            .ForMember(dest =>
                dest.FirstName,
                opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest =>
                dest.LastName,
                opt => opt.MapFrom(src => src.LastName));


            CreateMap<RegisterModel, User>().ReverseMap(); 
            CreateMap<RegisterModel, Patient>().ReverseMap();
            CreateMap<RegisterModel, Doctor>().ReverseMap();
            CreateMap<RegisterModel, Assutance>().ReverseMap();


            CreateMap<UserModel, User>()
            .ForMember(d => d.contact, act => act.MapFrom(src => src.ContactModel));

            CreateMap<Assutance, AssutanceModel>().ReverseMap();

            CreateMap<Appointement, AppointementModel>().ReverseMap();

            CreateMap<AppointementStatus, AppointementStatusModel>().ReverseMap();

            CreateMap<Doctor, DoctorModel>().ReverseMap()
                .ForMember(d => d.contact, act => act.MapFrom(src => src.ContactModel));

            CreateMap<DoctorCategory, DoctorCategoryModel>().ReverseMap();

            CreateMap<Documents, DocumentsModel>().ReverseMap();


            CreateMap<Hospital, HospitalModel>();

            CreateMap<HospitalModel, Hospital>().
                ForMember(d => d.Contact, act => act.MapFrom(src => src.ContactModel));

            //ForMember(d => d.HospitalCategory, act => act.MapFrom(src => src.HospitalCategoryModel));

            CreateMap<HospitalCategory, HospitalCategoryModel>().ReverseMap();

            CreateMap<Region, RegionModel>().ReverseMap();

            CreateMap<City, CityModel>().ReverseMap();

            CreateMap<Operation, OperationModel>().ReverseMap();

            CreateMap<OperationCategory, OperationCategoryModel>().ReverseMap();

            CreateMap<Product, ProductModel>().ReverseMap();

            CreateMap<ProductCategory, ProductCategoryModel>().ReverseMap();

            CreateMap<Request, RequestModel>().ReverseMap().ReverseMap(); 


            CreateMap<RequestStatus, RequestStatusModel>().ReverseMap();

            CreateMap<Response, ResponseModel>().ReverseMap();

            CreateMap<Tax, TaxModel>().ReverseMap();

            CreateMap<Customer, CustomerModel>().ReverseMap();

            CreateMap<CustomerCategory, CustomerCategoryModel>().ReverseMap();

            CreateMap<Invoice, InvoiceModel>().ReverseMap(). 
                ForMember(d => d.InvoiceDetails, act => act.MapFrom(src => src.InvoiceDetails)); 
            
            CreateMap<InvoiceDetail, InvoiceDetailModel>().ReverseMap();


            CreateMap<Material, MaterialModel>().ReverseMap();

            CreateMap<MaterialCategory, MaterialCategoryModel>().ReverseMap();

        }
    }

}
