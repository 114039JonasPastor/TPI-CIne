using CineTPILIb.Dominio;
using CineTPILIb.Servicios.Implementaciones;
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

        public PeliculasController()
        {
            app = new ServicioPeliculas();
        }

        [HttpGet("/clasificaciones")]
        public IActionResult GetClasificaciones()
        {
            try
            {
                return Ok(app.GetClasificaciones());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/idiomas")]
        public IActionResult GetIdiomas()
        {
            try
            {
                return Ok(app.GetIdiomas());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/generos")]
        public IActionResult GetGeneros()
        {
            try
            {
                return Ok(app.GetGeneros());

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        // GET: api/<PeliculasController>
        [HttpGet]
        public IActionResult GetPeliculas()
        {
            try
            {
                return Ok(app.GetPeliculas());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetPeliculaPorId(int id)
        {
            try
            {
                Pelicula p = app.GetPeliculaById(id);
                if (p != null)
                    return Ok(p);
                else
                    return NotFound("Pelicula id: " + id + " NO encontrada!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }



        // GET api/<PeliculasController>/5
        [HttpGet("/peliculas")]
        public IActionResult GetPeliculasConFiltro(int id_genero, int id_idioma, string? sinopsis = null, string? titulo = null)
        {
            List<Pelicula> lst = null;
            try
            {
                titulo = titulo != null ? titulo : String.Empty;
                sinopsis = sinopsis != null ? sinopsis : String.Empty;
                return Ok(app.GetPeliculasConFiltro(id_genero, id_idioma, sinopsis, titulo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        // POST api/<PeliculasController>
        [HttpPost]
        public IActionResult GuardarPelicula([FromBody] Pelicula nueva)
        {
            try
            {
                if (nueva == null)
                {
                    return BadRequest();
                }
                return Ok(app.AltaPelicula(nueva));
            }
            catch (Exception ex)
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
        public IActionResult BorrarPelicula(int id)
        {
            try
            {
                return Ok(app.BajaPelicula(id));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
