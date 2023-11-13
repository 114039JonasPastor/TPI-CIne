using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using System.Data;
using System.Data.SqlClient;

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
                comando.Parameters.AddWithValue("@id_pelicula", funcion.Id_pelicula);
                comando.Parameters.AddWithValue("@precio", funcion.Precio);
                comando.Parameters.AddWithValue("@fecha_desde", funcion.FechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta", funcion.FechaHasta);
                comando.Parameters.AddWithValue("@id_horario", funcion.Horario);

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

            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_FUNCIONES");

            foreach (DataRow fila in tabla.Rows)
            {
                Funcion f = new Funcion();
                f.Id_funcion = Convert.ToInt32(fila["id_funcion"]);
                f.Id_sala = Convert.ToInt32(fila["id_sala"]);
                f.Horario = Convert.ToDateTime(fila["horario"]);
                f.IdFormato = Convert.ToInt32(fila["id_formato"]);
                f.Estado = Convert.ToBoolean(fila["estado"]);
                f.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                f.Precio = Convert.ToDouble(fila["precio"]);
                f.FechaDesde = Convert.ToDateTime(fila["fecha_desde"]);
                f.FechaHasta = Convert.ToDateTime(fila["fecha_hasta"]);

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

                SqlCommand comando = new SqlCommand("SP_UPDATE_FUNCIONES", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_funcion", funcion.Id_funcion);
                comando.Parameters.AddWithValue("@id_sala", funcion.Id_sala);
                comando.Parameters.AddWithValue("@id_pelicula", funcion.Id_pelicula);
                comando.Parameters.AddWithValue("@precio", funcion.Precio);
                comando.Parameters.AddWithValue("@fecha_desde", funcion.FechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta", funcion.FechaHasta);
                comando.Parameters.AddWithValue("@id_horario", funcion.Horario);

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
