using HospitalDataModel.Model;

namespace HospitalServiceApi.IServices
{
    public interface IPatientService
    {
        List<Patient> GetPatients();
    }
}
