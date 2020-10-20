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
    public class PessoaDAL
    {
        //pegar o dado de conexao do app.config ou webconfig ( Arquivo de configuracao)
        private string connectionString = ConfigurationManager.ConnectionStrings["BD_sistemaFullConnectionString"].ConnectionString;

        public void InserirPessoa(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Pessoas VALUES (@nome, @cpf, @nasc, @ec, @sexo, @email, @telefone, @recebeSMS, @recebeEmail)";
            string sql1 = "delete from pessoas";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@recebeSMS", objPessoa.BtRecebeSMS);
            cmd.Parameters.AddWithValue("@recebeEmail", objPessoa.BtRecebeEmail);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Pessoa obterPessoa(int cdPessoa)
        {
            Pessoa pessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas WHERE CdPessoa = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows && dr.Read())
            //{
            //    pessoa = new Pessoa();
            //    pessoa.CdPessoa = cdPessoa;
            //    pessoa.NmPessoa = dr["NmPessoa"].ToString();
            //    pessoa.NrCPF = dr["NrCPF"].ToString();
            //    pessoa.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
            //    pessoa.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
            //    pessoa.DsSexo = Convert.ToChar(dr["DsSexo"]);
            //    pessoa.DsEmail = dr["DsEmail"].ToString();
            //    pessoa.NrTelefone = dr["NrTelefone"].ToString();
            //    pessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
            //    pessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);
            //}

            conn.Close();

            return pessoa;
        }

        public List<Pessoa> ListarPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    Pessoa objPessoa;
            //    while (dr.Read())
            //    {
            //        objPessoa = new Pessoa();
            //        objPessoa.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
            //        objPessoa.NmPessoa = dr["NmPessoa"].ToString();
            //        objPessoa.NrCPF = dr["NrCPF"].ToString();
            //        objPessoa.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
            //        objPessoa.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
            //        objPessoa.DsSexo = Convert.ToChar(dr["DsSexo"]);
            //        objPessoa.DsEmail = dr["DsEmail"].ToString();
            //        objPessoa.NrTelefone = dr["NrTelefone"].ToString();
            //        objPessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
            //        objPessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);

            //        listaPessoas.Add(objPessoa);
            //    }
            //}

            conn.Close();

            return listaPessoas;
        }

        public void AtualizarPessoa(Pessoa objPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            string sql = "UPDATE Pessoas SET NmPessoa = @Nome, NrCPF = @cpf, DtNascimento = @nasc, DsEstadoCivil = @ec, DsSexo = @sexo, DsEmail = @email, NrTelefone = @telefone, BtRecebeSMS = @recebeSMS, BtRecebeEmail = @recebeEmail WHERE CdPessoa = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objPessoa.CdPessoa);
            cmd.Parameters.AddWithValue("@Nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@recebeSMS", objPessoa.BtRecebeSMS);
            cmd.Parameters.AddWithValue("@recebeEmail", objPessoa.BtRecebeEmail);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void ExcluirPessoa(int cdPessoa)

        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Pessoas WHERE CdPessoa = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            cmd.ExecuteNonQuery();


            conn.Close();



        }

        public List<Pessoa> ListarPessoasFilters(string nome, string email)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas where NmPessoa LIKE @nome AND DsEmail LIKE @email";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", $"%{ nome}%");
            cmd.Parameters.AddWithValue("@email", $"%{ email}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {
                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
                    objPessoa.NmPessoa = dr["NmPessoa"].ToString();
                    objPessoa.NrCPF = dr["NrCPF"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    objPessoa.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                    objPessoa.DsSexo = Convert.ToChar(dr["DsSexo"]);
                    objPessoa.DsEmail = dr["DsEmail"].ToString();
                    objPessoa.NrTelefone = dr["NrTelefone"].ToString();
                    objPessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
                    objPessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);

                    listaPessoas.Add(objPessoa);
                }
            }

            conn.Close();

            return listaPessoas;
        }


    }
}
