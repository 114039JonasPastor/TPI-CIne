using System;
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
        public DateTime Horario { get; set; }
        public int IdFormato {  get; set; }
        public bool Estado { get; set; }
        public int Id_pelicula { get; set; }
        public double Precio { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta{ get; set; }

        public Funcion()
        {
            
        }

        public Funcion(int id_funcion, int id_sala, DateTime horario, bool estado, int id_pelicula, double precio, 
                        DateTime fechaDesde, DateTime fechaHasta, int id_formato)
        {
            Id_funcion = id_funcion;
            Id_sala = id_sala;
            Horario = horario;
            Estado = estado;
            IdFormato = id_formato;
            Id_pelicula = id_pelicula;
            Precio = precio;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;

        }
    }
}
