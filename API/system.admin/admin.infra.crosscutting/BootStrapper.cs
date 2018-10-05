using admin.domain.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using admin.application.AppServices;
using admin.domain.Entities;
using admin.infra.data.UoW;
using admin.infra.data.DAO.Context;
using admin.infra.data.Repository;
using admin.service.Service;
using admin.application.Interfaces;
using admin.application.ViewModels;

namespace admin.infra.crosscutting
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // App
            container.Register<IAppService<AddressViewModel, Address>, AddressAppService>();
            container.Register<IAppService<CityViewModel, City>, CityAppService>();
            container.Register<IAppService<CompanyViewModel, Company>, CompanyAppService>();
            container.Register<IAppService<CompanyPartnerViewModel, CompanyPartner>, CompanyPartnerAppService>();
            container.Register<IAppService<CountryViewModel, Country>, CountryAppService>();
            container.Register<IAppService<CustomerViewModel, Customer>, CustomerAppService>();
            container.Register<IAppService<StateViewModel, State>, StateAppService>();
            container.Register<IAppService<UserViewModel, User>, UserAppService> ();
            container.Register<IAppService<UserPermissionsViewModel, UserPermissions>, UserPermissionsAppService> ();
            container.Register<IAppService<UserProfileViewModel, UserProfile>, UserProfileAppService> ();

            // Domain
            container.Register<IService<Address>, BaseService<Address>>();
            container.Register<IService<City>, BaseService<City>>();
            container.Register<IService<Company>, BaseService<Company>>();
            container.Register<IService<CompanyPartner>, BaseService<CompanyPartner>>();
            container.Register<IService<Country>, BaseService<Country>>();
            container.Register<IService<Customer>, BaseService<Customer>>();
            container.Register<IService<State>, BaseService<State>>();
            container.Register<IService<User>, BaseService<User>>();
            container.Register<IService<UserPermissions>, BaseService<UserPermissions>>();
            container.Register<IService<UserProfile>, BaseService<UserProfile>>();


            // Infra Dados
            container.Register<IRepository<Address>, BaseRepository<Address>>();
            container.Register<IRepository<City>, BaseRepository<City>>();
            container.Register<IRepository<Company>, BaseRepository<Company>>();
            container.Register<IRepository<CompanyPartner>, BaseRepository<CompanyPartner>>();
            container.Register<IRepository<Country>, BaseRepository<Country>>();
            container.Register<IRepository<Customer>, BaseRepository<Customer>>();
            container.Register<IRepository<State>, BaseRepository<State>>();
            container.Register<IRepository<User>, BaseRepository<User>>();
            container.Register<IRepository<UserPermissions>, BaseRepository<UserPermissions>>();
            container.Register<IRepository<UserProfile>, BaseRepository<UserProfile>>();

            container.Register<IUnitOfWork, UnitOfWork>();
            container.Register<DataContext>();

        }
    }
}
