using System;
namespace shelterbooking.Server
{
    public class SheltersDatabaseSettings : ISheltersDatabaseSettings
    {
        public string SheltersCollectionName { get; set; }
        public string BookingsCollectionName { get; set; }
        public string BrugereCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISheltersDatabaseSettings
    {
        public string SheltersCollectionName { get; set; }
        public string BookingsCollectionName { get; set; }
        public string BrugereCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
