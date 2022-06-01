using HospitalDataModel.Model;
using SharedStorage.Models;

namespace HospiotalServiceHub.IServices
{
    public interface IPatientService
    {
        Task<ResponseModel<IEnumerable<PatientModel>>> GetAllPatients();

        Task<ResponseModel<PatientModel>> GetPatient(string id);

        Task<ResponseModel<bool>> CreatePatient(PatientModel patient);

        Task<ResponseModel<bool>> DeletePatient(string id);
    }
}
