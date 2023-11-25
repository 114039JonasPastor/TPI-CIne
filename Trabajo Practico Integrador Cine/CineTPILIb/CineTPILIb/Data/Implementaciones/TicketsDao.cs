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

                int id_ticket = (int)pOUT.Value;
                int detalleNro = 1;

                foreach (DetalleTicket item in nuevo.DetallesTicket)
                { 
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_ticket", id_ticket);
                    cmdDetalle.Parameters.AddWithValue("@id_detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@id_funcion",item.Funcion.Id_funcion);
                    cmdDetalle.Parameters.AddWithValue("@id_butaca", item.Id_butaca);
                    cmdDetalle.Parameters.AddWithValue("@precio_venta", item.Precio_venta);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;

                }
                t.Commit();

            }
            catch(Exception ex)
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

        public List<MedioDeVenta> GetMedioDeVenta()
        {
            List<MedioDeVenta> lMedio= new List<MedioDeVenta>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_MEDIOS_PEDIDOS");

            foreach (DataRow fila in tabla.Rows)
            {
                MedioDeVenta aux = new MedioDeVenta();
                aux.IdMedioPago = Convert.ToInt32(fila["id_medio_pedido"]);
                aux.Descripcion = fila["descripcion"].ToString();

                lMedio.Add(aux);
            }
            return lMedio;
        }

        public List<FormaDePago> GetFormaDePagos()
        {
            List<FormaDePago> lForma = new List<FormaDePago>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSUTAR_FORMAS_PAGO");

            foreach (DataRow fila in tabla.Rows)
            {
                FormaDePago aux = new FormaDePago();
                aux.IdFormaPago = Convert.ToInt32(fila["id_forma_pago"]);
                aux.Descripcion = fila["descripcion"].ToString();
                aux.Recargo = Convert.ToInt32(fila["porcentaje_recargo"]);

                lForma.Add(aux);
            }
            return lForma;
        }

        public List<Promocion> GetPromociones()
        {
            List<Promocion> lPromocion = new List<Promocion>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_PROMOCIONES");

            foreach (DataRow fila in tabla.Rows)
            {
                Promocion aux = new Promocion();
                aux.IdPromocion = Convert.ToInt32(fila["id_promocion"]);
                aux.PorcentajeDescuento = Convert.ToInt32(fila["procentaje_descuento"]);

                lPromocion.Add(aux);
            }
            return lPromocion;
        }

        public List<Butaca> GetButacas()
        {
            List<Butaca> lButaca = new List<Butaca>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_BUTACAS");

            foreach (DataRow fila in tabla.Rows)
            {
                Butaca aux = new Butaca();
                aux.IdButaca = Convert.ToInt32(fila["id_butaca"]);
                aux.NroButaca = fila["numero"].ToString();

                lButaca.Add(aux);
            }
            return lButaca;
        }
        public List<Funcion> GetFunciones()
        {
            List<Funcion> lFunciones = new List<Funcion>();

            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_FUNCIONES");

            foreach (DataRow fila in tabla.Rows)
            {
                Funcion f = new Funcion();
                f.Id_funcion = Convert.ToInt32(fila["id_funcion"]);
                f.Id_sala = Convert.ToInt32(fila["id_sala"]);
                f.IdHorario = Convert.ToInt32(fila["id_horario"]);
                f.Estado = Convert.ToBoolean(fila["estado"]);
                f.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                f.Precio = Convert.ToDouble(fila["precio"]);
                f.FechaDesde = Convert.ToDateTime(fila["fecha_desde"]);
                f.FechaHasta = Convert.ToDateTime(fila["fecha_hasta"]);

                lFunciones.Add(f);
            }
            return lFunciones;
        }

        public int ObtenerProximoNro()
        {
            return HelperDB.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_ID", "@next");
        }
    }
}
