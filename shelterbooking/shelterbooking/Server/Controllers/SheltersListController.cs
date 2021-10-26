using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using shelterbooking.Shared;

namespace shelterbooking.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SheltersListController
    {
        private readonly ILogger<SheltersListController> _logger;

        public SheltersListController(ILogger<SheltersListController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<IEnumerable<Shelter>> GetAsync()
        {
            string url = "https://localhost:5001/api/shelters";
            HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(url);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                List<Shelter> item = new();
                foreach (var obj in jsonObj)
                { 
                    item.Add(obj.Navn);
                }
                return item;

        }
    }
}
