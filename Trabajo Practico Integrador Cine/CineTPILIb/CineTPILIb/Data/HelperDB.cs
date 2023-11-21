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
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CineOk;Integrated Security=True");
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
            DataTable tabla = new DataTable();

            conexion.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                foreach (Parametro oParametro in parametros)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
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
