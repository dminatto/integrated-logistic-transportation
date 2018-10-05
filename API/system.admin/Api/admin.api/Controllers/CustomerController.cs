using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace admin.api.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly IAppService<CustomerViewModel, Customer> _customerAppService;

        public CustomerController(IAppService<CustomerViewModel, Customer> customerAppService)
        {
            _customerAppService = customerAppService;
        }

        // POST api/customer/add
        public CustomerViewModel Add(CustomerViewModel customer)
        {
            return _customerAppService.Add(customer);
        }

        // PUT api/customer/atualizar
        public CustomerViewModel Update(CustomerViewModel customer)
        {
            return _customerAppService.Update(customer);
        }

        // DELETE api/customer/del/{codigo}
        public void Delete(int codigo)
        {
            _customerAppService.Remove(codigo);
        }

        // GET api/customer/{codigo}
        public CustomerViewModel GetById(int codigo)
        {
            return _customerAppService.GetById(codigo);
        }

        // GET api/customer/all
        public List<CustomerViewModel> GetAll()
        {
            return _customerAppService.GetAll().ToList();
        }
    }
}
