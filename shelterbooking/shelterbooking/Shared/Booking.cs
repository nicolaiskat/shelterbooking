using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelterbooking.Shared
{
    public class Booking
    {
        public string _id { get; set; }

        public string reference_nr { get; set; }

        public string bruger_id { get; set; }

        public Shelter shelter { get; set; }

        public string kommentar { get; set; }

        public DateTime startdato { get; set; }

        public DateTime slutdato { get; set; }
    }
}
