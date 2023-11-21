using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio.DTO
{
    public class FuncionDTO
    {
        public int ID { get; set; }
        public string Pelicula { get; set; }
        public int Sala { get; set; }
        public string TipoSala { get; set; }
        public string Horario { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public double Precio { get; set; }
    }
}
