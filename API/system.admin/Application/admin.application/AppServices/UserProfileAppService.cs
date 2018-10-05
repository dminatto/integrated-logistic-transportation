using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using admin.domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace admin.application.AppServices
{
    public class UserProfileAppService : ApplicationService, IAppService<UserProfileViewModel, UserProfile>
    {
        private readonly IService<UserProfile> _userProfileService;

        public UserProfileAppService(IUnitOfWork uow, IService<UserProfile> UserProfileService) : base(uow)
        {
            _userProfileService = UserProfileService;
        }

        public UserProfileViewModel Add(UserProfileViewModel obj)
        {
            var userProfile = Mapper.Map<UserProfileViewModel, UserProfile>(obj);

            BeginTransaction();

            /*var userProfileReturn = _userProfileService.Put<UserProfile>(userProfile);
            var userProfileReturnViewModel = Mapper.Map<UserProfile, UserProfileViewModel>(UserProfileReturn);
            */
            Commit();
            var userProfileReturnViewModel = new UserProfileViewModel();
            return userProfileReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<UserProfileViewModel> GetAll()
        {
            var userProfile = _userProfileService.Get();
            return Mapper.Map<IEnumerable<UserProfile>, IEnumerable<UserProfileViewModel>>(userProfile);
        }

        public UserProfileViewModel GetById(int id)
        {
            return Mapper.Map<UserProfile, UserProfileViewModel>(_userProfileService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _userProfileService.Delete(id);
            Commit();
        }

        public IEnumerable<UserProfileViewModel> Search(Expression<Func<UserProfile, bool>> predicate)
        {
            var userProfile = _userProfileService.Get();
            return Mapper.Map<IEnumerable<UserProfile>, IEnumerable<UserProfileViewModel>>(userProfile);
        }

        public UserProfileViewModel Update(UserProfileViewModel obj)
        {
            var userProfile = Mapper.Map<UserProfileViewModel, UserProfile>(obj);

            BeginTransaction();

            /*  var userProfileReturn = _userProfileService.Post<UserProfile>(userProfile);
              var userProfileReturnViewModel = Mapper.Map<UserProfile, UserProfileViewModel>(UserProfileReturn); */
            var userProfileReturnViewModel = new UserProfileViewModel();
            Commit();

            return userProfileReturnViewModel;
        }
    }
}
