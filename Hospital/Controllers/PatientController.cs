using Microsoft.AspNetCore.Mvc;
using HospiotalServiceHub.IServices;
using HospitalDataModel.ViewModel;
using SharedStorage.Extensions;
using SharedStorage.Models;
using Microsoft.AspNetCore.Cors;

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
        [EnableCors("MyPolicy")]
        public async Task<IActionResult> Get(int skip, int take)
        {
            try
            {
                var result =await _ipatientService.GetAllPatients(skip, take);

                var response = new ResponseModel<IEnumerable<PatientViewModel>>()
                {
                    Result = result,
                    HasError = false,
                    Message = null
                };

                return Ok(response);

            }catch(Exception e)
            {
                var error = new ResponseModel<bool>().GetErrorResponseToString(e);

                return Problem(error);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var result =await _ipatientService.GetPatient(id);
             
                var response = new ResponseModel<PatientViewModel>()
                {
                    Result = result,
                    HasError = false,
                    Message = null
                };
                return Ok(response);

            }
            catch (Exception e)
            {
                var error = new ResponseModel<bool>().GetErrorResponseToString(e);

                return Problem(error);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PatientViewModel patientModel)
        {
            try
            {
                var result = await _ipatientService.CreatePatient(patientModel);
                
                var response = new ResponseModel<bool>()
                {
                    Result = result,
                    HasError = false,
                    Message = null,
                };

                return Ok(response);
            }
            catch(Exception e)
            {
                var error = new ResponseModel<bool>().GetErrorResponseToString(e);

                return Problem(error);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] long id)
        {
            try
            {
                var result = _ipatientService.DeletePatient(id);
               
                var response = new ResponseModel<bool>()
                {
                    Result = await result,
                    HasError = false,
                    Message = null,
                };

                return Ok(response);
            }
            catch(Exception e)
            {
                var error = new ResponseModel<bool>().GetErrorResponseToString(e);

                return Problem(error);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PatientViewModel patientModel)
        {
            try
            {
                var result = _ipatientService.UpdatePatient(patientModel);
                
                var response = new ResponseModel<bool>()
                {
                    Result = await result,
                    HasError = false,
                    Message = null,
                };

                return Ok(response);
            }
            catch(Exception e)
            {
                var error = new ResponseModel<bool>().GetErrorResponseToString(e);

                return Problem(error);
            }
        }

    }
}