using HospitalDataModel.Model;
using HospitalDataModel.ViewModel;
using SharedStorage.Models;

namespace HospiotalServiceHub.IServices
{
    public interface IPatientService
    {
        //Task<ResponseModel<IEnumerable<PatientViewModel>>> GetAllPatients(int skip, int take);
        Task<IEnumerable<PatientViewModel>> GetAllPatients(int skip, int take);

        //Task<ResponseModel<PatientViewModel>> GetPatient(long id);
        Task<PatientViewModel> GetPatient(long id); 

         //Task<ResponseModel<bool>> CreatePatient(PatientViewModel patient);
         Task<bool> CreatePatient(PatientViewModel patient);

        //Task<ResponseModel<bool>> DeletePatient(long id);
        Task<bool> DeletePatient(long id);

        //Task<ResponseModel<bool>> UpdatePatient(PatientViewModel patient);
        Task<bool> UpdatePatient(PatientViewModel patient);

        bool isEven(int number);
    }
}
