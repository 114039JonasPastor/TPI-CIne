using CineTPILIb.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Data.Interfaces
{
    public interface ITicketsDao
    {
        List<Ticket> ObtenerTicketsPorFiltros(DateTime desde, DateTime hasta, string cliente, string pelicula, string empleado);
        Ticket ObtenerTicketById(int id);
        
        bool NuevoTicket(Ticket nuevo);
        bool BajaTicket(int id);
    }
}
