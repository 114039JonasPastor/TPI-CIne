using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class DetalleTicket
    {
        public Funcion Funcion { get; set; }
        public int Id_butaca { get; set; }
        public decimal Precio_venta { get; set; }

        public DetalleTicket(Funcion funcion, int id_butaca, decimal precio_venta)
        {
            Funcion = funcion;
            Id_butaca = id_butaca;
            Precio_venta = precio_venta;
        }
    }
}
