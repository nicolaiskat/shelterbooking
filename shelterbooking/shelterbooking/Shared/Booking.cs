﻿using System;
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
        public string _id { get; set; }
        public string reference_nr { get; set; }
        public string bruger_id { get; set; }
        public string shelter_id { get; set; }
        public string kommentar { get; set; }
        public DateTime startdato { get; set; }
        public DateTime slutdato { get; set; }

        public Booking(string shelter_id, string kommentar, DateTime startdato, DateTime slutdato)
        {
            this.shelter_id = shelter_id;
            this.kommentar = kommentar;
            this.startdato = startdato;
            this.slutdato = slutdato;
        }

        public Booking() { }
    }


}
