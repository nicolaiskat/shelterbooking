using System;
using shelterbooking.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using shelterbooking.Server;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
namespace shelterbooking.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrugereController : Controller
    {
        private readonly ShelterService _brugerService;


        public BrugereController(ShelterService brugerService)
        {
            _brugerService = brugerService;
        }

        [HttpGet]
        public ActionResult<List<Bruger>> Get() =>
            _brugerService.GetUsers();

        [HttpGet("{id:length(24)}", Name = "GetBruger")]
        public ActionResult<Bruger> Get(string id)
        {
            var bruger = _brugerService.GetUser(id);

            if (bruger == null)
            {
                return NotFound();
            }

            return bruger;
        }

        [HttpPost]
        public ActionResult<Bruger> Create(Bruger bruger)
        {
            _brugerService.Create(bruger);

            return CreatedAtRoute("GetBruger", new { id = bruger._id }, bruger);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Bruger brugerIn)
        {
            var bruger = _brugerService.GetUser(id);

            if (bruger == null)
            {
                return NotFound();
            }

            _brugerService.Update(id, brugerIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var bruger = _brugerService.GetUser(id);

            if (bruger == null)
            {
                return NotFound();
            }

            _brugerService.DeleteUser(bruger._id);

            return NoContent();
        }
    }
}
