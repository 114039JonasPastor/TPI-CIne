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

        public List<MedioDeVenta> GetMedioDeVenta()
        {
            return dao.GetMedioDeVenta();
        }

        public List<FormaDePago> GetFormaDePagos()
        {
            return dao.GetFormaDePagos();
        }

        public List<Promocion> GetPromociones()
        {
            return dao.GetPromociones();
        }

        public List<Butaca> GetButacas()
        {
            return dao.GetButacas();
        }

        public List<Funcion> GetFunciones()
        {
            return dao.GetFunciones();
        }

        public int ObtenerProximoNro()
        {
            return dao.ObtenerProximoNro();
        }
    }
}
