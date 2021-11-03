using System;
using MongoDB.Driver;
using System.Collections.Generic;
using shelterbooking.Shared;
using System.Linq;

namespace shelterbooking.Server
{
    public class UserService
    {
        private readonly IMongoCollection<Bruger> _users;

        public UserService(IUsersDatabaseSettings settings)
        {
            var client = new MongoClient("mongodb+srv://dbGruppen:dbGruppen69@shelterbooking.5yhuf.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");

            _users = database.GetCollection<Bruger>(settings.UsersCollectionName);
        }


        //Find alle bookings
        public List<Bruger> Get() => _users.Find(user => true).ToList();

        ////Find enkelt booking
        public Bruger Get(string id) => _users.Find(user => user._id == id).FirstOrDefault();

        ////Opret booking
        public Bruger Create(Bruger user)
        {
            _users.InsertOne(user);
            return user;
        }

        ////Opdater booking
        public void Update(string id, Bruger updatedUser) => _users.ReplaceOne(user => user._id == id, updatedUser);

        ////Delete booking
        public void Delete(Bruger userForDeletion) => _users.DeleteOne(user => user._id == userForDeletion._id);

        ////Delete booking ud fra id
        public void Delete(string id) => _users.DeleteOne(user => user._id == id);
    }
}
