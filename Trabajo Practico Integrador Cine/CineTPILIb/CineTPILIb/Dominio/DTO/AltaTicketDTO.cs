using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio.DTO
{
    public class AltaTicketDTO
    {
        public int NroFuncion { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Butaca { get; set; }
        public double PrecioVenta { get; set; }
        public string MedioDeVenta { get; set; }
        public string FormaDePago { get; set; }
        public int Descuento { get; set; }
    }
}
