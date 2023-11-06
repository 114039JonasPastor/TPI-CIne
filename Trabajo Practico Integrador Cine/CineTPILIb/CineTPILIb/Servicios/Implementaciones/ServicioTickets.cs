using CineTPILIb.Data.Implementaciones;
using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Servicios.Implementaciones
{
    public class ServicioTickets : IServicioTickets
    {
        private ITicketsDao dao;

        public ServicioTickets()
        {
            dao = new TicketsDao();
        }
        public bool BajaTicket(int id)
        {
            return dao.BajaTicket(id);
        }

        public bool NuevoTicket(Ticket nuevo)
        {
            return dao.NuevoTicket(nuevo);
        }
    }
}
