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
        int ObtenerProximoNro();
        bool NuevoTicket(Ticket nuevo);
        bool BajaTicket(int id);

        List<Cliente> GetClientes();
        List<MedioDeVenta> GetMedioDeVenta();
        List<FormaDePago> GetFormaDePagos();
        List<Promocion> GetPromociones();
        List<Butaca> GetButacas();
        List<Funcion> GetFunciones();
        List<TicketDTO> GetTicketPorFiltros(int id, DateTime fecha, string cliente);
    }
}
