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

        [HttpGet("{skip}/{take}")]
        public async Task<IActionResult> Get(int skip, int take)
        {
            try
            {
                var result = _ipatientService.GetAllPatients(skip, take);
                return Ok(result);

            }catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var result = _ipatientService.GetPatient(id);
                return Ok(result);

            }
            catch (Exception e)
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

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] long id)
        {
            try
            {
                var result = _ipatientService.DeletePatient(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PatientModel patientModel)
        {
            try
            {
                var res = _ipatientService.UpdatePatient(patientModel);
                return Ok(res);
            }
            catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

    }
}