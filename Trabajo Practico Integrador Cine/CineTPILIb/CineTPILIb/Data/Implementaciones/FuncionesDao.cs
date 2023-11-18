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


                SqlCommand comando = new SqlCommand("SP_INSERTAR_FUNCION", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_sala", funcion.Id_sala);
                comando.Parameters.AddWithValue("@id_pelicula", funcion.Id_pelicula);
                comando.Parameters.AddWithValue("@precio", funcion.Precio);
                comando.Parameters.AddWithValue("@fecha_desde", funcion.FechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta", funcion.FechaHasta);
                comando.Parameters.AddWithValue("@id_horarios", funcion.Id_horarios);

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
                f.Id_horarios = Convert.ToInt32(fila["id_horarios"]);
                f.Estado = Convert.ToBoolean(fila["estado"]);
                f.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                f.Precio = Convert.ToDouble(fila["precio"]);
                f.FechaDesde = Convert.ToDateTime(fila["fecha_desde"]);
                f.FechaHasta = Convert.ToDateTime(fila["fecha_hasta"]);

                lFunciones.Add(f);
            }
            return lFunciones;
        }

        public List<Horario> GetHorarios()
        {
            List<Horario> lHorarios = new List<Horario>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_COMBO_HORARIO");

            foreach(DataRow fila in tabla.Rows)
            {
                Horario aux = new Horario();
                aux.IdHorario = Convert.ToInt32(fila["id_horarios"]);
                aux.Horarios = fila["horario"].ToString();

                lHorarios.Add(aux);
            }
            return lHorarios;
        }

        public List<Pelicula> GetPeliculaList()
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_COMBO_PELICULA");

            foreach(DataRow fila in tabla.Rows)
            {
                Pelicula aux = new Pelicula();
                aux.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                aux.Titulo = fila["titulo"].ToString();
                aux.Duracion = Convert.ToInt32(fila["duracion"]);
                aux.Sinopsis = fila["sinopsis"].ToString();
                aux.Id_clasificacion = Convert.ToInt32(fila["id_clasificacion"]);
                aux.Id_genero = Convert.ToInt32(fila["id_genero"]);
                aux.Id_idioma = Convert.ToInt32(fila["id_idioma"]);

                lPeliculas.Add(aux);
            }
            return lPeliculas;
        }

        public List<Sala> GetSalas()
        {
            List<Sala> lSalas = new List<Sala>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_COMBO_SALAS");

            foreach(DataRow fila in tabla.Rows)
            {
                Sala aux = new Sala();
                aux.IdSala = Convert.ToInt32(fila["id_sala"]);
                aux.NroSala = Convert.ToInt32(fila["nro_sala"]);
                aux.IdTipoSala = Convert.ToInt32(fila["id_tipo_sala"]);

                lSalas.Add(aux);
            }
            return lSalas;
        }

        public bool ModificarFuncion(int id, Funcion funcion)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                id = funcion.Id_funcion;

                SqlCommand comando = new SqlCommand("SP_UPDATE_FUNCION", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_funcion", id);
                comando.Parameters.AddWithValue("@id_sala", funcion.Id_sala);
                comando.Parameters.AddWithValue("@id_pelicula", funcion.Id_pelicula);
                comando.Parameters.AddWithValue("@precio", funcion.Precio);
                comando.Parameters.AddWithValue("@fecha_desde", funcion.FechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta", funcion.FechaHasta);
                comando.Parameters.AddWithValue("@horarios", funcion.Id_horarios);

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
