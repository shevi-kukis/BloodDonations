using blood_donations.Subjects;
using BloodDanations.Core.IcoinService;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BloodDonations.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        readonly IDonorService _donorService;

        public DonorController(IDonorService donorService)
        {
            _donorService = donorService;
        }

        // GET: api/<DonorsController>
        [HttpGet]
        public ActionResult<List<Donor>> Get()
        {
            List<Donor> result = _donorService.GetServies();
            return result;
        }
        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Donor> Get(int id)
        {

            Donor result = _donorService.GetByIdService(id);
            if (result == null)
            { return NotFound(); }
            return Ok(result);
        }
        // POST api/<DonorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Donor value)
        {
            Donor result = _donorService.PostServies(value);
            if (result != null)
                return true;
                return BadRequest(value);
          
        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public ActionResult<Donor> Put(int id, [FromBody] Donor value)
        {
        return _donorService.PutServies(id, value);
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _donorService.DeleteServies(id);
        }
    }
}
