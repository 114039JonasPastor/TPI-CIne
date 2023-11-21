using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class DetalleTicket
    {
        private decimal precio_venta;

        public int Id_detalle { get; set; }
        public Funcion Funcion { get; set; }
        public int Id_butaca { get; set; }
        public decimal Precio_venta { get; set; }

        //public Butaca Butaca { get; set; }

        public DetalleTicket(/*int id_detalle, */Funcion funcion, int id_butaca, decimal precio_venta)
        {
            //Id_detalle = id_detalle;
            Funcion = funcion;
            Id_butaca = id_butaca;
            Precio_venta = precio_venta;
        }

        public DetalleTicket(/*Butaca butaca,*/ decimal precio_venta)
        {
            //Butaca = butaca;
            Precio_venta = precio_venta;
        }
    }
}
