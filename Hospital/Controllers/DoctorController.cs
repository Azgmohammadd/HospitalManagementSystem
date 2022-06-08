using HospiotalServiceHub.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
 //   [Route("api/[controller]")]
   // [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _idoctorService;

        public DoctorController(IDoctorService idoctorService)
        {
            _idoctorService = idoctorService;
        }

        [HttpGet]
        public IActionResult GetPatients()
        {
            return Ok(_idoctorService.GetAllDoctors());
        }
    }
}
