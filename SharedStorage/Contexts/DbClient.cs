using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HospiotalServiceHub
{
    public class DbClient : IDbClient
    {
        private readonly IMongoDatabase database;

        public DbClient(IOptions<HospitalDBConfig> hospitalDbConfig)
        {
            var client = new MongoClient(hospitalDbConfig.Value.Connection_String);
            database = client.GetDatabase(hospitalDbConfig.Value.DataBase_Name);
        }

        public IMongoDatabase GetDatabase()
        {
            return database;
        }
    }
}
