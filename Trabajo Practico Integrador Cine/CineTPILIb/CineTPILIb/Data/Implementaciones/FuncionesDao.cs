using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using System.Data;
using System.Data.SqlClient;

namespace CineTPILIb.Data.Implementaciones
{
    public class FuncionesDao : IFuncionesDao
    {
        private SqlConnection conexion;

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

        public Funcion ObtenerFuncionPorId(int nro)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idfuncion", nro));

            string sp = "SP_CONSULTAR_FUNCIONES_ID";
            DataTable dt = HelperDB.ObtenerInstancia().ConsultarConParametros(sp, lst);
            

            Funcion f = new Funcion();
            foreach (DataRow fila in dt.Rows)
            {
                f.Id_funcion = Convert.ToInt32(fila["id_funcion"]);
                f.Id_sala = Convert.ToInt32(fila["id_sala"]);
                f.IdHorario = Convert.ToInt32(fila["id_horario"]);
                f.Estado = Convert.ToBoolean(fila["estado"]);
                f.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                f.Precio = Convert.ToDouble(fila["precio"]);
                f.FechaDesde = Convert.ToDateTime(fila["fecha_desde"]);
                f.FechaHasta = Convert.ToDateTime(fila["fecha_hasta"]);


            }

            return f;
        }


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
                comando.Parameters.AddWithValue("@id_horario", funcion.IdHorario);

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


        public bool ModificarFuncion(Funcion funcion)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_UPDATE_FUNCION", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_funcion", funcion.Id_funcion);
                comando.Parameters.AddWithValue("@id_sala", funcion.Id_sala);
                comando.Parameters.AddWithValue("@id_pelicula", funcion.Id_pelicula);
                comando.Parameters.AddWithValue("@precio", funcion.Precio);
                comando.Parameters.AddWithValue("@fecha_desde", funcion.FechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta", funcion.FechaHasta);
                comando.Parameters.AddWithValue("@id_horario", funcion.IdHorario);

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

        public List<FuncionDTO> GetFuncionesFiltros(DateTime desde, DateTime hasta, int id_funcion)
        {
            List<FuncionDTO> lFunciones = new List<FuncionDTO>();

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id_funcion", id_funcion));
            parametros.Add(new Parametro("@desde", desde));
            parametros.Add(new Parametro("@hasta", hasta));

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultarConParametros("SP_CONSULTAR_FUNCIONES_FILTROS", parametros);

            foreach (DataRow fila in tabla.Rows)
            {
                FuncionDTO aux = new FuncionDTO();
                aux.ID = Convert.ToInt32(fila["Numero de funcion"]);
                aux.Pelicula = fila["Pelicula"].ToString();
                aux.Sala = Convert.ToInt32(fila["Sala"]);
                aux.TipoSala = fila["Tipo de sala"].ToString();
                aux.Horario = fila["Horario"].ToString();
                aux.FechaDesde = Convert.ToDateTime(fila["Fecha desde"]);
                aux.FechaHasta = Convert.ToDateTime(fila["Fecha hasta"]);
                aux.Precio = Convert.ToDouble(fila["Precio"]);

                lFunciones.Add(aux);
            }
            return lFunciones;
        }

        public List<PeliculaDTO> GetPeliculaList()
        {
            List<PeliculaDTO> lPeliculas = new List<PeliculaDTO>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_PELICULAS_DTO");

            foreach (DataRow fila in tabla.Rows)
            {
                PeliculaDTO aux = new PeliculaDTO();
                aux.IdPelicula = Convert.ToInt32(fila["ID"]);
                aux.Titulo = fila["titulo"].ToString();
                aux.Duracion = Convert.ToInt32(fila["duracion"]);
                aux.Clasificacion = fila["clasificacion"].ToString();
                aux.Genero = fila["genero"].ToString();
                aux.Idioma = fila["idioma"].ToString();
                aux.Estado = Convert.ToBoolean(fila["estado"]);

                lPeliculas.Add(aux);
            }
            return lPeliculas;
        }

        public List<Horario> GetHorarios()
        {
            List<Horario> lHorarios = new List<Horario>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_HORARIOS");

            foreach (DataRow fila in tabla.Rows)
            {
                Horario aux = new Horario();
                aux.IdHorario = Convert.ToInt32(fila["id_horario"]);
                aux.Hora = fila["horario"].ToString();

                lHorarios.Add(aux);
            }
            return lHorarios;
        }

        public List<Sala> GetSalas()
        {
            List<Sala> lSalas = new List<Sala>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_SALAS");

            foreach (DataRow fila in tabla.Rows)
            {
                Sala aux = new Sala();
                aux.IdSala = Convert.ToInt32(fila["id_sala"]);
                aux.NroSala = Convert.ToInt32(fila["nro_sala"]);
                aux.IdTipoSala = Convert.ToInt32(fila["id_tipo_sala"]);

                lSalas.Add(aux);
            }
            return lSalas;
        }

    }
}

