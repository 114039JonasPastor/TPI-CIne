using CineTPILIb.Data.Implementaciones;
using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using CineTPILIb.Servicios.Interfaces;

namespace CineTPILIb.Servicios.Implementaciones
{
    public class ServicioTickets : IServicioTickets
    {
        private ITicketsDao dao;

        public ServicioTickets()
        {
            dao = new TicketsDao();
        }

        public List<Ticket> GetTicket(DateTime desde, DateTime hasta, string cliente, string empleado, string pelicula)
        {
            return dao.ObtenerTicketsPorFiltros(desde, hasta, cliente, pelicula, empleado);
        }

        public Ticket GetTicketById(int id)
        {
            return dao.ObtenerTicketById(id);
        }

        public bool NuevoTicket(Ticket nuevo)
        {
            return dao.NuevoTicket(nuevo);
        }

        public bool BajaTicket(int id)
        {
            return dao.BajaTicket(id);
        }

        public List<Cliente> GetClientes()
        {
            return dao.GetClientes();
        }

        List<TicketDTO> IServicioTickets.GetTicketPorFiltros(int id, DateTime fecha, string cliente)
        {
            return dao.GetTicketPorFiltros(id, fecha, cliente);
        }
    }
}
