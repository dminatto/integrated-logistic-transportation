using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace admin.api.Controllers
{
    public class CompanyController : ApiController
    {
        private readonly IAppService<CompanyViewModel, Company> _companyAppService;

        public CompanyController(IAppService<CompanyViewModel, Company> companyAppService)
        {
            _companyAppService = companyAppService;
        }

        // POST api/company/add
        public CompanyViewModel Add(CompanyViewModel company)
        {
            return _companyAppService.Add(company);
        }

        // PUT api/company/atualizar
        public CompanyViewModel Update(CompanyViewModel company)
        {
            return _companyAppService.Update(company);
        }

        // DELETE api/company/del/{codigo}
        public void Delete(int codigo)
        {
            _companyAppService.Remove(codigo);
        }

        // GET api/company/{codigo}
        public CompanyViewModel GetById(int codigo)
        {
            return _companyAppService.GetById(codigo);
        }

        // GET api/company/all
        public List<CompanyViewModel> GetAll()
        {
            return _companyAppService.GetAll().ToList();
        }
    }
}
