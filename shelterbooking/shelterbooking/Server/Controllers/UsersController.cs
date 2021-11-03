using System;
using shelterbooking.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using shelterbooking.Server;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace shelterbooking.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly UserService _userService;


        public UsersController(UserService userservice)
        {
            _userService = userservice;
        }

        [HttpGet]
        public ActionResult<List<Bruger>> Get() =>
            _userService.Get();

        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<Bruger> Get(string id)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public ActionResult<Bruger> Create(Bruger user)
        {
            _userService.Create(user);

            return CreatedAtRoute("GetUser", new { id = user._id }, user);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Bruger userIn)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userService.Update(id, userIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userService.Delete(user._id);

            return NoContent();
        }
    }
}
