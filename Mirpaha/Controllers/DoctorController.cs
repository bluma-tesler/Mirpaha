using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mirpaha.Entities;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class doctorController : ControllerBase
    {
        private readonly IDataContext _dataContext;
        //private static List<Doctor> doctors = new List<Doctor> { new Doctor ()};
        public doctorController(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

       

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _dataContext.Doctors;
        }

        // GET api/<Doctor>/5
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return _dataContext.Doctors.Find(e => e.Id == id);
        }

        // POST api/<Doctor>
        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
            doctor.Id = _dataContext.Doctors.Any() ? _dataContext.Doctors.Max(e => e.Id) + 1 : 1;
            _dataContext.Doctors.Add(doctor);
        }

        // PUT api/<Doctor>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor doctor)
        {
            Doctor doctorToUpdate= _dataContext.Doctors.Find(e=>e.Id == id);
            if(doctorToUpdate != null)
            {
                doctorToUpdate.Name =doctor.Name;  
            }

        }

        // DELETE api/<Doctor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Doctor doctorToUpdate = _dataContext.Doctors.Find(e => e.Id == id);
            if (doctorToUpdate != null)
            {
                _dataContext.Doctors.RemoveAt(doctorToUpdate.Id-1);
            }

        }
    }
}
