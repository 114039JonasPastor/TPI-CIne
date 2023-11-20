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

        // GET: api/<FuncionesController>
        [HttpGet]
        public IActionResult GetFunciones()
        {
            try
            {
                return Ok(app.ObtenerFunciones());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet("/peliculas")]
        public IActionResult GetClasificaciones()
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

        [HttpGet("/salas")]
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

        [HttpGet("/horarios")]
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


        // GET api/<FuncionesController>/5
        [HttpGet("/Funciones")]
        public IActionResult Get(DateTime desde, DateTime hasta, string pelicula)
        {
            List<FuncionDTO> lista = null;

            try
            {
                lista = app.GetFuncionesFiltros(desde,hasta,pelicula);
                return Ok(lista);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }


        //// GET api/<FuncionesController>/5
        //[HttpGet("{id},{desde},{hasta}")]
        //public IActionResult Get(int id, DateTime desde, DateTime hasta)
        //{
        //    try
        //    {
        //        return Ok(app.GetFuncionesFiltros(id, desde, hasta));
        //    }
        //    catch(Exception ex)
        //    {
        //        return BadRequest(ex.ToString());
        //    }
        //}

        // POST api/<FuncionesController>
        [HttpPost]
        public IActionResult GuardarFuncion([FromBody] Funcion funcion)
        {
            try
            {
                if(funcion == null)
                {
                    return BadRequest();
                }
                return Ok(app.AltaFuncion(funcion));
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<FuncionesController>/5
        [HttpPut("{id}")]
        public IActionResult EditarFuncion(int id, [FromBody] Funcion funcion)
        {
            try
            {
                if(funcion == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(app.ModificarFuncion(id, funcion));
                }
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
