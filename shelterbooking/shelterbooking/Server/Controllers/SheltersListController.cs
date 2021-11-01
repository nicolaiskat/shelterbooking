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
    public class SheltersListController
    {
        private readonly ILogger<SheltersListController> _logger;

        public SheltersListController(ILogger<SheltersListController> logger)
        {
            _logger = logger;
        }

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
                //Defining properties
                Properties properties = new Properties(
                                $"{obj["properties"]["objekt_id"]}",
                                Convert.ToInt32($"{obj["properties"]["cvr_kode"]}"),
                                $"{obj["properties"]["cvr_navn"]}",
                                Convert.ToInt32($"{obj["properties"]["kommunekode"]}"),
                                $"{obj["properties"]["facil_ty"]}",
                                $"{obj["properties"]["navn"]}",
                                $"{obj["properties"]["beskrivels"]}",
                                $"{obj["properties"]["lang_beskr"]}",
                                Convert.ToInt32($"{obj["properties"]["antal_pl"]}"),
                                $"{obj["properties"]["ansvar_org"]}",
                                $"{obj["properties"]["ansva_v"]}");

                //Defining Coordinates to Geometry
                string lat = $"{obj["geometry"]["coordinates"][0][0]}";
                double latitude = Convert.ToDouble(lat);
                string lon = $"{obj["geometry"]["coordinates"][0][1]}";
                double longitude = Convert.ToDouble(lon);
                List<List<double>> coordinates = new() { new() { latitude, longitude } };
                Geometry geometry = new Geometry($"{obj["geometry"]["type"]}", coordinates);

                //Defining shelter
                Shelter shelter = new Shelter(
                        $"{obj["_id"]}",
                        $"{obj["type"]}",
                        geometry,
                        properties);

                //Tilføj shelter til liste
                item.Add(shelter);
            }
            return item;

        }
    }

}
