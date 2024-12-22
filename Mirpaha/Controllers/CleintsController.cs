using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleintsController : ControllerBase
    {
        // GET: api/<CleintsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CleintsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CleintsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CleintsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CleintsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
