using HospitalDataModel.Model;
using SharedStorage.Models;

namespace HospiotalServiceHub.IServices
{
    public interface IPatientService
    {
        Task<ResponseModel<IEnumerable<PatientModel>>> GetAllPatients(int skip, int take);

        Task<ResponseModel<PatientModel>> GetPatient(long id);

        Task<ResponseModel<bool>> CreatePatient(PatientModel patient);

        Task<ResponseModel<bool>> DeletePatient(long id);

        Task<ResponseModel<bool>> UpdatePatient(PatientModel patient);
    }
}
