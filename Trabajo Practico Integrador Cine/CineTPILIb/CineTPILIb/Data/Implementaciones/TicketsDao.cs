using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Data.Implementaciones
{
    public class TicketsDao : ITicketsDao
    {
        private SqlConnection conexion;
        public bool BajaTicket(int id)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_BAJA_TICKET", conexion,t);
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

        public bool NuevoTicket(Ticket nuevo)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_TICKET", conexion,t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@fecha",nuevo.Fecha);
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

                int id_ticket = Convert.ToInt32(pOUT.Value);
                SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, t);
                cmdDetalle.CommandType = CommandType.StoredProcedure;

                for(int i = 0; i < nuevo.DetallesTicket.Count; i++)
                {
                    cmdDetalle.Parameters.Clear();
                    cmdDetalle.Parameters.AddWithValue("@id_ticket",id_ticket);
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
    }
}
