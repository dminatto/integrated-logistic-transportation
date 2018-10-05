using admin.domain.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using admin.domain.Entities;
using admin.infra.data.UoW;
using admin.infra.data.DAO.Context;
using admin.infra.data.Repository;
using admin.service.Service;

namespace admin.infra.crosscutting
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // App
     //       container.Register<IAppService, TicketAppService>();
            //container.Register<AppService, InteractionTicketAppService>();
            //container.Register<IHelpDeskAppService, IHelpDeskAppService>();
            //container.Register<IHelpDeskAppService, IHelpDeskAppService>();
            //container.Register<IHelpDeskAppService, IHelpDeskAppService>();
            //container.Register<IHelpDeskAppService, IHelpDeskAppService>();
            //container.Register<IHelpDeskAppService, IHelpDeskAppService>();
            //container.Register<IHelpDeskAppService, IHelpDeskAppService>();

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
