using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Data.Interfaces
{
    public interface IPeliculasDao
    {
        List<Clasificacion> GetClasificaciones();
        List<Idioma> GetIdiomas();
        List<Genero> GetGeneros();

        List<Pelicula> GetPeliculas();
        List<Pelicula> GetPeliculasConFiltro(int id_genero, int id_idioma, string sinopsis, string titulo);
        bool AltaPelicula(Pelicula nueva);
        bool ModificarPelicula(Pelicula pelicula);
        bool BajaPelicula(int id);
        Pelicula PeliculaPorID(int id);
    }
}
