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
    public class UserProfileController : ApiController
    {
        private readonly IAppService<UserProfileViewModel, UserProfile> _profileAppService;

        public UserProfileController(IAppService<UserProfileViewModel, UserProfile> profileAppService)
        {
            _profileAppService = profileAppService;
        }

        // POST api/profile/add
        public UserProfileViewModel Add(UserProfileViewModel profile)
        {
            return _profileAppService.Add(profile);
        }

        // PUT api/profile/atualizar
        public UserProfileViewModel Update(UserProfileViewModel profile)
        {
            return _profileAppService.Update(profile);
        }

        // DELETE api/profile/del/{codigo}
        public void Delete(int codigo)
        {
            _profileAppService.Remove(codigo);
        }

        // GET api/profile/{codigo}
        public UserProfileViewModel GetById(int codigo)
        {
            return _profileAppService.GetById(codigo);
        }

        // GET api/profile/all
        public List<UserProfileViewModel> GetAll()
        {
            return _profileAppService.GetAll().ToList();
        }
    }
}
