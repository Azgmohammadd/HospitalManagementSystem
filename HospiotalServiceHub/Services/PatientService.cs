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
                 await _patients.InsertOneAsync(patient);

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

        public async Task<ResponseModel<bool>> DeletePatient(long id)
        {
            try
            {
                var data = await _patients.FindOneAndDeleteAsync<PatientModel>(patient => patient._id == id);

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

        public async Task<ResponseModel<IEnumerable<PatientModel>>> GetAllPatients(int skip, int take)
        {

            try
            {
                var data =await _patients.Find<PatientModel>(Patient => true).SortBy(patient => patient._id).Skip(skip).Limit(take).ToListAsync<PatientModel>();
                
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

        public async Task<ResponseModel<PatientModel>> GetPatient(long id)
        {

            try
            {
                var data = await _patients.Find<PatientModel>(patient => patient._id == id).SingleAsync<PatientModel>();
    
                return new ResponseModel<PatientModel>()
                {
                    Result =  data,
                    HasError = false
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResponseModel<bool>> UpdatePatient(PatientModel patient)
        {
            try
            {
                var res =await _patients.FindOneAndReplaceAsync<PatientModel>(p => p._id == patient._id, patient);

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
    }
}
