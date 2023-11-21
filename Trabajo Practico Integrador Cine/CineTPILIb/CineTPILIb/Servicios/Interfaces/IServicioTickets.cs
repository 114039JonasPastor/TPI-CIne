using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
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

        List<Cliente> GetClientes();
        List<TicketDTO> GetTicketPorFiltros(int id, DateTime fecha, string cliente);
    }
}
