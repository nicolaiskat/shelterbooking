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
        public string _id { get; set; }
        public string fornavn { get; set; }
        public string efternavn { get; set; }
        public string mobil { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int level { get; set; }

        public Bruger() { }

        public Bruger(string id, string fornavn, string efternavn, string mobil, string email, string password, int level)
        {
            _id = id;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.mobil = mobil;
            this.email = email;
            this.password = password;
            this.level = level;
        }

        public Bruger(string fornavn, string efternavn, string mobil, string email, string password, int level=0)
        {
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.mobil = mobil;
            this.email = email;
            this.password = password;
            this.level = level;
        }
    }
}
