using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class Ticket
    {
        public int Id_ticket { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_cliente { get; set; }
        public int Id_medio_pedido { get; set; }
        public int Id_promocion { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }
        public int Id_forma_pago { get; set; }
        public List<DetalleTicket> DetallesTicket { get; set; }

        public Ticket()
        {
            DetallesTicket = new List<DetalleTicket>();
        }

        public void AgregarDetalle(DetalleTicket detalle)
        {
            DetallesTicket.Add(detalle);
        }
        public void RemoverDetalle(int id)
        {
            DetallesTicket.RemoveAt(id);
        }
    }
}
