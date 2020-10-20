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

namespace GUI
{
    public partial class FrmListagemPessoas : Form
    {
        public FrmListagemPessoas()
        {
            InitializeComponent();
        }
        private void FrmListagemPessoas_Load(object sender, EventArgs e)
        {
            carregarPessoas();
        }
        public void carregarPessoas()
        {
            PessoaDAL pdal = new PessoaDAL();
            dgPessoas.DataSource = pdal.ListarPessoasFilters(txtNome.Text, txtEmail.Text);
            
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;


            carregarPessoas();
        }

        
    }
}
