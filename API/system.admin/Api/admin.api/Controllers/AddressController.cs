using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace admin.api.Controllers
{
    public class AddressController
    {
        private readonly IAppService<AddressViewModel, Address> _addressAppService;

        public AddressController(IAppService<AddressViewModel, Address> addressAppService)
        {
            _addressAppService = addressAppService;
        }

        // POST api/address/add
        public AddressViewModel Add(AddressViewModel address)
        {
            return _addressAppService.Add(address);
        }

        // PUT api/address/atualizar
        public AddressViewModel Update(AddressViewModel address)
        {
            return _addressAppService.Update(address);
        }

        // DELETE api/address/del/{codigo}
        public void Delete(int codigo)
        {
            _addressAppService.Remove(codigo);
        }

        // GET api/address/{codigo}
        public AddressViewModel GetById(int codigo)
        {
            return _addressAppService.GetById(codigo);
        }

        // GET api/address/all
        public List<AddressViewModel> GetAll()
        {
            return _addressAppService.GetAll().ToList();
        }
    }
}