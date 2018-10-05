using admin.application.Interfaces;
using admin.application.ViewModels;
using admin.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace admin.api.Controllers
{
    public class UserController : ApiController
    {
        private readonly IAppService<UserViewModel, User> _userAppService;

        public UserController(IAppService<UserViewModel, User> userAppService)
        {
            _userAppService = userAppService;
        }

        // POST api/user/add
        public UserViewModel Add(UserViewModel user)
        {
            return _userAppService.Add(user);
        }

        // PUT api/user/atualizar
        public UserViewModel Update(UserViewModel user)
        {
            return _userAppService.Update(user);
        }

        // DELETE api/user/del/{codigo}
        public void Delete(int codigo)
        {
            _userAppService.Remove(codigo);
        }

        // GET api/user/{codigo}
        public UserViewModel GetById(int codigo)
        {
            return _userAppService.GetById(codigo);
        }

        // GET api/user/all
        public List<UserViewModel> GetAll()
        {
            return _userAppService.GetAll().ToList();
        }
    }
}
