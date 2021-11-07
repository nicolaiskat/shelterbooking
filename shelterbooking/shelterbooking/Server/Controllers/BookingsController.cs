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
    public class BookingsController : Controller
    {
        private readonly ShelterService _bookingService;


        public BookingsController(ShelterService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public ActionResult<List<Booking>> Get() =>
            _bookingService.GetBookings();

        [HttpGet("{id:length(24)}", Name = "GetBooking")]
        public ActionResult<Booking> Get(string id)
        {
            var booking = _bookingService.GetBooking(id);

            if (booking == null)
            {
                return NotFound();
            }

            return booking;
        }

        [HttpPost]
        public ActionResult<Booking> Create(Booking booking)
        {
            _bookingService.Create(booking);

            return CreatedAtRoute("GetBooking", new { id = booking._id }, booking);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Booking bookingIn)
        {
            var booking = _bookingService.GetBooking(id);

            if (booking == null)
            {
                return NotFound();
            }

            _bookingService.Update(id, bookingIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var booking = _bookingService.GetBooking(id);

            if (booking == null)
            {
                return NotFound();
            }

            _bookingService.DeleteBooking(booking._id);

            return NoContent();
        }
    }
}
