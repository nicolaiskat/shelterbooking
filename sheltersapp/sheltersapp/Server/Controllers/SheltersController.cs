using sheltersapp.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using sheltersapp.Server;

namespace mongodb_dotnet_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelterController : ControllerBase
    {
        private readonly ShelterService _shelterService;

        public ShelterController(ShelterService shelterService)
        {
            _shelterService = shelterService;
        }

        [HttpGet]
        public ActionResult<List<Shelter>> Get() =>
            _shelterService.Get();

        [HttpGet("{id:length(24)}", Name = "GetShelters")]
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

            return CreatedAtRoute("GetShelters", new { id = shelter._id }, shelter);
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