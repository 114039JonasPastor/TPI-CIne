using CineTPILIb.Dominio;
using CineTPILIb.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private IServicioPeliculas app;

        // GET: api/<PeliculasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PeliculasController>/5
        [HttpGet("{titulo},{duracion},{id_genero},{id_idioma}")]
        public IActionResult GetPeliculas(string titulo, int duracion, int id_genero, int id_idioma)
        {
            try
            {
                return Ok(app.GetPeliculas(titulo, duracion, id_genero, id_idioma));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<PeliculasController>
        [HttpPost]
        public IActionResult GuardarPelicula([FromBody] Pelicula  nueva)
        {
            try
            {
                if (nueva == null)
                {
                    return BadRequest();
                }
                return Ok(app.AltaPelicula(nueva));
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<PeliculasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Pelicula pelicula)
        {
            try
            {
                if (pelicula == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(app.ModificarPelicula(pelicula));
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // DELETE api/<PeliculasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
