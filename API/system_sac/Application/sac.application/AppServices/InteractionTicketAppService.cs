using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using sac.application.Interfaces;
using sac.application.ViewModels;
using sac.domain.Entities;
using sac.domain.Interfaces;

namespace sac.application.AppServices
{
    public class InteractionTicketAppService : ApplicationService, IInteractionTicketAppService
    {
        private readonly IService<InteractionTicket> _tiketService;

        public InteractionTicketAppService(IUnitOfWork uow, IService<InteractionTicket> TiketService) : base(uow)
        {
            _tiketService = TiketService;
        }

        public InteractionTicketViewModel Add(InteractionTicketViewModel obj)
        {
            var interaction = Mapper.Map<InteractionTicketViewModel, InteractionTicket>(obj);

            BeginTransaction();

            /* var interactionReturn = _tiketService.Put<Ticket>(ticket);
             var interactionReturnViewModel = Mapper.Map<Ticket, TicketViewModel>(interactionReturn);*/

            Commit();
            var interactionReturnViewModel = new InteractionTicketViewModel();
            return interactionReturnViewModel;

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<InteractionTicketViewModel> GetAll()
        {
            var interaction = _tiketService.Get();
            return Mapper.Map<IEnumerable<InteractionTicket>, IEnumerable<InteractionTicketViewModel>>(interaction);
        }

        public InteractionTicketViewModel GetById(int id)
        {
            return Mapper.Map<InteractionTicket, InteractionTicketViewModel>(_tiketService.Get(id));
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _tiketService.Delete(id);
            Commit();
        }

        public IEnumerable<InteractionTicketViewModel> Search(Expression<Func<InteractionTicket, bool>> predicate)
        {
            var interaction = _tiketService.Get();
            return Mapper.Map<IEnumerable<InteractionTicket>, IEnumerable<InteractionTicketViewModel>>(interaction);
            // return Mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketViewModel>>(_tiketService.Get(predicate));

        }

        public InteractionTicketViewModel Update(InteractionTicketViewModel obj)
        {
            var interaction = Mapper.Map<InteractionTicketViewModel, InteractionTicket>(obj);

            BeginTransaction();

            /*  var interactionReturn = _tiketService.Post<InteractionTicket>(interaction);
              var interactionReturnViewModel = Mapper.Map<InteractionTicket, InteractionTicketViewModel>(interactionReturn); */
            var interactionReturnViewModel = new InteractionTicketViewModel();
            Commit();

            return interactionReturnViewModel;
        }
    }
}
