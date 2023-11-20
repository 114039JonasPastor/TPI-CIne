using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
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
        List<FuncionDTO> GetFuncionesFiltros(DateTime desde, DateTime hasta, string pelicula);
        List<Pelicula> GetPeliculaList();
        List<Horario> GetHorarios();
        List<Sala> GetSalas();
        bool AltaFuncion(Funcion funcion);
        bool BajaFuncion(int id);
        bool ModificarFuncion(int id,Funcion funcion);
    }
}
