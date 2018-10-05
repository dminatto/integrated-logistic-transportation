using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace admin.api.Controllers
{
    public class CompanyPartnerController : ApiController
    {
        private readonly IAppService<CompanyPartnerViewModel, CompanyPartner> _companyAppService;

        public CompanyPartnerController(IAppService<CompanyPartnerViewModel, CompanyPartner> companyAppService)
        {
            _companyAppService = companyAppService;
        }

        // POST api/company/add
        public CompanyPartnerViewModel Add(CompanyPartnerViewModel company)
        {
            return _companyAppService.Add(company);
        }

        // PUT api/company/atualizar
        public CompanyPartnerViewModel Update(CompanyPartnerViewModel company)
        {
            return _companyAppService.Update(company);
        }

        // DELETE api/company/del/{codigo}
        public void Delete(int codigo)
        {
            _companyAppService.Remove(codigo);
        }

        // GET api/company/{codigo}
        public CompanyPartnerViewModel GetById(int codigo)
        {
            return _companyAppService.GetById(codigo);
        }

        // GET api/company/all
        public List<CompanyPartnerViewModel> GetAll()
        {
            return _companyAppService.GetAll().ToList();
        }
    }
}
