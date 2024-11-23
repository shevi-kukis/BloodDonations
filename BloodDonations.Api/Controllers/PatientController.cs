using blood_donations.Entities;
using blood_donations.Servies;
using blood_donations.Subjects;
using BloodDanations.Core.IcoinService;
using BloodDanations.Core.InterfaceRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        readonly IPatientService _patientService;
        // GET: api/<DonorsController>
       
        public PatientController(IPatientService Service)
        {
            _patientService = Service;
        }
        [HttpGet]
        public ActionResult<List<Patient>> Get()
        {
            return Ok(_patientService.GetServies());
        }
        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Patient> Get(int id)
        {
            Patient result = _patientService.GetByIdService(id);
            if (result == null)
            { return NotFound(); }
            return Ok(result);
        }
        // POST api/<DonorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Patient value)
        {
            return _patientService.PostServies(value);
        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,[FromBody] Patient value)
        {
            return _patientService.PutServies(id,value);
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _patientService.DeleteServies(id);
        }
    }
}
