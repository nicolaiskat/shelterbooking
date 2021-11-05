using System;
namespace shelterbooking.Server
{
    public class BrugereDatabaseSettings : IBrugereDatabaseSettings
    {
        public string BrugereCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBrugereDatabaseSettings
    {
        string BrugereCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
