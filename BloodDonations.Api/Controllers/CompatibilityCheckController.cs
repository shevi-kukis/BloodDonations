using blood_donations.Entities;

using BloodDanations.Core.InterfaceRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompatibilityCheckController : ControllerBase
    {
        readonly ICompatibilityCheckService _compatibilityCheckService;
        public CompatibilityCheckController(ICompatibilityCheckService Service)
        {
            _compatibilityCheckService = Service;
        }

        // GET: api/<CompatibilityCheckController>
        [HttpGet]
        public ActionResult<List<CompatibilityCheck>> Get()
        {
            return Ok(_compatibilityCheckService.GetServies());
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public ActionResult<CompatibilityCheck> Get(int id)
        {
            CompatibilityCheck result = _compatibilityCheckService.GetByIdService(id);
            if (result == null)
            { return NotFound(); }
            return Ok(result);
        }

        // POST api/<Users>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] CompatibilityCheck c)
        {
            CompatibilityCheck result = _compatibilityCheckService.PostServies(c);
            if (result != null)
                return true;
            return BadRequest(c);
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult<CompatibilityCheck> Put(int id,CompatibilityCheck c)
        {
            return _compatibilityCheckService.PutServies(id, c);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _compatibilityCheckService.DeleteServies(id);
        }
    }
}
