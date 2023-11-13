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
    public class PeliculasDao : IPeliculasDao
    {
        private SqlConnection conexion;
        public bool AltaPelicula(Pelicula nueva)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_NUEVA_PELICULA", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@titulo",nueva.Titulo);
                comando.Parameters.AddWithValue("@duracion",nueva.Duracion);
                comando.Parameters.AddWithValue("@sinopsis",nueva.Sinopsis);
                comando.Parameters.AddWithValue("@id_clasificacion",nueva.Id_clasificacion);
                comando.Parameters.AddWithValue("@id_genero",nueva.Id_genero);
                comando.Parameters.AddWithValue("@id_idioma",nueva.Id_idioma);

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

        public List<Pelicula> GetPeliculas(string titulo, int duracion, int id_genero, int id_idioma)
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();

            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@titulo",titulo));
            lParametros.Add(new Parametro("@duracion", duracion));
            lParametros.Add(new Parametro("@genero", id_genero));
            lParametros.Add(new Parametro("@idioma", id_idioma));

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultarConParametros("SP_CONSULTAR_PELICULAS",lParametros);

            foreach (DataRow row in tabla.Rows)
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Titulo = row["titulo"].ToString();
                pelicula.Duracion = Convert.ToInt32(row["duracion"].ToString());
                pelicula.Id_genero = Convert.ToInt32(row["id_genero"].ToString());
                pelicula.Id_idioma = Convert.ToInt32(row["id_idioma"].ToString());

                lPeliculas.Add(pelicula);
            }
            return lPeliculas;
        }

        public bool ModificarPelicula(Pelicula pelicula)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_MODIFICAR_PELICULA", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_pelicula", pelicula.Id_pelicula);
                comando.Parameters.AddWithValue("@titulo", pelicula.Titulo);
                comando.Parameters.AddWithValue("@duracion", pelicula.Duracion);
                comando.Parameters.AddWithValue("@sinopsis", pelicula.Sinopsis);
                comando.Parameters.AddWithValue("@id_clasificacion", pelicula.Id_clasificacion);
                comando.Parameters.AddWithValue("@id_genero", pelicula.Id_genero);
                comando.Parameters.AddWithValue("@id_idioma", pelicula.Id_idioma);

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
