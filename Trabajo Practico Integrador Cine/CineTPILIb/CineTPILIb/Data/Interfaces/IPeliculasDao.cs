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
        List<PeliculaDTO> GetPeliculasConFiltro(string titulo, int duracion, int id_genero, int id_idioma);
        List<PeliculaDTO> GetPeliculas();
        bool AltaPelicula(Pelicula nueva);
        bool ModificarPelicula(Pelicula pelicula);
    }
}
