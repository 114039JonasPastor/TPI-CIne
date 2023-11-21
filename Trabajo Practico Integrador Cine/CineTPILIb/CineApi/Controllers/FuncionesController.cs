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
    public class FuncionesController : ControllerBase
    {
        private IServicioFunciones app;

        public FuncionesController()
        {
            app = new ServicioFunciones();
        }


        [HttpGet("/Combo Horarios")]
        public IActionResult GetGeneros()
        {
            try
            {
                return Ok(app.GetHorarios());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/Combo Peliculas")]
        public IActionResult GetPeliculas()
        {
            try
            {
                return Ok(app.GetPeliculaList());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/Combo Salas")]
        public IActionResult GetIdiomas()
        {
            try
            {
                return Ok(app.GetSalas());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        // GET api/<FuncionesController>/5
        [HttpGet("/funciones")]
        public IActionResult GetFuncionesPorFiltro(DateTime desde, DateTime hasta, int id_funcion)
        {
            List<FuncionDTO> lst = null;
            try
            {
                return Ok(app.GetFuncionesFiltros(desde, hasta, id_funcion));

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        // GET: api/<FuncionesController>
        [HttpGet]
        public IActionResult GetFunciones()
        {
            try
            {
                return Ok(app.ObtenerFunciones());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        // GET api/<FuncionesController>/5
        [HttpGet("/funciones/{id}")]
        public IActionResult GetFuncionesPorId(int id)
        {
            try
            {
                return Ok(app.GetFuncionesPorId(id));

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        // POST api/<FuncionesController>
        [HttpPost]
        public IActionResult GuardarFuncion([FromBody] Funcion funcion)
        {
            try
            {
                if (funcion == null)
                {
                    return BadRequest();
                }
                return Ok(app.AltaFuncion(funcion));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        // PUT api/<FuncionesController>/5
        [HttpPut("{id}")]
        public IActionResult EditarFuncion(/*int id, */[FromBody] Funcion funcion)
        {
            try
            {
                if (funcion == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(app.ModificarFuncion(funcion));
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        // DELETE api/<FuncionesController>/5
        [HttpDelete("{id}")]
        public IActionResult BorrarFuncion(int id)
        {
            try
            {
                return Ok(app.BajaFuncion(id));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
