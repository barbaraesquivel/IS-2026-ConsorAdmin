using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL.Acceso
{
    public class Acceso
    {
        SqlConnection con = new SqlConnection();
        public void Abrir()
        {

            con.ConnectionString = "Server=159.112.151.168,1433;Database=Master;User Id=sa;Password=Barby846!;TrustServerCertificate=True;";
            con.Open();
        }
        public void Cerrar()
        {
            con.Close();
            con = null;
            GC.Collect();

        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> parameter = null)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameter != null)
            {

                cmd.Parameters.AddRange(parameter.ToArray());
            }

            return cmd;

        }


        public DataTable Leer(string sql, List<SqlParameter> parameters = null)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = CrearComando(sql, parameters);
            da.Fill(tabla);
            return tabla;
        }

        public int Escribir(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = CrearComando(sql, parameters);
            int filas = 0;
            try
            {
                filas = cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { filas = 1; }
            return filas;



        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Int32;
            return p;


        }
        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.DateTime;
            return p;


        }
        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.String;
            return p;


        }

        public SqlParameter CrearParametro(string nombre, float valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Single;
            return p;


        }


    }
}
