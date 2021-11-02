using System;
namespace shelterbooking.Server
{
    public class BookingsDatabaseSettings : IBookingsDatabaseSettings
    {
        public string BookingsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBookingsDatabaseSettings
    {
        string BookingsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
