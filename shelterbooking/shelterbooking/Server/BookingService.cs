using System;
using MongoDB.Driver;
using System.Collections.Generic;
using shelterbooking.Shared;
using System.Linq;

namespace shelterbooking.Server
{
    public class BookingService
    {
        private readonly IMongoCollection<Booking> _bookings;

        public BookingService(IBookingsDatabaseSettings settings)
        {
            var client = new MongoClient("mongodb+srv://dbGruppen:dbGruppen69@shelterbooking.5yhuf.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");

            _bookings = database.GetCollection<Booking>(settings.BookingsCollectionName);
        }


        //Find alle bookings
        public List<Booking> Get() => _bookings.Find(booking => true).ToList();

        ////Find enkelt booking
        public Booking Get(string id) => _bookings.Find(booking => booking._id == id).FirstOrDefault();

        ////Opret booking
        public Booking Create(Booking booking)
        {
            _bookings.InsertOne(booking);
            return booking;
        }

        ////Opdater booking
        public void Update(string id, Booking updatedBooking) => _bookings.ReplaceOne(booking => booking._id == id, updatedBooking);

        ////Delete booking
        public void Delete(Booking bookingForDeletion) => _bookings.DeleteOne(booking => booking._id == bookingForDeletion._id);

        ////Delete booking ud fra id
        public void Delete(string id) => _bookings.DeleteOne(booking => booking._id == id);
    }
}
