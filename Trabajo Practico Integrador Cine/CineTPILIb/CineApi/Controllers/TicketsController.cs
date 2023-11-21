using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
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

        [HttpGet("/Clientes")]
        public IActionResult GetGeneros()
        {
            try
            {
                return Ok(app.GetClientes());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/TicketsFiltro")]
        public IActionResult GetTicketPorFiltros(DateTime fecha, string cliente, int id)
        {
            List<TicketDTO> lst = null;
            try
            {
                return Ok(app.GetTicketPorFiltros(id, fecha, cliente));

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/Tickets")]
        public IActionResult GetTickets(DateTime desde, DateTime hasta, string? cliente = null, 
                                        string? empleado= null, string? pelicula = null)
        {
            List<Ticket> lst = null;
            try
            {
                //Si el parámetro cliente no se envía entonces cliente es igual a null
                //Para evitar un error de parámetro requerido se inicializa con una cadena vacía
                cliente = cliente != null ? cliente : String.Empty;
                empleado = empleado != null ? empleado : String.Empty;
                pelicula = pelicula != null ? pelicula : String.Empty;
                lst = app.GetTicket(desde, hasta, cliente, empleado, pelicula);
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }



        [HttpGet("/Tickets/{id}")]
        public IActionResult GetTicketsById(int id)
        {
            try
            {
                Ticket ticket = app.GetTicketById(id);
                if (ticket != null)
                    return Ok(ticket);
                else
                    return NotFound("Presupuesto Nro: " + id + " NO encontrado!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


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
