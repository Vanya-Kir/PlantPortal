using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Device;
using Device.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlantPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LightController : ControllerBase
    {
        // GET: api/<ApiController>
        [HttpGet]
        public Temperature Get()
        {
            return new Temperature { Id = 1, Date = DateTime.Now, Degrees = 32.5 , User = "123435"};
        }

        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        public string? Get(int id)
        {
            var u = User.FindFirstValue((ClaimTypes.NameIdentifier));
            return u;
        }

        // POST api/<ApiController>
        [HttpPost]
        public void Post(TemeratureDto value)
        {
            ;
        }

        // PUT api/<ApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
