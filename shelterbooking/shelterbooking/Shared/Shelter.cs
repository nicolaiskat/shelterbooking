using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelterbooking.Shared
{
    public class Shelter
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<List<double>> coordinates { get; set; }
    }

    public class Properties
    {
        public string objekt_id { get; set; }
        public int cvr_kode { get; set; }
        public string cvr_navn { get; set; }
        public int kommunekode { get; set; }
        public string facil_ty { get; set; }
        public string navn { get; set; }
        public string beskrivels { get; set; }
        public string lang_beskr { get; set; }
        public int antal_pl { get; set; }
        public string ansvar_org { get; set; }
        public string kontakt_ved { get; set; }
        public string ansva_v { get; set; }
    }

}
