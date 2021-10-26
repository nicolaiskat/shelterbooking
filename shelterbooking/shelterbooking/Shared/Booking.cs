using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelterbooking.Shared
{
    public class Booking
    {
        public String _id { get; set; }

        public String reference_nr { get; set; }

        public String bruger_id { get; set; }

        public Shelter shelter { get; set; }

        public String kommentar { get; set; }

        public DateTime startdato { get; set; }

        public DateTime slutdato { get; set; }
    }
}
