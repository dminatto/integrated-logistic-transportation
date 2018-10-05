using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using admin.domain.Interfaces;
using AutoMapper;

namespace admin.application.AppServices
{
    public class AddressAppService : ApplicationService, IAppService<AddressViewModel, Address>
    {
        private readonly IService<Address> _addressService;

        public AddressAppService(IUnitOfWork uow, IService<Address> AddressService) : base(uow)
        {
            _addressService = AddressService;
        }

        public AddressViewModel Add(AddressViewModel obj)
        {
            var address = Mapper.Map<AddressViewModel, Address>(obj);

            BeginTransaction();

             /*var addressReturn = _addressService.Put<Address>(address);
             var addressReturnViewModel = Mapper.Map<Address, AddressViewModel>(addressReturn);
             */
            Commit();
            var addressReturnViewModel = new AddressViewModel();
            return addressReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<AddressViewModel> GetAll()
        {
            var addresss = _addressService.Get();
            return Mapper.Map<IEnumerable<Address>, IEnumerable<AddressViewModel>>(addresss);
        }

        public AddressViewModel GetById(int id)
        {
            return Mapper.Map<Address, AddressViewModel>(_addressService.Get(id));
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _addressService.Delete(id);
            Commit();
        }

        public IEnumerable<AddressViewModel> Search(Expression<Func<Address, bool>> predicate)
        {
            var addresss = _addressService.Get();
            return Mapper.Map<IEnumerable<Address>, IEnumerable<AddressViewModel>>(addresss);
        }

        public AddressViewModel Update(AddressViewModel obj)
        {
            var addresss = Mapper.Map<AddressViewModel, Address>(obj);

            BeginTransaction();

            /*  var addressReturn = _addressService.Post<Address>(addresss);
              var addressReturnViewModel = Mapper.Map<Address, AddressViewModel>(addressReturn); */
            var addressReturnViewModel = new AddressViewModel();
            Commit();

            return addressReturnViewModel;
        }
    }
}
