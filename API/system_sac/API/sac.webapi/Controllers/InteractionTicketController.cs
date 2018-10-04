using sac.application.Interfaces;
using sac.application.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace sac.webapi.Controllers
{
    public class InteractionTicketController : ApiController
    {
        private readonly IInteractionTicketAppService _interactionService;

        public InteractionTicketController(IInteractionTicketAppService interactionAppService)
        {
            _interactionService = interactionAppService;
        }

        // POST api/interaction/add
        public InteractionTicketViewModel Add(InteractionTicketViewModel interaction)
        {
            return _interactionService.Add(interaction);
        }

        // PUT api/interaction/atualizar
        public InteractionTicketViewModel Update(InteractionTicketViewModel interaction)
        {
            return _interactionService.Update(interaction);
        }

        // DELETE api/interaction/del/{codigo}
        public void Delete(int codigo)
        {
            _interactionService.Remove(codigo);
        }

        // GET api/interaction/{codigo}
        public InteractionTicketViewModel GetById(int codigo)
        {
            return _interactionService.GetById(codigo);
        }

        // GET api/interaction/all
        public List<InteractionTicketViewModel> GetAll()
        {
            return _interactionService.GetAll().ToList();
        }
    }
}
}
