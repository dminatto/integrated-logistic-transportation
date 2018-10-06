using sac.application.AppServices;
using sac.application.Interfaces;
using sac.domain.Entities;
using sac.domain.Interfaces;
using sac.infra.data.DAO.Context;
using sac.infra.data.Repositories;
using sac.infra.data.UoW;
using sac.service.Service;
using SimpleInjector;

namespace sac.infra.crosscutting
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // App
            container.Register<ITicketAppService, TicketAppService>();
           // container.Register<IInteractionTicketAppService, InteractionTicketAppService>();
            //container.Register<IHelpDeskAppService, IHelpDeskAppService>();
            
            // Domain
            container.Register<IService<Ticket>, TicketService>();
            //container.Register<IService<InteractionTicket>, InteractionTicketService>();
            //container.Register<IService<HelpDesk>, HelpDeskService>();

            // Infra Dados
            container.Register<IRepository<Ticket>, TicketRepository>();
            //container.Register<IRepository<InteractionTicket>, InteractionTicketRepository>();
            //container.Register<IRepository<HelpDesk>, HelpDeskRepository>();
            
            container.Register<IUnitOfWork, UnitOfWork>();
            container.Register<DataContext>();

        }
    }
}
