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
    public class CompanyPartnerAppService : ApplicationService, IAppService<CompanyPartnerViewModel, CompanyPartner>
    {
        private readonly IService<CompanyPartner> _companyPartnerService;

        public CompanyPartnerAppService(IUnitOfWork uow, IService<CompanyPartner> CompanyPartnerService) : base(uow)
        {
            _companyPartnerService = CompanyPartnerService;
        }

        public CompanyPartnerViewModel Add(CompanyPartnerViewModel obj)
        {
            var companyPartner = Mapper.Map<CompanyPartnerViewModel, CompanyPartner>(obj);

            BeginTransaction();

            /*var companyPartnerReturn = _companyPartnerService.Put<CompanyPartner>(companyPartner);
            var companyPartnerReturnViewModel = Mapper.Map<CompanyPartner, CompanyPartnerViewModel>(companyPartnerReturn);
            */
            Commit();
            var companyPartnerReturnViewModel = new CompanyPartnerViewModel();
            return companyPartnerReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CompanyPartnerViewModel> GetAll()
        {
            var companyPartner = _companyPartnerService.Get();
            return Mapper.Map<IEnumerable<CompanyPartner>, IEnumerable<CompanyPartnerViewModel>>(companyPartner);
        }

        public CompanyPartnerViewModel GetById(int id)
        {
            return Mapper.Map<CompanyPartner, CompanyPartnerViewModel>(_companyPartnerService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _companyPartnerService.Delete(id);
            Commit();
        }

        public IEnumerable<CompanyPartnerViewModel> Search(Expression<Func<CompanyPartner, bool>> predicate)
        {
            var companyPartner = _companyPartnerService.Get();
            return Mapper.Map<IEnumerable<CompanyPartner>, IEnumerable<CompanyPartnerViewModel>>(companyPartner);
        }

        public CompanyPartnerViewModel Update(CompanyPartnerViewModel obj)
        {
            var companyPartner = Mapper.Map<CompanyPartnerViewModel, CompanyPartner>(obj);

            BeginTransaction();

            /*  var companyPartnerReturn = _companyPartnerService.Post<CompanyPartner>(companyPartner);
              var companyPartnerReturnViewModel = Mapper.Map<CompanyPartner, CompanyPartnerViewModel>(companyPartnerReturn); */
            var companyPartnerReturnViewModel = new CompanyPartnerViewModel();
            Commit();

            return companyPartnerReturnViewModel;
        }
    }
}
