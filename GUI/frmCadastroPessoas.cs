using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmCadastroPessoas : Form
    {
        

        public frmCadastroPessoas()
        {
            InitializeComponent();
        }

        private void frmCadastroPessoas_Load(object sender, EventArgs e)
        {
            carregarPessoas();
        }

        #region Botoes
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtNome.Text == null)
            {
                MessageBox.Show("Insira um nome valido para cadastrar.");
                LimparCampos();
            }
            else
                CadastrarPessoa();
               
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            #region CorpoDeBusca
            
            int cdPessoa = Convert.ToInt32(txtCodigo.Text);
          

            PessoaDAL pDAL = new PessoaDAL();
            Pessoa pessoa = pDAL.obterPessoa(cdPessoa);
            
            if (pessoa == null)
            {
                MessageBox.Show("Pessoa não encontrada.");
            }
            else
            {
                txtNome.Text = pessoa.NmPessoa;
                mtxtCPF.Text = pessoa.NrCPF;
                dtpNascimento.Value = pessoa.DtNascimento;
                switch (pessoa.DsEstadoCivil)
                {
                    case 'S':
                        cbEstadosCivis.Text = "Solteiro";
                        break;
                    case 'C':
                        cbEstadosCivis.Text = "Casado";
                        break;
                    default:
                        cbEstadosCivis.Text = "Divorciado";
                        break;
                }
                rbtnMasculino.Checked = pessoa.DsSexo == 'M';
                rbtnFeminino.Checked = pessoa.DsSexo == 'F';
                txtEmail.Text = pessoa.DsEmail;
                mtxtTelefone.Text = pessoa.NrTelefone;
                chkRecebeSMS.Checked = pessoa.BtRecebeSMS;
                chkRecebeEmail.Checked = pessoa.BtRecebeEmail;

                
            }
            #endregion
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            carregarPessoas();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CdPessoa =Convert.ToInt32(txtCodigo.Text);
            pessoa.NmPessoa = txtNome.Text;
            pessoa.NrCPF = mtxtCPF.Text;
            pessoa.DtNascimento = dtpNascimento.Value;
            switch (cbEstadosCivis.Text)
            {
                case "Solteiro":
                    pessoa.DsEstadoCivil = 'S';
                    break;
                case "Casado":
                    pessoa.DsEstadoCivil = 'C';
                    break;
                default:
                    pessoa.DsEstadoCivil = 'D';
                    break;
            }
            pessoa.DsSexo = rbtnMasculino.Checked ? 'M' : 'F';
            pessoa.DsEmail = txtEmail.Text;
            pessoa.NrTelefone = mtxtTelefone.Text;
            pessoa.BtRecebeEmail = chkRecebeEmail.Checked;
            pessoa.BtRecebeSMS = chkRecebeSMS.Checked;


            PessoaDAL pDAL = new PessoaDAL();
            pDAL.AtualizarPessoa(pessoa);

            MessageBox.Show("Pessoa atualizada com sucesso.");
            LimparCampos();
            carregarPessoas();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CdPessoa = Convert.ToInt32(txtCodigo.Text);

            PessoaDAL pdal = new PessoaDAL();
            pdal.ExcluirPessoa(pessoa.CdPessoa);
            LimparCampos();
            carregarPessoas();
        }
        #endregion


        #region Metodos
        internal void DesativarCampos()
        {
            txtNome.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            txtEmail.ReadOnly = true;
            mtxtCPF.ReadOnly = true;
            mtxtTelefone.ReadOnly = true;
            EstadoCivil.ReadOnly = true;
            recebeSMS.ReadOnly = true;
            RecebeEmail.ReadOnly = true;
            mtxtTelefone.ReadOnly = true;
            Sexo.ReadOnly = true;
        }
        internal void AtivarCampos()
        {
            txtNome.ReadOnly = false;
            txtCodigo.ReadOnly = false;
            txtEmail.ReadOnly = false;
            mtxtCPF.ReadOnly = false;
            mtxtTelefone.ReadOnly = false;
            EstadoCivil.ReadOnly = false;
            recebeSMS.ReadOnly = false;
            RecebeEmail.ReadOnly = false;
            mtxtTelefone.ReadOnly = false;
            Sexo.ReadOnly = false;
        }
        internal void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            mtxtCPF.Text = string.Empty;
            dtpNascimento.Text = null;
            cbEstadosCivis.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtxtTelefone.Text = string.Empty;
            chkRecebeEmail.Checked = false;
            chkRecebeSMS.Checked = false;
            rbtnMasculino.Checked = true;
        }
        private void carregarPessoas()
        {
            PessoaDAL pes = new PessoaDAL();
            dgvPessoas.DataSource = pes.ListarPessoas();

        }

        public void CadastrarPessoa()
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.NmPessoa = txtNome.Text;
            objPessoa.NrCPF = mtxtCPF.Text;
            objPessoa.DtNascimento = dtpNascimento.Value;
            switch (cbEstadosCivis.Text)
            {
                case "Solteiro":
                    objPessoa.DsEstadoCivil = 'S';
                    break;
                case "Casado":
                    objPessoa.DsEstadoCivil = 'C';
                    break;
                default:
                    objPessoa.DsEstadoCivil = 'D';
                    break;
            }
            objPessoa.DsSexo = rbtnMasculino.Checked ? 'M' : 'F';
            objPessoa.DsEmail = txtEmail.Text;
            objPessoa.NrTelefone = mtxtTelefone.Text;
            objPessoa.BtRecebeSMS = chkRecebeSMS.Checked;
            objPessoa.BtRecebeEmail = chkRecebeEmail.Checked;


            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(objPessoa);

            MessageBox.Show("Pessoa adicionada com sucesso.");
            LimparCampos();
            carregarPessoas();
        }

        #endregion

        private void btnLIstaCP_Click(object sender, EventArgs e)
        {
            FrmListagemPessoas tela = new FrmListagemPessoas();
            tela.Show();
        }

        private void dgvPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
