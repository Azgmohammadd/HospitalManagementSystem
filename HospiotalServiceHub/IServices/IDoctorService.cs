using HospitalDataModel.Model;

namespace HospiotalServiceHub.IServices
{
    public interface IDoctorService
    {
        List<DoctorModel> GetAllDoctors();
    }
}
