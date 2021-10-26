using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace sheltersapp.Shared
{
        public class Geometry
        {
            public string type { get; set; }
            public List<List<double>> coordinates { get; set; }
        }

        public class Properties
        {
            public int temakode { get; set; }
            public string temanavn { get; set; }
            public string objekt_id { get; set; }
            public string versions_id { get; set; }
            public string systid_fra { get; set; }
            public object systid_til { get; set; }
            public string oprettet { get; set; }
            public int cvr_kode { get; set; }
            public string cvr_navn { get; set; }
            public int kommunekode { get; set; }
            public string bruger_id { get; set; }
            public int oprindkode { get; set; }
            public string oprindelse { get; set; }
            public int statuskode { get; set; }
            public string status { get; set; }
            public int off_kode { get; set; }
            public string offentlig { get; set; }
            public object noegle { get; set; }
            public object note { get; set; }
            public int facil_ty_k { get; set; }
            public string facil_ty { get; set; }
            public string navn { get; set; }
            public string beskrivels { get; set; }
            public string lang_beskr { get; set; }
            public object uk_k_beskr { get; set; }
            public object uk_l_beskr { get; set; }
            public object d_k_beskr { get; set; }
            public object d_l_beskr { get; set; }
            public string ansvar_org { get; set; }
            public string kontak_ved { get; set; }
            public object handicap_k { get; set; }
            public string handicap { get; set; }
            public int antal_pl { get; set; }
            public object vejkode { get; set; }
            public object vejnavn { get; set; }
            public object cvf_vejkode { get; set; }
            public object husnr { get; set; }
            public object postnr { get; set; }
            public object postnr_by { get; set; }
            public object adr_id { get; set; }
            public bool ansva_v_k { get; set; }
            public string ansva_v { get; set; }
            public object link { get; set; }
        }

        public class Shelter
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string _id { get; set; }

            public string type { get; set; }
            public Geometry geometry { get; set; }
            public Properties properties { get; set; }
        }
}
