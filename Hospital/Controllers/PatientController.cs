using Microsoft.AspNetCore.Mvc;
using HospiotalServiceHub.IServices;
using HospitalDataModel.Model;

namespace Hospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _ipatientService;
        public PatientController(IPatientService ipatientService)
        {
            _ipatientService = ipatientService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = _ipatientService.GetAllPatients();
                return Ok(result);

            }catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PatientModel patientModel)
        {
            try
            {
                var result = _ipatientService.CreatePatient(patientModel);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}