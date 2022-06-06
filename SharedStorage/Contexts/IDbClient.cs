using HospitalDataModel.Model;
using MongoDB.Driver;

namespace HospiotalServiceHub
{
    public interface IDbClient
    {
        IMongoDatabase GetDatabase();
    }
}
