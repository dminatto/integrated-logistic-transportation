using AutoMapper;
using sac.application.Interfaces;
using sac.application.ViewModels;
using sac.domain.Entities;
using sac.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace sac.application.AppServices
{
    class HelpDeskAppService : ApplicationService, IHelpDeskAppService
    {
        private readonly IService<HelpDesk> _helpDeskService;

        public HelpDeskAppService(IUnitOfWork uow, IService<HelpDesk> HelpDeskService) : base(uow)
        {
            _helpDeskService = HelpDeskService;
        }

        public HelpDeskViewModel Add(HelpDeskViewModel obj)
        {
            var help = Mapper.Map<HelpDeskViewModel, Ticket>(obj);

            BeginTransaction();

            /* var helpReturn = _helpDeskService.Put<Ticket>(help);
             var helpReturnViewModel = Mapper.Map<Ticket, TicketViewModel>(helpReturn);*/

            Commit();
            var helpReturnViewModel = new HelpDeskViewModel();
            return helpReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<HelpDeskViewModel> GetAll()
        {
            var helps = _helpDeskService.Get();
            return Mapper.Map<IEnumerable<HelpDesk>, IEnumerable<HelpDeskViewModel>>(helps);
        }

        public HelpDeskViewModel GetById(int id)
        {
            return Mapper.Map<HelpDesk, HelpDeskViewModel>(_helpDeskService.Get(id));
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _helpDeskService.Delete(id);
            Commit();
        }

        public IEnumerable<HelpDeskViewModel> Search(Expression<Func<HelpDesk, bool>> predicate)
        {
            var helps = _helpDeskService.Get();
            return Mapper.Map<IEnumerable<HelpDesk>, IEnumerable<HelpDeskViewModel>>(helps);
        }

        public HelpDeskViewModel Update(HelpDeskViewModel obj)
        {
            var helps = Mapper.Map<HelpDeskViewModel, HelpDesk>(obj);

            BeginTransaction();

            /*  var helpReturn = _helpDeskService.Post<Ticket>(helps);
              var helpReturnViewModel = Mapper.Map<Ticket, TicketViewModel>(helpReturn); */
            var helpReturnViewModel = new HelpDeskViewModel();
            Commit();

            return helpReturnViewModel;
        }
    }
}
