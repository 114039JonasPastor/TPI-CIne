using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
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
        List<TicketDTO> GetTicketPorFiltros(int id, DateTime fecha, string cliente);
        List<Cliente> GetClientes();
        bool NuevoTicket(Ticket nuevo);
        bool BajaTicket(int id);
    }
}
