using HospiotalServiceHub.IServices;
using HospitalDataModel.Model;
using MongoDB.Driver;

namespace HospiotalServiceHub.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IMongoCollection<DoctorModel> _doctors;

        public DoctorService(IDbClient dbClient)
        {
            _doctors = dbClient.GetDatabase().GetCollection<DoctorModel>("Doctors");
        }
        public List<DoctorModel> GetAllDoctors()
        {
            return _doctors.Find(doctor => true).ToList();
        }
    }
}
