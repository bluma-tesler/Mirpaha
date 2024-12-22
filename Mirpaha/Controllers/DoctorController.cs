using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mirpaha.Entities;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private static List<Doctor> doctors = new List<Doctor> { new Doctor ()};

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return doctors;
        }

        // GET api/<Doctor>/5
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return doctors.Find(e => e.Id == id);
        }

        // POST api/<Doctor>
        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
          doctors.Add(doctor);
        }

        // PUT api/<Doctor>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor doctor)
        {
            Doctor doctorToUpdate=doctors.Find(e=>e.Id == id);
            if(doctorToUpdate != null)
            {
                doctorToUpdate.Name =doctor.Name;  
            }

        }

        // DELETE api/<Doctor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Doctor doctorToUpdate = doctors.Find(e => e.Id == id);
            if (doctorToUpdate != null)
            {
                doctors.RemoveAt(doctorToUpdate.Id-1);
            }

        }
    }
}
