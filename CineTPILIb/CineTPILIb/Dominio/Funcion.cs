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
        public int Id_horario { get; set; }
        public int Id_formato { get; set; }
        public bool Estado { get; set; }
        public int Id_pelicula { get; set; }
        public double precio { get; set; }
        public DateTime Fecha { get; set; }

        public Funcion(int id_funcion, int id_sala, int id_horario, int id_formato, bool estado, int id_pelicula, double precio, DateTime fecha)
        {
            Id_funcion = id_funcion;
            Id_sala = id_sala;
            Id_horario = id_horario;
            Id_formato = id_formato;
            Estado = estado;
            Id_pelicula = id_pelicula;
            this.precio = precio;
            Fecha = fecha;
        }
    }
}
