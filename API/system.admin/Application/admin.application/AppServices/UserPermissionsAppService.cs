using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using admin.domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace admin.application.AppServices
{
    public class UserPermissionsAppService : ApplicationService, IAppService<UserPermissionsViewModel, UserPermissions>
    {
        private readonly IService<UserPermissions> _userPermissionsService;

        public UserPermissionsAppService(IUnitOfWork uow, IService<UserPermissions> UserPermissionsService) : base(uow)
        {
            _userPermissionsService = UserPermissionsService;
        }

        public UserPermissionsViewModel Add(UserPermissionsViewModel obj)
        {
            var userPermissions = Mapper.Map<UserPermissionsViewModel, UserPermissions>(obj);

            BeginTransaction();

            /*var userPermissionsReturn = _userPermissionsService.Put<UserPermissions>(userPermissions);
            var userPermissionsReturnViewModel = Mapper.Map<UserPermissions, UserPermissionsViewModel>(UserPermissionsReturn);
            */
            Commit();
            var userPermissionsReturnViewModel = new UserPermissionsViewModel();
            return userPermissionsReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<UserPermissionsViewModel> GetAll()
        {
            var userPermissions = _userPermissionsService.Get();
            return Mapper.Map<IEnumerable<UserPermissions>, IEnumerable<UserPermissionsViewModel>>(userPermissions);
        }

        public UserPermissionsViewModel GetById(int id)
        {
            return Mapper.Map<UserPermissions, UserPermissionsViewModel>(_userPermissionsService.Get(id));
            ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _userPermissionsService.Delete(id);
            Commit();
        }

        public IEnumerable<UserPermissionsViewModel> Search(Expression<Func<UserPermissions, bool>> predicate)
        {
            var userPermissions = _userPermissionsService.Get();
            return Mapper.Map<IEnumerable<UserPermissions>, IEnumerable<UserPermissionsViewModel>>(userPermissions);
        }

        public UserPermissionsViewModel Update(UserPermissionsViewModel obj)
        {
            var userPermissions = Mapper.Map<UserPermissionsViewModel, UserPermissions>(obj);

            BeginTransaction();

            /*  var userPermissionsReturn = _userPermissionsService.Post<UserPermissions>(userPermissions);
              var userPermissionsReturnViewModel = Mapper.Map<UserPermissions, UserPermissionsViewModel>(UserPermissionsReturn); */
            var userPermissionsReturnViewModel = new UserPermissionsViewModel();
            Commit();

            return userPermissionsReturnViewModel;

        }
    }
}
