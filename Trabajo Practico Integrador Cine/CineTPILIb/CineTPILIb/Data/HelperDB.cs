using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTPILIb.Data
{
    public class HelperDB
    {
        private static HelperDB instancia = null;
        private SqlConnection conexion;

        private HelperDB()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-35MIDJI\SQLEXPRESS;Initial Catalog=CineNuevo;Integrated Security=True");
        }
        public static HelperDB ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new HelperDB();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }
        public DataTable Consultar(string NombreSp)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSp;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }

        public DataTable ConsultarConParametros(string NombreSP, List<Parametro> parametros)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            comando.Parameters.Clear();
            foreach (Parametro p in parametros)
            {
                comando.Parameters.Add(p.Nombre, (SqlDbType)p.Valor);
            }

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }
        public int ConsultarEscalar(string NombreSP, string NombreParametroOut)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = NombreParametroOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            conexion.Close();

            return (int)parametro.Value;
        }
    }
}
