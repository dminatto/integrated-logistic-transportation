using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace admin.api.Controllers
{
    public class CountryController : ApiController
    {
        private readonly IAppService<CountryViewModel, Country> _countryAppService;

        public CountryController(IAppService<CountryViewModel, Country> countryAppService)
        {
            _countryAppService = countryAppService;
        }

        // POST api/country/add
        public CountryViewModel Add(CountryViewModel country)
        {
            return _countryAppService.Add(country);
        }

        // PUT api/country/atualizar
        public CountryViewModel Update(CountryViewModel country)
        {
            return _countryAppService.Update(country);
        }

        // DELETE api/country/del/{codigo}
        public void Delete(int codigo)
        {
            _countryAppService.Remove(codigo);
        }

        // GET api/country/{codigo}
        public CountryViewModel GetById(int codigo)
        {
            return _countryAppService.GetById(codigo);
        }

        // GET api/country/all
        public List<CountryViewModel> GetAll()
        {
            return _countryAppService.GetAll().ToList();
        }
    }
}
