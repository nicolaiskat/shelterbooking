using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace shelterbooking.Shared
{
    public class Bruger
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("fornavn")]
        public string fornavn { get; set; }
        [JsonProperty("efternavn")]
        public string efternavn { get; set; }
        [JsonProperty("mobil")]
        public int mobil { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("password")]
        public string password { get; set; }
        [JsonProperty("access")]
        public Access access { get; set; }
    }
    public class Access
    {
        [JsonProperty("level")]
        public int level { get; set; }
        [JsonProperty("beskr")]
        public string beskr { get; set; }
    }
}
