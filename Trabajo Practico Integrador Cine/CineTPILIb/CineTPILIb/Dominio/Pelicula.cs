using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class Pelicula
    {
        public int Id_pelicula { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public string Sinopsis { get; set; }
        public int Id_clasificacion { get; set; }
        public int Id_genero { get; set; }
        public int Id_idioma { get; set; }

    }
}
