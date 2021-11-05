using System;
using MongoDB.Driver;
using System.Collections.Generic;
using shelterbooking.Shared;
using System.Linq;

namespace shelterbooking.Server
{
    public class BrugerService
    {
        private readonly IMongoCollection<Bruger> _brugere;

        public BrugerService(IBrugereDatabaseSettings settings)
        {
            var client = new MongoClient("mongodb+srv://dbGruppen:dbGruppen69@shelterbooking.5yhuf.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");

            _brugere = database.GetCollection<Bruger>(settings.BrugereCollectionName);
        }


        //Find alle brugers
        public List<Bruger> Get() => _brugere.Find(bruger => true).ToList();

        ////Find enkelt bruger
        public Bruger Get(string id) => _brugere.Find(bruger => bruger._id == id).FirstOrDefault();

        ////Opret bruger
        public Bruger Create(Bruger bruger)
        {
            _brugere.InsertOne(bruger);
            return bruger;
        }

        ////Opdater bruger
        public void Update(string id, Bruger updatedShelter) => _brugere.ReplaceOne(bruger => bruger._id == id, updatedShelter);

        ////Delete bruger
        public void Delete(Bruger brugerForDeletion) => _brugere.DeleteOne(bruger => bruger._id == brugerForDeletion._id);

        ////Dete bruger ud fra id
        public void Delete(string id) => _brugere.DeleteOne(bruger => bruger._id == id);
    }
}
