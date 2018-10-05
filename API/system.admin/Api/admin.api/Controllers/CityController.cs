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
    public class CityController : ApiController
    {
        private readonly IAppService<CityViewModel, City> _cityAppService;

        public CityController(IAppService<CityViewModel, City> cityAppService)
        {
            _cityAppService = cityAppService;
        }

        // POST api/city/add
        public CityViewModel Add(CityViewModel city)
        {
            return _cityAppService.Add(city);
        }

        // PUT api/city/atualizar
        public CityViewModel Update(CityViewModel city)
        {
            return _cityAppService.Update(city);
        }

        // DELETE api/city/del/{codigo}
        public void Delete(int codigo)
        {
            _cityAppService.Remove(codigo);
        }

        // GET api/city/{codigo}
        public CityViewModel GetById(int codigo)
        {
            return _cityAppService.GetById(codigo);
        }

        // GET api/city/all
        public List<CityViewModel> GetAll()
        {
            return _cityAppService.GetAll().ToList();
        }
    }
}
