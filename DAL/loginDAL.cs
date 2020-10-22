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
    public class loginDAL
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["BD_sistemaFullConnectionString"].ConnectionString;

        public bool auth(string user, string senha)
        {

            bool ss = false; 

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT COUNT(*) FROM users where usuario = @usuario AND senha = @senha";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@usuario", user);
            cmd.Parameters.AddWithValue("@senha", senha);

            ss = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            conn.Close();

            return ss;

            
        }

    }
}
