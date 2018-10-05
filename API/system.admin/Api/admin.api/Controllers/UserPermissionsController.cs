using admin.application.Interfaces;
using admin.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using admin.domain.Entities;

namespace admin.api.Controllers
{
    public class permissionPermissionsController : ApiController
    {
        private readonly IAppService<UserPermissionsViewModel, UserPermissions> _permissionAppService;

        public permissionPermissionsController(IAppService<UserPermissionsViewModel, UserPermissions> permissionAppService)
        {
            _permissionAppService = permissionAppService;
        }

        // POST api/permission/add
        public UserPermissionsViewModel Add(UserPermissionsViewModel permission)
        {
            return _permissionAppService.Add(permission);
        }

        // PUT api/permission/atualizar
        public UserPermissionsViewModel Update(UserPermissionsViewModel permission)
        {
            return _permissionAppService.Update(permission);
        }

        // DELETE api/permission/del/{codigo}
        public void Delete(int codigo)
        {
            _permissionAppService.Remove(codigo);
        }

        // GET api/permission/{codigo}
        public UserPermissionsViewModel GetById(int codigo)
        {
            return _permissionAppService.GetById(codigo);
        }

        // GET api/permission/all
        public List<UserPermissionsViewModel> GetAll()
        {
            return _permissionAppService.GetAll().ToList();
        }
    }
}
