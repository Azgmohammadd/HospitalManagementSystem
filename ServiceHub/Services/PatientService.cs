using HospitalDataModel.Model;
using HospitalServiceApi.IServices;

namespace HospitalServiceApi
{
    public class PatientService : IPatientService
    {
        public List<Patient> GetPatients()
        {
            return new List<Patient>()
            {
                new Patient
                {
                    ID = 1,
                    Name= "Azg",
                    Age = 19,
                    Issue = "Cancer"
                }
            };
        }
    }
}
