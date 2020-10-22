using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class CadastrarUsuarioDAL
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["BD_sistemaFullConnectionString"].ConnectionString;

        public void CadastrarUsuario(Usuario usua)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO users VALUES (@use, @pass)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@use", usua.User);
            cmd.Parameters.AddWithValue("@pass", usua.senha);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
