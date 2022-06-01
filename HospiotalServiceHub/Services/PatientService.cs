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

        public async Task<ResponseModel<bool>> DeletePatient(int id)
        {
            try
            {
                _patients.DeleteOne(patient => patient._id == id);

                return new ResponseModel<bool>()
                {
                    Result = true,
                    HasError = false
                };
            }
            catch(Exception)
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

        public async Task<ResponseModel<PatientModel>> GetPatient(int id)
        {
            var data = _patients.Find(patient => patient._id == id);

            try
            {
                return new ResponseModel<PatientModel>()
                {
                    Result = (PatientModel)data,
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
