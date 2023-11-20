using CineTPILIb.Data.Implementaciones;
using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
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

        public bool BajaPelicula(int id)
        {
            return dao.BajaPelicula(id);
        }

        public List<Clasificacion> GetClasificaciones()
        {
            return dao.GetClasificaciones();
        }

        public List<Genero> GetGeneros()
        {
            return dao.GetGeneros();
        }

        public List<Idioma> GetIdiomas()
        {
            return dao.GetIdiomas();
        }

        public Pelicula GetPeliculaById(int id)
        {
            return dao.PeliculaPorID(id);
        }

        public List<Pelicula> GetPeliculas()
        {
            return dao.GetPeliculas();
        }

        public List<Pelicula> GetPeliculasConFiltro(int id_genero, int id_idioma, string sinopsis, string titulo)
        {
            return dao.GetPeliculasConFiltro(id_genero, id_idioma, sinopsis, titulo);
        }

        public bool ModificarPelicula(Pelicula pelicula)
        {
            return dao.ModificarPelicula(pelicula);
        }
    }
}
