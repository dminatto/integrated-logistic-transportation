using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using admin.services.Validators;
using admin.services.Services;
using admin.domain.Entities;

namespace admin.application.Controllers
{
    [Produces("application/json")]
    [Route("admin-api/user")]
    public class UserController : Controller
    {
        private BaseService<User> service = new BaseService<User>();

        [HttpPost]
        public IActionResult Post([FromBody] User item)
        {
            try
            {
                service.post<UserValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] User item)
        {
            try
            {
                service.put<UserValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return new ObjectResult(service.get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

     /*   [HttpGet"{id}"]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
       */ 
    }
}
