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
        int ObtenerProximoNro();
        List<TicketDTO> GetTicketPorFiltros(int id, DateTime fecha, string cliente);
        List<Cliente> GetClientes();
        List<MedioDeVenta> GetMedioDeVenta();
        List<FormaDePago> GetFormaDePagos();
        List<Promocion> GetPromociones();
        List<Butaca> GetButacas();
        List<Funcion> GetFunciones();
        bool NuevoTicket(Ticket nuevo);
        bool BajaTicket(int id);
    }
}
