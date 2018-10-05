using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;

namespace admin.api.Controllers
{
    public class StateController : ApiController
    {
        private readonly IAppService<StateViewModel, State> _stateAppService;

        public StateController(IAppService<StateViewModel, State> stateAppService)
        {
            _stateAppService = stateAppService;
        }

        // POST api/state/add
        public StateViewModel Add(StateViewModel state)
        {
            return _stateAppService.Add(state);
        }

        // PUT api/state/atualizar
        public StateViewModel Update(StateViewModel state)
        {
            return _stateAppService.Update(state);
        }

        // DELETE api/state/del/{codigo}
        public void Delete(int codigo)
        {
            _stateAppService.Remove(codigo);
        }

        // GET api/state/{codigo}
        public StateViewModel GetById(int codigo)
        {
            return _stateAppService.GetById(codigo);
        }

        // GET api/state/all
        public List<StateViewModel> GetAll()
        {
            return _stateAppService.GetAll().ToList();
        }
    }
}
