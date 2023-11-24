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
        public IActionResult GetClientes()
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

        [HttpGet("/Butacas")]
        public IActionResult GetButacas()
        {
            try
            {
                return Ok(app.GetButacas());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/Combo Funciones")]
        public IActionResult GetFunciones()
        {
            try
            {
                return Ok(app.GetFunciones());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpGet("/Promociones")]
        public IActionResult GetPromociones()
        {
            try
            {
                return Ok(app.GetPromociones());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/Formas de pago")]
        public IActionResult GetFormasDePago()
        {
            try
            {
                return Ok(app.GetFormaDePagos());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/Medio de venta")]
        public IActionResult GetMediosDeVenta()
        {
            try
            {
                return Ok(app.GetMedioDeVenta());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/TicketsFiltro")]
        public IActionResult GetTicketPorFiltros(DateTime fecha, int id, string? cliente = null)
        {
            List<TicketDTO> lst = null;
            try
            {
                cliente = cliente != null ? cliente : String.Empty;
                return Ok(app.GetTicketPorFiltros(id, fecha, cliente));

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
