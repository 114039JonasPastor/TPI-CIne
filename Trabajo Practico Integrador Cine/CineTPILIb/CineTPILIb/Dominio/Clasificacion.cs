using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class Clasificacion
    {
        private int nro;
        private string? nombre;

        public int IdClasificacion {  get; set; }
        public string ClasificacionName { get; set; }

        public Clasificacion()
        {
            
        }

        public Clasificacion(int nro, string? nombre)
        {
            this.nro = nro;
            this.nombre = nombre;
        }
    }
}
