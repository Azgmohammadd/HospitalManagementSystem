using HospiotalServiceHub.IServices;
using HospitalDataModel.Model;
using MongoDB.Driver;
using SharedStorage.Models;

namespace HospiotalServiceHub.Services
{
    public class PatientService : IPatientService
    {
        private readonly IMongoCollection<PatientModel> _patients;

        public PatientService(IDbClient dbClient)
        {
            _patients = dbClient.GetDatabase().GetCollection<PatientModel>("Patients");
        }

        public async Task<ResponseModel<bool>> CreatePatient(PatientModel patient)
        {
            try
            {
                 _patients.InsertOne(patient);

                return new ResponseModel<bool>()
                {
                    Result = true,
                    HasError = false
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResponseModel<IEnumerable<PatientModel>>> GetAllPatients()
        {
            //TODO: await nadare

            var data = _patients.Find(Patient => true).ToList();

            try
            {
                return new ResponseModel<IEnumerable<PatientModel>>()
                {
                    Result = data,
                    HasError = false
                };
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
