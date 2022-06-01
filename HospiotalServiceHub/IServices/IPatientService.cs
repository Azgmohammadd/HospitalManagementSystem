using HospitalDataModel.Model;
using SharedStorage.Models;

namespace HospiotalServiceHub.IServices
{
    public interface IPatientService
    {
        Task<ResponseModel<IEnumerable<PatientModel>>> GetAllPatients();

        Task<ResponseModel<bool>> CreatePatient(PatientModel patient);
    }
}
