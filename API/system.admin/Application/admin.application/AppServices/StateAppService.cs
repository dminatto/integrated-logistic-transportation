using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using admin.domain.Interfaces;
using AutoMapper;

namespace admin.application.AppServices
{
    public class StateAppService : ApplicationService, IAppService<StateViewModel, State>
    {
        private readonly IService<State> _stateService;

        public StateAppService(IUnitOfWork uow, IService<State> StateService) : base(uow)
        {
            _stateService = StateService;
        }

        public StateViewModel Add(StateViewModel obj)
        {
            var state = Mapper.Map<StateViewModel, State>(obj);

            BeginTransaction();

            /*var stateReturn = _stateService.Put<State>(state);
            var stateReturnViewModel = Mapper.Map<State, StateViewModel>(stateReturn);
            */
            Commit();
            var stateReturnViewModel = new StateViewModel();
            return stateReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<StateViewModel> GetAll()
        {
            var state = _stateService.Get();
            return Mapper.Map<IEnumerable<State>, IEnumerable<StateViewModel>>(state);
        }

        public StateViewModel GetById(int id)
        {
            return Mapper.Map<State, StateViewModel>(_stateService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _stateService.Delete(id);
            Commit();
        }

        public IEnumerable<StateViewModel> Search(Expression<Func<State, bool>> predicate)
        {
            var state = _stateService.Get();
            return Mapper.Map<IEnumerable<State>, IEnumerable<StateViewModel>>(state);
        }

        public StateViewModel Update(StateViewModel obj)
        {
            var state = Mapper.Map<StateViewModel, State>(obj);

            BeginTransaction();

            /*  var stateReturn = _stateService.Post<State>(state);
              var stateReturnViewModel = Mapper.Map<State, StateViewModel>(stateReturn); */
            var stateReturnViewModel = new StateViewModel();
            Commit();

            return stateReturnViewModel;
        }

    }
}
