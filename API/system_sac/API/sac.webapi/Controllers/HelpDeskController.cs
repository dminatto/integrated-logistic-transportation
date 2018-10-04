using sac.application.Interfaces;
using sac.application.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace sac.webapi.Controllers
{
    public class HelpDeskController : ApiController
    {
        private readonly IHelpDeskAppService _helpAppService;

        public HelpDeskController(IHelpDeskAppService helpAppService)
        {
            _helpAppService = helpAppService;
        }

        // POST api/help/add
        public HelpDeskViewModel Add(HelpDeskViewModel help)
        {
            return _helpAppService.Add(help);
        }

        // PUT api/help/atualizar
        public HelpDeskViewModel Update(HelpDeskViewModel help)
        {
            return _helpAppService.Update(help);
        }

        // DELETE api/help/del/{codigo}
        public void Delete(int codigo)
        {
            _helpAppService.Remove(codigo);
        }

        // GET api/help/{codigo}
        public HelpDeskViewModel GetById(int codigo)
        {
            return _helpAppService.GetById(codigo);
        }

        // GET api/help/all
        public List<HelpDeskViewModel> GetAll()
        {
            return _helpAppService.GetAll().ToList();
        }
    }
}
