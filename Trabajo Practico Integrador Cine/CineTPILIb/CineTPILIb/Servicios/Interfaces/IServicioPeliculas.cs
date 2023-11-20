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

        public List<Pelicula> GetPeliculas();
        Pelicula GetPeliculaById(int id);
        List<Pelicula> GetPeliculasConFiltro(int id_genero, int id_idioma, string sinopsis, string titulo);
        bool AltaPelicula(Pelicula nueva);
        bool ModificarPelicula(Pelicula pelicula);
        bool BajaPelicula(int id);
    }
}
