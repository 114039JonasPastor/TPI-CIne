using CineTPILIb.Dominio;
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






        // GET api/<FuncionesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

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
                    return Ok(app.ModificarFuncion(funcion));
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
