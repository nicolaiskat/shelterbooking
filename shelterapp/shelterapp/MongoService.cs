﻿using mongodb_dotnet_example.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace shelterapp
{
    public class MongoService
    {
        private readonly IMongoCollection<Shelter> _shelters;

        public MongoService(ISheltersDatabaseSettings settings)
        {
            var client = new MongoClient("mongodb+srv://dbGruppen:dbGruppen69@shelterbooking.5yhuf.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");

            _shelters = database.GetCollection<Shelter>(settings.SheltersCollectionName);
        }

        //Find alle shelters
        public List<Shelter> Get() => _shelters.Find(shelter => true).ToList();


        //Find enkelt shelter
        public Shelter Get(string id) => _shelters.Find(shelter => shelter.Id == id).FirstOrDefault();

        //Opret shelter
        public Shelter Create(Shelter shelter)
        {
            _shelters.InsertOne(shelter);
            return shelter;
        }

        //Opdater shelter
        public void Update(string id, Shelter updatedShelter) => _shelters.ReplaceOne(shelter => shelter.Id == id, updatedShelter);

        //Delete shelter
        public void Delete(Shelter shelterForDeletion) => _shelters.DeleteOne(shelter => shelter.Id == shelterForDeletion.Id);

        //Dete shelter ud fra id
        public void Delete(string id) => _shelters.DeleteOne(shelter => shelter.Id == id);
    }
}