﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Dominio
{
    public class Funcion
    {
        public int Id_funcion { get; set; }
        public int Id_sala { get; set; }
        public bool Estado { get; set; }
        public int Id_pelicula { get; set; }
        public double precio { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int Id_horario { get; set; }

        public Funcion(int id_funcion, int id_sala, bool estado, int id_pelicula, double precio, DateTime fechaDesde, DateTime fechaHasta, int id_horario)
        {
            Id_funcion = id_funcion;
            Id_sala = id_sala;
            Estado = estado;
            Id_pelicula = id_pelicula;
            this.precio = precio;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            Id_horario = id_horario;
        }
    }
}
