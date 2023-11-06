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
        public double Total { get; set; }
        public bool Estado { get; set; }
        public List<DetallesTicket> DetallesTicket { get; set; }

        public Ticket()
        {
            DetallesTicket = new List<DetallesTicket>();
        }

        public void AgregarDetalles(DetallesTicket detalle)
        {
            DetallesTicket.Add(detalle);
        }
        public void RemoverDetalles(int id)
        {
            DetallesTicket.RemoveAt(id);
        }
    }
}
