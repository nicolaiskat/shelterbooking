using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

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

        public Shelter(string _id, string type, Geometry geometry, Properties properties)
        {
            this._id = _id;
            this.type = type;
            this.geometry = geometry;
            this.properties = properties;
        }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<List<double>> coordinates { get; set; }

        public Geometry(string type, List<List<double>> coordinates)
        {
            this.type = type;
            this.coordinates = coordinates;
        }
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

        public Properties(string objekt_id, int cvr_kode, string cvr_navn,
                            int kommunekode, string facil_ty, string navn,
                            string beskrivelse, string lang_beskr, int antal_pl,
                            string ansvar_org, string kontakt_ved, string ansva_v)
        {
            this.objekt_id = objekt_id;
            this.cvr_kode = cvr_kode;
            this.cvr_navn = cvr_navn;
            this.kommunekode = kommunekode;
            this.facil_ty = facil_ty;
            this.navn = navn;
            this.beskrivels = beskrivels;
            this.lang_beskr = lang_beskr;
            this.antal_pl = antal_pl;
            this.ansvar_org = ansvar_org;
            this.kontakt_ved = kontakt_ved;
            this.ansva_v = ansva_v;
        }
    }

}
