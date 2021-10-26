using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace shelterbooking.Shared
{
    public class Booking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("reference_nr")]
        public string reference_nr { get; set; }

        [JsonProperty("bruger_id")]
        public string bruger_id { get; set; }

        [JsonProperty("shelter")]
        public Shelter shelter { get; set; }

        [JsonProperty("kommentar")]
        public string kommentar { get; set; }

        [JsonProperty("startdato")]
        public DateTime startdato { get; set; }

        [JsonProperty("slutdato")]
        public DateTime slutdato { get; set; }
    }
}
