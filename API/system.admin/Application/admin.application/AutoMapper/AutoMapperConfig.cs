using admin.application.ViewModels;
using admin.domain.Entities;
using AutoMapper;

namespace admin.application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Address, AddressViewModel>().ReverseMap();
                cfg.CreateMap<City, CityViewModel>().ReverseMap();
                cfg.CreateMap<Company, CompanyViewModel>().ReverseMap();
                cfg.CreateMap<CompanyPartner, CompanyPartnerViewModel>().ReverseMap();
                cfg.CreateMap<Country, CountryViewModel>().ReverseMap();
                cfg.CreateMap<Customer, CustomerViewModel>().ReverseMap();
                cfg.CreateMap<State, StateViewModel>().ReverseMap();
                cfg.CreateMap<User, UserViewModel>().ReverseMap();
                cfg.CreateMap<UserPermissions, UserPermissionsViewModel>().ReverseMap();
                cfg.CreateMap<UserProfile, UserProfileViewModel>().ReverseMap();

            });
        }
    }
}
