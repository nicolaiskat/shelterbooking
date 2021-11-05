using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using shelterbooking.Shared;
using shelterbooking.Server;

namespace shelterbooking.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrugereListController
    {
        private readonly ILogger<BrugereListController> _logger;

        public BrugereListController(ILogger<BrugereListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Bruger>> GetAsync()
        {
            string url = "https://localhost:5001/api/brugere";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            List<Bruger> item = new();
            foreach (var obj in jsonObj)
            {
                //Defining bruger
                Bruger bruger = new Bruger(
                        $"{obj["_id"]}",
                        $"{obj["fornavn"]}",
                        $"{obj["efternavn"]}",
                        $"{obj["mobil"]}",
                        $"{obj["email"]}",
                        $"{obj["password"]}",
                        Convert.ToInt32($"{obj["level"]}")
                        );

                //Tilføj bruger til liste
                item.Add(bruger);
            }
            return item;

        }


    }

}
