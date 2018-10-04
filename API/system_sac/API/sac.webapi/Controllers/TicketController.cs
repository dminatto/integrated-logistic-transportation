using sac.application.AppServices;
using sac.application.Interfaces;
using sac.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sac.webapi.Controllers
{
    public class TicketController : ApiController
    {
        private readonly ITicketAppService _ticketAppService;

        public TicketController(ITicketAppService ticketAppService)
        {
            _ticketAppService = ticketAppService;
        }

        // POST api/ticket/add
        public TicketViewModel Adicionar(TicketViewModel ticket)
        {
            return _ticketAppService.Add(ticket);
        }

        // PUT api/ticket/atualizar
        public TicketViewModel Atualizar(TicketViewModel ticket)
        {
            return _ticketAppService.Update(ticket);
        }

        // DELETE api/ticket/del/{codigo}
        public void ExcluirUsuario(int codigo)
        {
            _ticketAppService.Remove(codigo);
        }

        // GET api/ticket/{codigo}
        public TicketViewModel ConsultarUsuarioPorCodigo(int codigo)
        {
            return _ticketAppService.GetById(codigo);
        }

        // GET api/ticket/all
        public List<TicketViewModel> ObterTodos()
        {
            return _ticketAppService.GetAll().ToList();
        }

    }
}
