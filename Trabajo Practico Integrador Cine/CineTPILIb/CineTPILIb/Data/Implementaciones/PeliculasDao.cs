using CineTPILIb.Data.Interfaces;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
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
        private SqlConnection conexion = null;


        

        public List<Clasificacion> GetClasificaciones()
        {
            List<Clasificacion> lst = new List<Clasificacion>();

            string sp = "SP_CONSULTAR_CLASIFICACIONES";
            DataTable t = HelperDB.ObtenerInstancia().Consultar(sp);

            foreach (DataRow dr in t.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                Clasificacion aux = new Clasificacion();

                aux.IdClasificacion = Convert.ToInt32(dr["id_clasificacion"]);
                aux.ClasificacionName = Convert.ToString(dr["clasificacion"]);

                lst.Add(aux);
            }
            return lst;
        }

        public List<Genero> GetGeneros()
        {
            List<Genero> lst = new List<Genero>();

            string sp = "SP_CONSULTAR_GENEROS";
            DataTable t = HelperDB.ObtenerInstancia().Consultar(sp);

            foreach (DataRow dr in t.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                Genero aux = new Genero();

                aux.IdGenero = Convert.ToInt32(dr["id_genero"]);
                aux.GeneroName = Convert.ToString(dr["genero"]);

                lst.Add(aux);
            }
            return lst;

        }

        public List<Idioma> GetIdiomas()
        {
            List<Idioma> lst = new List<Idioma>();

            string sp = "SP_CONSULTAR_IDIOMAS";
            DataTable t = HelperDB.ObtenerInstancia().Consultar(sp);

            foreach (DataRow dr in t.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                Idioma aux = new Idioma();

                aux.IdIdioma = Convert.ToInt32(dr["id_idioma"]);
                aux.IdiomaName = Convert.ToString(dr["idioma"]);

                lst.Add(aux);
            }
            return lst;
        }


        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();

            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_PELICULAS_SIN_FILTRO");

            foreach(DataRow row in tabla.Rows)
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Id_pelicula = (int)row["id_pelicula"];
                pelicula.Titulo = row["titulo"].ToString();
                pelicula.Sinopsis = row["sinopsis"].ToString();
                pelicula.Duracion = (int)row["duracion"];

                pelicula.Clasificacion = new Clasificacion();
                pelicula.Clasificacion.ClasificacionName = row["clasificacion"].ToString();
                pelicula.Clasificacion.IdClasificacion = (int)row["id_clasificacion"];

                pelicula.Genero = new Genero();
                pelicula.Genero.IdGenero = (int)row["id_genero"];
                pelicula.Genero.GeneroName = row["genero"].ToString();

                pelicula.Idioma = new Idioma();
                pelicula.Idioma.IdIdioma = (int)row["id_idioma"];
                pelicula.Idioma.IdiomaName = row["idioma"].ToString();

                lPeliculas.Add(pelicula);
            }
            return lPeliculas;
        }

        public List<Pelicula> GetPeliculasConFiltro(int id_genero, int id_idioma, string sinopsis, string titulo)
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();

            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@titulo",titulo));
            lParametros.Add(new Parametro("@sinopsis", sinopsis));
            lParametros.Add(new Parametro("@id_genero", id_genero));
            lParametros.Add(new Parametro("@id_idioma", id_idioma));

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultarConParametros("SP_CONSULTAR_PELICULAS",lParametros);

            foreach (DataRow row in tabla.Rows)
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Id_pelicula = (int)row["id_pelicula"];
                pelicula.Titulo = row["titulo"].ToString();
                pelicula.Sinopsis = row["sinopsis"].ToString();
                pelicula.Duracion = (int)row["duracion"];

                pelicula.Clasificacion = new Clasificacion();
                pelicula.Clasificacion.ClasificacionName = row["clasificacion"].ToString();
                pelicula.Clasificacion.IdClasificacion = (int)row["id_clasificacion"];

                pelicula.Genero = new Genero();
                pelicula.Genero.IdGenero = (int)row["id_genero"];
                pelicula.Genero.GeneroName = row["genero"].ToString();

                pelicula.Idioma = new Idioma();
                pelicula.Idioma.IdIdioma = (int)row["id_idioma"];
                pelicula.Idioma.IdiomaName = row["idioma"].ToString();

                lPeliculas.Add(pelicula);
            }
            return lPeliculas;
        }

        public Pelicula PeliculaPorID(int id)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_pelicula", id));
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultarConParametros("SP_CONSULTAR_PELICULA_ID", lst);

            Pelicula pelicula = new Pelicula();

            foreach (DataRow row in tabla.Rows)
            {
                pelicula.Id_pelicula = (int)row["id_pelicula"];
                pelicula.Titulo = row["titulo"].ToString();
                pelicula.Sinopsis = row["sinopsis"].ToString();
                pelicula.Duracion = (int)row["duracion"];

                pelicula.Clasificacion = new Clasificacion();
                pelicula.Clasificacion.ClasificacionName = row["clasificacion"].ToString();
                pelicula.Clasificacion.IdClasificacion = (int)row["id_clasificacion"];

                pelicula.Genero = new Genero();
                pelicula.Genero.IdGenero = (int)row["id_genero"];
                pelicula.Genero.GeneroName = row["genero"].ToString();

                pelicula.Idioma = new Idioma();
                pelicula.Idioma.IdIdioma = (int)row["id_idioma"];
                pelicula.Idioma.IdiomaName = row["idioma"].ToString();

            }
            return pelicula;
        }



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
                comando.Parameters.AddWithValue("@id_clasificacion",nueva.Clasificacion.IdClasificacion);
                comando.Parameters.AddWithValue("@id_genero",nueva.Genero.IdGenero);
                comando.Parameters.AddWithValue("@id_idioma",nueva.Idioma.IdIdioma);

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
                comando.Parameters.AddWithValue("@id_clasificacion", pelicula.Clasificacion.IdClasificacion);
                comando.Parameters.AddWithValue("@id_genero", pelicula.Genero.IdGenero);
                comando.Parameters.AddWithValue("@id_idioma", pelicula.Idioma.IdIdioma);

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
        
        public bool BajaPelicula(int id)
        {
            bool resultado = true;
            SqlTransaction t = null;
            conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_BAJA_PELICULA", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_pelicula", id);

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
