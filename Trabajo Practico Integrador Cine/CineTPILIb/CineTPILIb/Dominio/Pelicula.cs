using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class Pelicula
    {
        public int Id_pelicula { get; set; }
        public string? Titulo { get; set; }
        public int Duracion { get; set; }
        public string? Sinopsis { get; set; }

        public Clasificacion Clasificacion { get; set; }
        public Genero Genero { get; set; }
        public Idioma Idioma { get; set; }


        public Pelicula(Genero genero, Clasificacion clasificacion, Idioma oIdioma)
        {
            Genero = genero;
            Idioma = oIdioma;
            Clasificacion = clasificacion;
        }

        public Pelicula() { }

    }
}
