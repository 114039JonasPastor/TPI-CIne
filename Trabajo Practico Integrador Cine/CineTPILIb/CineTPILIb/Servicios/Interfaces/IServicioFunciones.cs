using CineTPILIb.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Servicios.Interfaces
{
    public interface IServicioFunciones
    {
        List<Funcion> ObtenerFunciones();
        Funcion GetFuncionesPorId(int nro);
        bool AltaFuncion(Funcion funcion);
        bool ModificarFuncion(Funcion funcion);
        bool BajaFuncion(int id);
    }
}
