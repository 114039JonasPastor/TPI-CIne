using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class FormaDePago
    {
        public int IdFormaPago { get; set; }
        public string Descripcion { get; set; }
        public int Recargo { get; set; }
    }
}
