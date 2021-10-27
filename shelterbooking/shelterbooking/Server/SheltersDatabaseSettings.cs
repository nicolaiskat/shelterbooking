using System;
namespace shelterbooking.Server
{
    public class SheltersDatabaseSettings : ISheltersDatabaseSettings
    {
        public string SheltersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISheltersDatabaseSettings
    {
        string SheltersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
