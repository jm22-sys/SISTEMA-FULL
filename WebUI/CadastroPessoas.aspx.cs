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
    public partial class CadastroPessoas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se Não for um postBack -- ou seja -- É a primeira vez que entra na página
            if (!Page.IsPostBack)
            {
                CarregarPessoas();
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.NmPessoa = txtNome.Text;
            objPessoa.NrCPF = txtCPF.Text;
            objPessoa.DtNascimento = Convert.ToDateTime(txtDtNascimento.Text);
            objPessoa.DsEstadoCivil = Convert.ToChar(ddlEstadosCivis.SelectedValue);
            objPessoa.DsSexo = Convert.ToChar(rblSexos.SelectedValue);
            objPessoa.DsEmail = txtEmail.Text;
            objPessoa.NrTelefone = txtTelefone.Text;
            objPessoa.BtRecebeSMS = chkRecebeSMS.Checked;
            objPessoa.BtRecebeEmail = chkRecebeEmail.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(objPessoa);

            LimparCampos();

            lblMensagem.Text = "Pessoa inserida com sucesso.";

            CarregarPessoas();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtDtNascimento.Text = string.Empty;
            ddlEstadosCivis.SelectedIndex = 0;
            rblSexos.SelectedIndex = 0;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            chkRecebeSMS.Checked = false;
            chkRecebeEmail.Checked = false;

            lblMensagem.Text = string.Empty;
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void CarregarPessoas()
        {
            PessoaDAL pDAL = new PessoaDAL();
            grvPessoas.DataSource = pDAL.ListarPessoas();
            grvPessoas.DataBind();
        }

        private void ObeterPessoa(int cdPessoa)
        {
            PessoaDAL pdal = new PessoaDAL();

            Pessoa P = pdal.obterPessoa(cdPessoa);
            if ( P != null)
            {
                txtCodigo.Text = P.CdPessoa.ToString();
                txtNome.Text = P.NmPessoa;
                txtCPF.Text = P.NrCPF;
                txtDtNascimento.Text = P.DtNascimento.ToString("d");
                ddlEstadosCivis.SelectedValue = P.DsEstadoCivil.ToString();
                rblSexos.SelectedValue = P.DsSexo.ToString();
                txtEmail.Text = P.DsEmail;
                txtTelefone.Text = P.NrTelefone;
                chkRecebeEmail.Checked = P.BtRecebeSMS;
                chkRecebeSMS.Checked = P.BtRecebeSMS;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdPessoa = Convert.ToInt32(txtCodigo.Text);
            ObeterPessoa(cdPessoa);
        }

        private void ExcluirPessoa(int cdPessoa)
        {
            //Pessoa pessoa = new Pessoa();
            PessoaDAL pdal = new PessoaDAL();
            pdal.ExcluirPessoa(cdPessoa);
           
        }
        protected void grvPessoas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string nomeComando = e.CommandName;
            int cdPessoa = Convert.ToInt32(e.CommandArgument);

            if (nomeComando == "editar")
            {
                ObeterPessoa(cdPessoa);
            }
            if (nomeComando == "excluir")
            {
                ExcluirPessoa(cdPessoa);
                CarregarPessoas();
            }
        }

        protected void txtDtNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}