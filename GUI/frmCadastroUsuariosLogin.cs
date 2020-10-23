using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace GUI
{
    public partial class frmCadastroUsuariosLogin : Form
    {
        public frmCadastroUsuariosLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuarioDAL dal = new CadastrarUsuarioDAL();

            Usuario user = new Usuario();
            user.User = txtUsu.Text;
            user.senha = txtSenha.Text;

            dal.CadastrarUsuario(user);

            MessageBox.Show("Cadastrado com sucesso!!!");

            txtSenha.Text = "";
            txtUsu.Text = "";


        }
    }
}
