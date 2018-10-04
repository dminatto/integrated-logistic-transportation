using sac.application.AppServices;
using sac.application.Interfaces;
using sac.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public TicketViewModel Add(TicketViewModel ticket)
        {
            return _ticketAppService.Add(ticket);
        }

        // PUT api/ticket/atualizar
        public TicketViewModel Update(TicketViewModel ticket)
        {
            return _ticketAppService.Update(ticket);
        }

        // DELETE api/ticket/del/{codigo}
        public void Delete(int codigo)
        {
            _ticketAppService.Remove(codigo);
        }

        // GET api/ticket/{codigo}
        public TicketViewModel GetById(int codigo)
        {
            return _ticketAppService.GetById(codigo);
        }

        // GET api/ticket/all
        public List<TicketViewModel> GetAll()
        {
            return _ticketAppService.GetAll().ToList();
        }

    }
}
