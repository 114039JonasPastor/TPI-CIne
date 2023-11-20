using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio.DTO
{
    public class PeliculaDTO
    {
        public int IdPelicula { get; set; }
        public string? Titulo { get; set; }
        public int Duracion { get; set; }
        public string? Clasificacion { get; set; }
        public string? Genero { get; set; }
        public string? Idioma { get; set; }
        public bool Estado { get; set; }

    }
}
