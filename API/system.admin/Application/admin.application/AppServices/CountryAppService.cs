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
    public class CountryAppService : ApplicationService, IAppService<CountryViewModel, Country>
    {
        private readonly IService<Country> _countryService;

        public CountryAppService(IUnitOfWork uow, IService<Country> countryService) : base(uow)
        {
            _countryService = countryService;
        }

        public CountryViewModel Add(CountryViewModel obj)
        {
            var country = Mapper.Map<CountryViewModel, Country>(obj);

            BeginTransaction();

            /*var countryReturn = _countryService.Put<Country>(country);
            var countryReturnViewModel = Mapper.Map<Country, CountryViewModel>(countryReturn);
            */
            Commit();
            var countryReturnViewModel = new CountryViewModel();
            return countryReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CountryViewModel> GetAll()
        {
            var country = _countryService.Get();
            return Mapper.Map<IEnumerable<Country>, IEnumerable<CountryViewModel>>(country);
        }

        public CountryViewModel GetById(int id)
        {
            return Mapper.Map<Country, CountryViewModel>(_countryService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _countryService.Delete(id);
            Commit();
        }

        public IEnumerable<CountryViewModel> Search(Expression<Func<Country, bool>> predicate)
        {
            var country = _countryService.Get();
            return Mapper.Map<IEnumerable<Country>, IEnumerable<CountryViewModel>>(country);
        }

        public CountryViewModel Update(CountryViewModel obj)
        {
            var country = Mapper.Map<CountryViewModel, Country>(obj);

            BeginTransaction();

            /*  var countryReturn = _countryService.Post<Country>(country);
              var countryReturnViewModel = Mapper.Map<Country, CountryViewModel>(countryReturn); */
            var countryReturnViewModel = new CountryViewModel();
            Commit();

            return countryReturnViewModel;
        }
    }
}
