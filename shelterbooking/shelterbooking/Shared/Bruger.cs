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
        public Access access { get { return new Access(0, "guest") ; } }
    }
    public class Access
    {
        public int level { get; set; }
        public string beskr { get; set; }
        public Access(int lvl, string beskr)
        {
            this.level = lvl;
            this.beskr = beskr;
        }
    }
}
