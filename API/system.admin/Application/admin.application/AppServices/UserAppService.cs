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
    public class UserAppService : ApplicationService, IAppService<UserViewModel, User>
    {
        private readonly IService<User> _userService;

        public UserAppService(IUnitOfWork uow, IService<User> UserService) : base(uow)
        {
            _userService = UserService;
        }

        public UserViewModel Add(UserViewModel obj)
        {
            var user = Mapper.Map<UserViewModel, User>(obj);

            BeginTransaction();

            /*var userReturn = _userService.Put<User>(user);
            var userReturnViewModel = Mapper.Map<User, UserViewModel>(UserReturn);
            */
            Commit();
            var userReturnViewModel = new UserViewModel();
            return userReturnViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            var user = _userService.Get();
            return Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(user);
        }

        public UserViewModel GetById(int id)
        {
            return Mapper.Map<User, UserViewModel>(_userService.Get(id)); ;
        }

        public void Remove(int id)
        {
            BeginTransaction();
            _userService.Delete(id);
            Commit();
        }

        public IEnumerable<UserViewModel> Search(Expression<Func<User, bool>> predicate)
        {
            var user = _userService.Get();
            return Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(user);
        }
        
        public UserViewModel Update(UserViewModel obj)
        {
            var user = Mapper.Map<UserViewModel, User>(obj);

            BeginTransaction();

            /*  var userReturn = _userService.Post<User>(user);
              var userReturnViewModel = Mapper.Map<User, UserViewModel>(UserReturn); */
            var userReturnViewModel = new UserViewModel();
            Commit();

            return userReturnViewModel;
        }

     }
}
