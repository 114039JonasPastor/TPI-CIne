using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using System.Data;
using System.Data.SqlClient;

namespace CineTPILIb.Data.Implementaciones
{
    public class TicketsDao : ITicketsDao
    {
        private SqlConnection conexion;


        public List<Ticket> ObtenerTicketsPorFiltros(DateTime desde, DateTime hasta, string cliente, string pelicula, string empleado)
        {
            List<Ticket> lstTickets = new List<Ticket>();
            string sp = "SP_CONSULTAR_TICKETS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", desde));
            lst.Add(new Parametro("@fecha_hasta", hasta));
            lst.Add(new Parametro("@cliente", cliente));
            lst.Add(new Parametro("@empleado", empleado));
            lst.Add(new Parametro("@pelicula", pelicula));

            DataTable dt = HelperDB.ObtenerInstancia().ConsultarConParametros(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Ticket ticket = new Ticket();
                ticket.Id_ticket = (int)row["id_ticket"];
                ticket.Total = (decimal)row["total"];
                ticket.Fecha = Convert.ToDateTime(row["fecha"]);

                ticket.Cliente = new Cliente();
                ticket.Cliente.Nombre = (row["Nombre cliente"].ToString());

                ticket.Empleado = new Empleado();
                ticket.Empleado.Nombre = (row["Nombre empleado"].ToString());

                ticket.Pelicula = new Pelicula();
                ticket.Pelicula.Titulo = (row["titulo"].ToString());

                lstTickets.Add(ticket);
            }

            return lstTickets;
        }


        public bool NuevoTicket(Ticket nuevo)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_TICKET", conexion, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@fecha", nuevo.Fecha);
                cmdMaestro.Parameters.AddWithValue("@id_cliente", nuevo.Id_cliente);
                cmdMaestro.Parameters.AddWithValue("@id_empleado", nuevo.Empleado.IdEmpleado);
                cmdMaestro.Parameters.AddWithValue("@id_medio_pedido", nuevo.Id_medio_pedido);
                cmdMaestro.Parameters.AddWithValue("@id_promocion", nuevo.Id_promocion);
                cmdMaestro.Parameters.AddWithValue("@total", nuevo.Total);
                cmdMaestro.Parameters.AddWithValue("@id_forma_pago", nuevo.Id_forma_pago);

                SqlParameter pOUT = new SqlParameter();
                pOUT.ParameterName = "@nuevo_id_ticket";
                pOUT.DbType = DbType.Int32;
                pOUT.Direction = ParameterDirection.Output;

                cmdMaestro.Parameters.Add(pOUT);

                cmdMaestro.ExecuteNonQuery();

                int id_ticket = Convert.ToInt32(pOUT.Value);
                SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                cmdDetalle.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < nuevo.DetallesTicket.Count; i++)
                {
                    cmdDetalle.Parameters.Clear();
                    cmdDetalle.Parameters.AddWithValue("@id_ticket", id_ticket);
                    cmdDetalle.Parameters.AddWithValue("@id_funcion", nuevo.DetallesTicket[i].Funcion.Id_funcion);
                    cmdDetalle.Parameters.AddWithValue("@id_butaca", nuevo.DetallesTicket[i].Id_butaca);
                    cmdDetalle.Parameters.AddWithValue("@precio_venta", nuevo.DetallesTicket[i].Precio_venta);
                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }


        public bool BajaTicket(int id)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_BAJA_TICKET", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_ticket", id);

                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }


        public Ticket ObtenerTicketById(int id)
        {
            Ticket ticket = new Ticket();
            ticket.Cliente = new Cliente();
            string sp = "SP_CONSULTAR_DETALLE_TICKET";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_ticket", id));

            DataTable dt = HelperDB.ObtenerInstancia().ConsultarConParametros(sp, lst);
            bool primero = true;

            foreach (DataRow fila in dt.Rows)
            {
                if (primero)
                {
                    ticket.Id_ticket = (int)fila["id_ticket"];
                    ticket.Cliente.Nombre = fila["cliente"].ToString();
                    ticket.Fecha = DateTime.Parse(fila["fecha"].ToString());
                    ticket.Total = Decimal.Parse(fila["total"].ToString());
                    primero = false;
                }

                //peli
                Idioma oIdioma = new Idioma();
                oIdioma.IdiomaName = fila["idioma"].ToString();
                oIdioma.IdIdioma = (int)fila["id_idioma"];

                Clasificacion clasificacion = new Clasificacion();
                clasificacion.ClasificacionName = fila["clasificacion"].ToString();
                clasificacion.IdClasificacion = (int)fila["id_clasificacion"];

                Genero genero = new Genero();
                genero.GeneroName = fila["genero"].ToString();
                genero.IdGenero = (int)fila["id_genero"];

                string titulo = (fila["titulo"].ToString());

                Pelicula pelicula = new Pelicula(titulo, genero, clasificacion, oIdioma);
                
                //funcion
                Sala sala = new Sala();
                sala.IdSala = (int)fila["id_sala"];
                sala.NroSala = (int)fila["nro_sala"];

                Horario horario = new Horario();
                horario.IdHorario = (int)fila["id_horario"];
                horario.Hora = (fila["horario"].ToString());

                int id_funcion = int.Parse(fila["id_funcion"].ToString());

                Funcion funcion = new Funcion(id_funcion, sala, horario);

                //detalle
                double precio_venta = double.Parse(fila["precio_venta"].ToString());

                Butaca butaca = new Butaca();
                butaca.IdButaca = (int)fila["id_butaca"];
                butaca.NroButaca = (int)fila["numero"];

                DetalleTicket detalle = new DetalleTicket(butaca, precio_venta);

                ticket.AgregarDetalle(detalle);

            }

            return ticket;
        }
    }
}
