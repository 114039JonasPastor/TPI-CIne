﻿using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Data.Interfaces
{
    public interface IFuncionesDao
    {
        List<Funcion> GetFunciones();
        List<FuncionDTO> GetFuncionesFiltros(DateTime desde, DateTime hasta, string titulo);
        List<Pelicula> GetPeliculaList();
        List<Horario> GetHorarios();
        List<Sala> GetSalas();
        bool AltaFuncion(Funcion funcion);
        bool BajaFuncion(int id);
        bool ModificarFuncion(int id, Funcion funcion);
    }
}
