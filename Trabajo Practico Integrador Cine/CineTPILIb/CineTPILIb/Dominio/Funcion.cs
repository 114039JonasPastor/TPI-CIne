namespace CineTPILIb.Dominio
{
    public class Funcion
    {
        public int Id_funcion { get; set; }
        public int Id_sala { get; set; }
        public int IdHorario { get; set; }
        public int IdFormato { get; set; }
        public bool Estado { get; set; }
        public int Id_pelicula { get; set; }
        public double Precio { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

        public Sala Sala { get; set; }
        public Horario Horario { get; set; }

        public Funcion()
        {

        }

        public Funcion(int id_funcion, int id_sala, int id_horario, bool estado, int id_pelicula, double precio,
                        DateTime fechaDesde, DateTime fechaHasta, int id_formato)
        {
            Id_funcion = id_funcion;
            Id_sala = id_sala;
            IdHorario = id_horario;
            Estado = estado;
            IdFormato = id_formato;
            Id_pelicula = id_pelicula;
            Precio = precio;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;

        }

        public Funcion(int id_funcion, int id_pelicula, Sala sala, Horario horario)
        {
            Id_funcion = id_funcion;
            Id_pelicula= id_pelicula;
            Sala = sala;
            Horario = horario;
        }
    }
}
