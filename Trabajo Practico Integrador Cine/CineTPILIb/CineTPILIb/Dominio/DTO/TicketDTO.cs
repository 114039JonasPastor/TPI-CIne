using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio.DTO
{
    public class TicketDTO
    {
        public int NroTicket { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}
