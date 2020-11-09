using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class testeArquivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fuArquivo.HasFile)
            {
                string nomeArquivo = fuArquivo.FileName;
                string caminhoArquivo = Server.MapPath(@"imagens\");
                fuArquivo.SaveAs(caminhoArquivo + nomeArquivo);
            }
            Response.Write("<script>alert('Salvo com sucesso');</script>");

        }
    }
}