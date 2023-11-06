using CineTPILIb.Dominio;
using CineTPILIb.Servicios.Implementaciones;
using CineTPILIb.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private IServicioTickets app;

        public TicketsController()
        {
            app = new ServicioTickets();
        }

        //// GET: api/<TicketsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<TicketsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<TicketsController>
        [HttpPost]
        public IActionResult Post([FromBody] Ticket nuevo)
        {
            try
            {
                if (nuevo == null)
                {
                    return NotFound();
                }
                return Ok(app.NuevoTicket(nuevo));
            }
            catch
            {
                return BadRequest();
            }
        }

        //// PUT api/<TicketsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<TicketsController>/5
        [HttpDelete("{id}")]
        public IActionResult BajaTicket(int id)
        {
            try
            {
                return Ok(app.BajaTicket(id));
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
