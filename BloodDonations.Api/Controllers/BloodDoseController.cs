using blood_donations.Entities;
using blood_donations.Servies;
using BloodDanations.Core.IcoinService;
using BloodDanations.Core.InterfaceRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodDoseController : ControllerBase
    {
        readonly IBloodDoseService _bloodDoseService;
        // GET: api/<BloodDoseController>
        public BloodDoseController(IBloodDoseService Service)
        {
            _bloodDoseService = Service;
        }

        [HttpGet]

        public ActionResult<List<BloodDose>> Get()
        {
            return Ok(_bloodDoseService.GetServies());
        }

        // GET api/<BloodDoseController>/5
        [HttpGet("{id}")]
       
        public ActionResult<BloodDose> Get(int id)
        {
            BloodDose result = _bloodDoseService.GetByIdService(id);
            if (result == null) 
            { return NotFound(); }
            return Ok(result);
        }

        // POST api/<BloodDoseController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] BloodDose value)
        {
            return Ok(_bloodDoseService.PostServies(value)) ;
        }

        // PUT api/<BloodDoseController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put( int id,[FromBody] BloodDose value)
        {
            return _bloodDoseService.PutServies(id, value);
        }

        // DELETE api/<BloodDoseController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
          return _bloodDoseService.DeleteServies(id) ;
        }
    }
}
