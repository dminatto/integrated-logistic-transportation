using sac.application.AppServices;
using sac.application.Interfaces;
using sac.application.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace sac.WebApi.Controllers
{
    public class TicketController : BaseController
    {
        private readonly ITicketAppService _ticketAppService;

        /*public TicketController(ITicketAppService ticketAppService)
        {
            _ticketAppService = ticketAppService;
        }*/

        public TicketController()
        {
            _ticketAppService = new TicketAppService();
        }

        [AcceptVerbs("POST")]
        [Route("ticket")]
        public TicketViewModel Adicionar(TicketViewModel ticket)
        {
            return _ticketAppService.Add(ticket);
        }

        [AcceptVerbs("PUT")]
        [Route("ticket")]
        public TicketViewModel Atualizar(TicketViewModel ticket)
        {
            return _ticketAppService.Update(ticket);
        }

        [AcceptVerbs("DELETE")]
        [Route("ticket/{codigo}")]
        public void ExcluirUsuario(int codigo)
        {
            _ticketAppService.Remove(codigo);
        }

        [AcceptVerbs("GET")]
        [Route("ticket/{codigo}")]
        public TicketViewModel ConsultarUsuarioPorCodigo(int codigo)
        {
            return _ticketAppService.GetById(codigo);
        }

        [AcceptVerbs("GET")]
        [Route("ticket")]
        public List<TicketViewModel> ObterTodos()
        {
            return _ticketAppService.GetAll().ToList();
        }
    }
}