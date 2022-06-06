using Xunit;
using HospiotalServiceHub.IServices;
using HospiotalServiceHub;
using MongoDB.Driver;
using HospitalDataModel.ViewModel;

namespace TestProject
{
    public class firstTest
    {
        private readonly IPatientService patientService;
        public firstTest(IPatientService ipatientService)
        {
            patientService = ipatientService;
        }

        [Fact]
        public void getTest()
        {
            bool result = patientService.isEven(3);

            Assert.False(result,"3 is not be even");
        }
    }
}
