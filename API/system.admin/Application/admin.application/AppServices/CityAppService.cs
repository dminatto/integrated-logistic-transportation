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
    public class CityAppService : ApplicationService, IAppService<CityViewModel, City>
    {
        private readonly IService<City> _cityService;

        public CityAppService(IUnitOfWork uow, IService<City> CityService) : base(uow)
        {
            _cityService = CityService;
        }

        public CityViewModel Add(CityViewModel obj)
        {
            var city = Mapper.Map<CityViewModel, City>(obj);

            BeginTransaction();

            /*var CityReturn = _cityService.Put<City>(City);
            var CityReturnViewModel = Mapper.Map<City, CityViewModel>(CityReturn);
            */
            Commit();
            var cityReturnViewModel = new CityViewModel();
            return cityReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CityViewModel> GetAll()
        {
            var citys = _cityService.Get();
            return Mapper.Map<IEnumerable<City>, IEnumerable<CityViewModel>>(citys);
        }

        public CityViewModel GetById(int id)
        {
            return Mapper.Map<City, CityViewModel>(_cityService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _cityService.Delete(id);
            Commit();
        }

        public IEnumerable<CityViewModel> Search(Expression<Func<City, bool>> predicate)
        {
            var citys = _cityService.Get();
            return Mapper.Map<IEnumerable<City>, IEnumerable<CityViewModel>>(citys);
        }

        public CityViewModel Update(CityViewModel obj)
        {

            var citys = Mapper.Map<CityViewModel, City>(obj);

            BeginTransaction();

            /*  var cityReturn = _cityService.Post<Ticket>(citys);
              var cityReturnViewModel = Mapper.Map<Ticket, TicketViewModel>(cityReturn); */
            var cityReturnViewModel = new CityViewModel();
            Commit();

            return cityReturnViewModel;
        }
    }
}
