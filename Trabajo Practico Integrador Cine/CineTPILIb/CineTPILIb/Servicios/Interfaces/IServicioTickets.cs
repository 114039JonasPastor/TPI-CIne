using CineTPILIb.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Servicios.Interfaces
{
    public interface IServicioTickets
    {

        public List<Ticket> GetTicket(DateTime desde, DateTime hasta, string nombre, string empleado, string pelicula);
        bool NuevoTicket(Ticket nuevo);
        bool BajaTicket(int id);
        Ticket GetTicketById(int id);
    }
}
