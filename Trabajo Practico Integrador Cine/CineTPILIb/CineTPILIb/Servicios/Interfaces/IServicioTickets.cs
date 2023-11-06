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
        bool NuevoTicket(Ticket nuevo);
        bool BajaTicket(int id);
    }
}
