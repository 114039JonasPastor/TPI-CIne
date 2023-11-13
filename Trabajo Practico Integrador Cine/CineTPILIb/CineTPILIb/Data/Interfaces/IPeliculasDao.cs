using CineTPILIb.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Data.Interfaces
{
    public interface IPeliculasDao
    {
        List<Pelicula> GetPeliculas(string titulo, int duracion, int id_genero, int id_idioma);
        bool AltaPelicula(Pelicula nueva);
        bool ModificarPelicula(Pelicula pelicula);
    }
}
