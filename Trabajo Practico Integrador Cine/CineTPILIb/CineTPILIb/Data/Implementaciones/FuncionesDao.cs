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
    public class FuncionesDao : IFuncionesDao
    {
        private SqlConnection conexion;

        public bool AltaFuncion(Funcion funcion)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();


                SqlCommand comando = new SqlCommand("SP_INSERTAR_FUNCIONES", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_sala", funcion.Id_funcion);
                comando.Parameters.AddWithValue("@id_pelicula",funcion.Id_pelicula);
                comando.Parameters.AddWithValue("@precio",funcion.precio);
                comando.Parameters.AddWithValue("@fecha_desde",funcion.FechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta",funcion.FechaHasta);
                comando.Parameters.AddWithValue("@horarios", funcion.Horarios);

                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if(t!= null)
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

        public bool BajaFuncion(int id)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_BAJA_FUNCION", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_funcion", id);

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

        public List<Funcion> GetFunciones()
        {
            List<Funcion> lFunciones = new List<Funcion>();

            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_SELECCIONAR_FUNCIONES");

            foreach(DataRow fila in tabla.Rows)
            {
                int id_funcion = Convert.ToInt32(fila["id_funcion"]);
                int id_sala = Convert.ToInt32(fila["id_sala"]);
                bool estado = Convert.ToBoolean(fila["estado"]);
                int id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                double precio = Convert.ToDouble(fila["precio"]);
                DateTime fechaDesde = Convert.ToDateTime(fila["fecha_desde"]);
                DateTime fechaHasta = Convert.ToDateTime(fila["fecha_hasta"]);
                string horarios = fila["horarios"].ToString();

                Funcion f = new Funcion(id_funcion,id_sala,estado,id_pelicula,precio,fechaDesde,fechaHasta,horarios);

                lFunciones.Add(f);
            }
            return lFunciones;
        }

        public bool ModificarFuncion(Funcion funcion)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_UPDATE_FUNCIONES", conexion,t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_funcion",funcion.Id_funcion);
                comando.Parameters.AddWithValue("@id_sala",funcion.Id_sala);
                comando.Parameters.AddWithValue("@id_pelicula", funcion.Id_pelicula);
                comando.Parameters.AddWithValue("@precio", funcion.precio);
                comando.Parameters.AddWithValue("@fecha_desde", funcion.FechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta", funcion.FechaHasta);
                comando.Parameters.AddWithValue("@horarios", funcion.Horarios);

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
    }
}
