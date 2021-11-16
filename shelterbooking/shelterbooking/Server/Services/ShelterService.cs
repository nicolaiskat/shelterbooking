using System;
using MongoDB.Driver;
using System.Collections.Generic;
using shelterbooking.Shared;
using System.Linq;

namespace shelterbooking.Server
{
    public class ShelterService
    {
        private readonly IMongoCollection<Shelter> _shelters;
        private readonly IMongoCollection<Booking> _bookings;
        private readonly IMongoCollection<Bruger> _users;

        public ShelterService(ISheltersDatabaseSettings settings)
        {
            var client = new MongoClient("mongodb+srv://dbGruppen:dbGruppen69@shelterbooking.5yhuf.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");

            _shelters = database.GetCollection<Shelter>(settings.SheltersCollectionName);
            _bookings = database.GetCollection<Booking>(settings.BookingsCollectionName);
            _users = database.GetCollection<Bruger>(settings.BrugereCollectionName);
        }


        //Find alle shelters
        public List<Shelter> GetShelters() => _shelters.Find(shelter => true).ToList();
        public List<Booking> GetBookings() => _bookings.Find(booking => true).ToList();
        public List<Bruger> GetUsers() => _users.Find(user => true).ToList();

        ////Find enkelt shelter
        public Shelter GetShelter(string id) => _shelters.Find(shelter => shelter._id == id).FirstOrDefault();
        public Booking GetBooking(string id) => _bookings.Find(booking => booking._id == id).FirstOrDefault();
        public Bruger GetUser(string id) => _users.Find(user => user._id == id).FirstOrDefault();

        ////Opret shelter
        public Shelter Create(Shelter shelter)
        {
            _shelters.InsertOne(shelter);
            return shelter;
        }
        public Booking Create(Booking booking)
        {
            _bookings.InsertOne(booking);
            return booking;
        }
        public Bruger Create(Bruger user)
        {
            _users.InsertOne(user);
            return user;
        }

        ////Opdater shelter
        public void Update(string id, Shelter updatedShelter) => _shelters.ReplaceOne(shelter => shelter._id == id, updatedShelter);
        public void Update(string id, Booking updatedBooking) => _bookings.ReplaceOne(booking => booking._id == id, updatedBooking);
        public void Update(string id, Bruger updatedUser) => _users.ReplaceOne(user => user._id == id, updatedUser);

        ////Delete shelter
        public void Delete(Shelter shelterForDeletion) => _shelters.DeleteOne(shelter => shelter._id == shelterForDeletion._id);
        public void Delete(Booking bookingForDeletion) => _bookings.DeleteOne(booking => booking._id == bookingForDeletion._id);
        public void Delete(Bruger userForDeletion) => _users.DeleteOne(user => user._id == userForDeletion._id);

        ////Dete shelter ud fra id
        public void DeleteShelter(string id) => _shelters.DeleteOne(shelter => shelter._id == id);
        public void DeleteBooking(string id) => _bookings.DeleteOne(booking => booking._id == id);
        public void DeleteUser(string id) => _users.DeleteOne(user => user._id == id);
    }
}
