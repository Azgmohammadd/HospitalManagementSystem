using Xunit;
using HospiotalServiceHub.IServices;
using Hospital.Controllers;
using HospiotalServiceHub;
using MongoDB.Driver;
using HospitalDataModel.ViewModel;
using HospiotalServiceHub.Services;
using Moq;
using SharedStorage.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestProject
{
    public class ContollerTest
    {
        PatientViewModel model = new PatientViewModel()
        {
            firstName = "fn",
            lastName = "ln"
        };

        private readonly Mock<IPatientService> patientService;
        
        private readonly PatientController patientController;

        public ContollerTest()
        {
            patientService = new Mock<IPatientService>();

            patientController = new PatientController(patientService.Object);
        }

        [Fact]
        public async void DeleteTest1()
        {
            var cpmpared = await patientController.Delete(1);

            Assert.IsType<OkObjectResult>(cpmpared);
        }

        [Fact]
        public async void GetTest1()
        {
            var cpmpared = await patientController.Get(1);

            Assert.IsType<OkObjectResult>(cpmpared);
        }
        [Fact]
        public async void GetAllTest1()
        {
            var cpmpared = await patientController.Get(1, 4);

            Assert.IsType<OkObjectResult>(cpmpared);
        }

        [Fact]
        public async void CreateTest1()
        {
            var cpmpared = await patientController.Post(model);

            Assert.IsType<OkObjectResult>(cpmpared);
        }

        [Fact]
        public async void UpdateTest1()
        {
            var cpmpared = await patientController.Put(model);

            Assert.IsType<OkObjectResult>(cpmpared);
        }
    }
}
