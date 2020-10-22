using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace WebUI
{
    public partial class CadastroDeUsuarioslogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalve_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.User = txtUsuario.Text;
            usu.senha = txtSenha.Text;


            CadastrarUsuarioDAL cd = new CadastrarUsuarioDAL();
            cd.CadastrarUsuario(usu);


            lblSucess.Text = "Usuario cadastrado!";
        }
    }
}