using CineTPILIb.Data.Implementaciones;
using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using CineTPILIb.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Servicios.Implementaciones
{
    public class ServicioFunciones: IServicioFunciones
    {
        private IFuncionesDao dao;

        public ServicioFunciones()
        {
            dao = new FuncionesDao();
        }
        public List<Funcion> ObtenerFunciones()
        {
            return dao.GetFunciones();
        }

        public bool AltaFuncion(Funcion funcion)
        {
            return dao.AltaFuncion(funcion);
        }

        public bool BajaFuncion(int id)
        {
            return dao.BajaFuncion(id);
        }

        public bool ModificarFuncion(int id, Funcion funcion)
        {
            return dao.ModificarFuncion(id, funcion);
        }

        public List<PeliculaDTO> GetPeliculaList()
        {
            return dao.GetPeliculaList();
        }

        public List<Horario> GetHorarios()
        {
            return dao.GetHorarios();
        }

        public List<Sala> GetSalas()
        {
            return dao.GetSalas();
        }

        public List<FuncionDTO> GetFuncionesFiltros(DateTime desde, DateTime hasta, int id_funcion)
        {
            return dao.GetFuncionesFiltros(desde, hasta, id_funcion);
        }
    }
}
