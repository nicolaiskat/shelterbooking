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
        public string _id { get; set; }
        public string shelter_id { get; set; }
        public string bruger_id { get; set; }
        public string fuldenavn { get; set; }
        public int telefon {  get; set; }
        public string kommentar { get; set; }
        public string startdato { get; set; }
        public string slutdato { get; set; }

        public Booking(string shelter_id, string bruger_id, string kommentar, string startdato, string slutdato, string fuldenavn, int telefon)
        {
            this.shelter_id = shelter_id;
            this.bruger_id = bruger_id;
            this.kommentar = kommentar;
            this.startdato = startdato;
            this.slutdato = slutdato;
            this.fuldenavn = fuldenavn;
            this.telefon = telefon;
        }
        public Booking(string _id, string shelter_id, string bruger_id, string fuldenavn, int telefon, string kommentar, string startdato, string slutdato)
        {
            this._id = _id;
            this.shelter_id = shelter_id;
            this.bruger_id = bruger_id;
            this.kommentar = kommentar;
            this.startdato = startdato;
            this.slutdato = slutdato;
            this.fuldenavn = fuldenavn;
            this.telefon = telefon;
        }

        public Booking() { }
    }


}
