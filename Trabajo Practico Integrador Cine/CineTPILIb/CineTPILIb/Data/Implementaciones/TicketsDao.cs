using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
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

        public List<Cliente> GetClientes()
        {
            List<Cliente> lClientes = new List<Cliente>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTES");

            foreach(DataRow fila in tabla.Rows)
            {
                Cliente aux = new Cliente();
                aux.IdCliente = Convert.ToInt32(fila["ID"]);
                aux.Nombre = fila["Nombre"].ToString();

                lClientes.Add(aux);
            }
            return lClientes;
        }

        public List<TicketDTO> GetTicketPorFiltros(int id, DateTime fecha, string cliente)
        {
            List<TicketDTO> lista = new List<TicketDTO>();

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id",id));
            parametros.Add(new Parametro("@fecha", fecha));
            parametros.Add(new Parametro("@cliente", cliente));

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultarConParametros("SP_GET_TICKETS_FILTROS", parametros);

            foreach(DataRow fila in tabla.Rows)
            {
                TicketDTO aux = new TicketDTO();
                aux.NroTicket = Convert.ToInt32(fila["Numero de ticket"]);
                aux.Cliente = fila["Cliente"].ToString();
                aux.FechaEmision = Convert.ToDateTime(fila["Fecha"]);

                lista.Add(aux);
            }
            return lista;
        }
    }
}
