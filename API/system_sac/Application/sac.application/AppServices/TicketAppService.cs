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
using sac.service.Service;

namespace sac.application.AppServices
{
    public class TicketAppService : ApplicationService, ITicketAppService
    {
        private readonly TicketService _tiketService;

        public TicketAppService(IUnitOfWork uow, TicketService TicketService) : base(uow)
        {
            _tiketService = TicketService;
        }

        public TicketViewModel Add(TicketViewModel obj)
        {
            var ticket = Mapper.Map<TicketViewModel, Ticket>(obj);

            BeginTransaction();

           /* var ticketReturn = _tiketService.Put<Ticket>(ticket);
            var ticketReturnViewModel = Mapper.Map<Ticket, TicketViewModel>(ticketReturn);*/

            Commit();
            var ticketReturnViewModel = new TicketViewModel();
            return ticketReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TicketViewModel> GetAll()
        {
            var tickets = _tiketService.Get();
            return Mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketViewModel>>(tickets);
        }

        public TicketViewModel GetById(int id)
        {
            return Mapper.Map<Ticket, TicketViewModel>(_tiketService.Get(id));
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _tiketService.Delete(id);
            Commit();
        }

        public IEnumerable<TicketViewModel> Search(Expression<Func<Ticket, bool>> predicate)
        {
            var tickets = _tiketService.Get();
            return Mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketViewModel>>(tickets);
            // return Mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketViewModel>>(_tiketService.Get(predicate));

        }

        public TicketViewModel Update(TicketViewModel obj)
        {
            var ticket = Mapper.Map<TicketViewModel, Ticket>(obj);

            BeginTransaction();

            /*  var ticketReturn = _tiketService.Post<Ticket>(ticket);
              var ticketReturnViewModel = Mapper.Map<Ticket, TicketViewModel>(ticketReturn); */
            var ticketReturnViewModel = new TicketViewModel();
            Commit();

            return ticketReturnViewModel;
        }
    }
}
