using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class DetallesTicket
    {
        public int Id_detalle { get; set; }
        public Funcion Funcion { get; set; }
        public int Id_butaca { get; set; }
        public double Precio_venta { get; set; }

        public DetallesTicket(int id_detalle, Funcion funcion, int id_butaca, double precio_venta)
        {
            Id_detalle = id_detalle;
            Funcion = funcion;
            Id_butaca = id_butaca;
            Precio_venta = precio_venta;
        }
    }
}
