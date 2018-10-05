using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using admin.domain.Interfaces;
using AutoMapper;

namespace admin.application.AppServices
{
    public class CustomerAppService :  ApplicationService, IAppService<CustomerViewModel, Customer>
    {
        private readonly IService<Customer> _customerService;

        public CustomerAppService(IUnitOfWork uow, IService<Customer> CustomerService) : base(uow)
        {
            _customerService = CustomerService;
        }

        public CustomerViewModel Add(CustomerViewModel obj)
        {
            var customer = Mapper.Map<CustomerViewModel, Customer>(obj);

            BeginTransaction();

            /*var customerReturn = _customerService.Put<Customer>(customer);
            var customerReturnViewModel = Mapper.Map<Customer, CustomerViewModel>(customerReturn);
            */
            Commit();
            var customerReturnViewModel = new CustomerViewModel();
            return customerReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            var customer = _customerService.Get();
            return Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(customer);
        }

        public CustomerViewModel GetById(int id)
        {
            return Mapper.Map<Customer, CustomerViewModel>(_customerService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _customerService.Delete(id);
            Commit();
        }

        public IEnumerable<CustomerViewModel> Search(Expression<Func<Customer, bool>> predicate)
        {
            var customer = _customerService.Get();
            return Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(customer);
        }

        public CustomerViewModel Update(CustomerViewModel obj)
        {
            var customer = Mapper.Map<CustomerViewModel, Customer>(obj);

            BeginTransaction();

            /*  var customerReturn = _customerService.Post<Customer>(customer);
              var customerReturnViewModel = Mapper.Map<Customer, CustomerViewModel>(customerReturn); */
            var customerReturnViewModel = new CustomerViewModel();
            Commit();

            return customerReturnViewModel;
        }
    }
}
