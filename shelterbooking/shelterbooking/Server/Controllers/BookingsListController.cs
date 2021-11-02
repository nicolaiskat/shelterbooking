using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shelterbooking.Shared;
using shelterbooking.Server;
using Newtonsoft.Json;


namespace shelterbooking.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingsListController
    {
        private readonly ILogger<BookingsListController> _logger;

        public BookingsListController(ILogger<BookingsListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Shelter>> GetAsync()
        {
            string url = "https://localhost:5001/api/bookings";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            dynamic jsonObj = JsonContent.DeserializeObject(json);
            List<Booking> item = new();
            foreach (var obj in jsonObj)
            {
                //Defining properties
                Booking booking = new Booking(
                                $"{obj["_id"]}",
                                $"{obj["shelter_id"]}",
                                $"{obj["fuldenavn"]}",
                                Convert.ToInt32($"{obj["telefon"]}"),
                                $"{obj["kommentar"]}",
                                $"{obj["startdato"]}",
                                $"{obj["slutdato"]}");


                //Tilføj shelter til liste
                item.Add(booking);
            }
            return item;

        }
       

        }

    }
