using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Servicios.Interfaces
{
    public interface IServicioPeliculas
    {
        List<Clasificacion> GetClasificaciones();
        List<Idioma> GetIdiomas();
        List<Genero> GetGeneros();

        List<PeliculaDTO> GetPeliculasConFiltro(string titulo, int duracion, int id_genero, int id_idioma);
        bool AltaPelicula(Pelicula nueva);
        bool ModificarPelicula(Pelicula pelicula);
        public List<PeliculaDTO> GetPeliculas();
    }
}
