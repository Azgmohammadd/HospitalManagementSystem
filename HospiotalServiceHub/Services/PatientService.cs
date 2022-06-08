using HospiotalServiceHub.IServices;
using HospitalDataModel.ViewModel;
using MongoDB.Driver;

namespace HospiotalServiceHub.Services
{
    public class PatientService : IPatientService
    {
        private readonly IMongoCollection<PatientViewModel> _patients;

        public PatientService(IDbClient dbClient)
        {
            _patients = dbClient.GetDatabase().GetCollection<PatientViewModel>("Patients");
        }



        public async Task<bool> CreatePatient(PatientViewModel patient)
        {
            try
            {
                 await _patients.InsertOneAsync(patient);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeletePatient(long id)
        {
            try
            {
                var data = await _patients.FindOneAndDeleteAsync<PatientViewModel>(patient => patient._id == id);

                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<PatientViewModel>> GetAllPatients(int skip, int take)
        {

            try
            {
                var data =await _patients.Find<PatientViewModel>(Patient => true).SortBy(patient => patient._id).Skip(skip).Limit(take).ToListAsync<PatientViewModel>();

                return data;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<PatientViewModel> GetPatient(long id)
        {

            try
            {
                var data = await _patients.Find<PatientViewModel>(patient => patient._id == id).SingleAsync<PatientViewModel>();

                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdatePatient(PatientViewModel patient)
        {
            try
            {
                var result =await _patients.FindOneAndReplaceAsync<PatientViewModel>(p => p._id == patient._id, patient);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }



        //add for testing
        public bool IsEven(int n)
        {
            try
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        } 
    }
}
