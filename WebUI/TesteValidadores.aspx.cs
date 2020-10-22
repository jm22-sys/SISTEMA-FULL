using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class TesteValidadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            lblRetorno.Text = "sucefull";
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtNumeroInt.Text = string.Empty;
            txtInicial.Text = string.Empty;
            txtFinal.Text = string.Empty;        
            txtNumeroInt.Text  = string.Empty;
            txt100.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtMes.Text = string.Empty;

        }

        protected void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}