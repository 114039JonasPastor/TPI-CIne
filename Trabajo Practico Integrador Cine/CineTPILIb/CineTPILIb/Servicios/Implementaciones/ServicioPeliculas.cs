using CineTPILIb.Data.Implementaciones;
using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Servicios.Implementaciones
{
    public class ServicioPeliculas : IServicioPeliculas
    {
        private IPeliculasDao dao;

        public ServicioPeliculas()
        {
            dao = new PeliculasDao();
        }

        public bool AltaPelicula(Pelicula nueva)
        {
            return dao.AltaPelicula(nueva);
        }

        public List<Pelicula> GetPeliculas(string titulo, int duracion, int id_genero, int id_idioma)
        {
            return dao.GetPeliculas(titulo, duracion, id_genero, id_idioma);
        }

        public bool ModificarPelicula(Pelicula pelicula)
        {
            return dao.ModificarPelicula(pelicula);
        }
    }
}
