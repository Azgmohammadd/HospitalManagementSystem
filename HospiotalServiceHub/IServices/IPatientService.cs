using HospitalDataModel.ViewModel;

namespace HospiotalServiceHub.IServices
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientViewModel>> GetAllPatients(int skip, int take);

        Task<PatientViewModel> GetPatient(long id); 

         Task<bool> CreatePatient(PatientViewModel patient);

        Task<bool> DeletePatient(long id);

        Task<bool> UpdatePatient(PatientViewModel patient);

        //add for test
        bool IsEven(int number);
    }
}
