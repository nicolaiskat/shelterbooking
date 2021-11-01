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
    public class SheltersController : Controller
    {
        private readonly ShelterService _shelterService;


        public SheltersController(ShelterService shelterService)
        {
            _shelterService = shelterService;
        }

        [HttpGet]
        public ActionResult<List<Shelter>> Get() =>
            _shelterService.Get();

        [HttpGet("{id:length(24)}", Name = "GetShelter")]
        public ActionResult<Shelter> Get(string id)
        {
            var shelter = _shelterService.Get(id);

            if (shelter == null)
            {
                return NotFound();
            }

            return shelter;
        }

        [HttpPost]
        public ActionResult<Shelter> Create(Shelter shelter)
        {
            _shelterService.Create(shelter);

            return CreatedAtRoute("GetShelter", new { id = shelter._id }, shelter);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Shelter shelterIn)
        {
            var shelter = _shelterService.Get(id);

            if (shelter == null)
            {
                return NotFound();
            }

            _shelterService.Update(id, shelterIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var shelter = _shelterService.Get(id);

            if (shelter == null)
            {
                return NotFound();
            }

            _shelterService.Delete(shelter._id);

            return NoContent();
        }
    }
}
