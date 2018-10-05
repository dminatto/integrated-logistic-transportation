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
    public class CompanyAppService : ApplicationService, IAppService<CompanyViewModel, Company>
    {
        private readonly IService<Company> _companyService;

        public CompanyAppService(IUnitOfWork uow, IService<Company> CompanyService) : base(uow)
        {
            _companyService = CompanyService;
        }

        public CompanyViewModel Add(CompanyViewModel obj)
        {
            var company = Mapper.Map<CompanyViewModel, Company>(obj);

            BeginTransaction();

            /*var companyReturn = _companyService.Put<City>(company);
            var companyReturnViewModel = Mapper.Map<City, CompanyViewModel>(companyReturn);
            */
            Commit();
            var companyReturnViewModel = new CompanyViewModel();
            return companyReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CompanyViewModel> GetAll()
        {
            var company = _companyService.Get();
            return Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(company);
        }

        public CompanyViewModel GetById(int id)
        {
            return Mapper.Map<Company, CompanyViewModel>(_companyService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _companyService.Delete(id);
            Commit();
        }

        public IEnumerable<CompanyViewModel> Search(Expression<Func<Company, bool>> predicate)
        {
            var company = _companyService.Get();
            return Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(company);
        }

        public CompanyViewModel Update(CompanyViewModel obj)
        {
            var company = Mapper.Map<CompanyViewModel, Company>(obj);

            BeginTransaction();

            /*  var companyReturn = _companyService.Post<Company>(company);
              var companyReturnViewModel = Mapper.Map<Company, CompanyViewModel>(cityReturn); */
            var companyReturnViewModel = new CompanyViewModel();
            Commit();

            return companyReturnViewModel;
        }
    }
}
