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

        public Bruger(string _id, string fornavn, string efternavn, string mobil, string email, string password, int level=1)
        {
            this._id = _id;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.mobil = mobil;
            this.email = email;
            this.password = password;
            this.level = level;
        }
        public Bruger(string fornavn, string efternavn, string mobil, string email, string password, int level = 1)
        {
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.mobil = mobil;
            this.email = email;
            this.password = password;
            this.level = level;
        }
        public Bruger() { }
    }
    public class Access
    {
        public int level { get; set; }
        public string beskr { get; set; }
        public Access(int lvl=1, string beskr = "null")
        {
            this.level = lvl;
            this.beskr = beskr;
        }
    }
}
