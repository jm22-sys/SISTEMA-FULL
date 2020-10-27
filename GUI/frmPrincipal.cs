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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoas tela = new frmCadastroPessoas();
            tela.MdiParent = this;
            tela.Show();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListagemPessoas tela = new FrmListagemPessoas();
            tela.MdiParent = this;
            tela.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuariosLogin tela = new frmCadastroUsuariosLogin();
            tela.MdiParent = this;
            tela.Show();

        }

        /*private void btnSair_Click(object sender, EventArgs e)
        {
            //Close();
            //DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            

            frmLoguin login = new frmLoguin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                
                Application.Run(new frmPrincipal());

            }
        */
        }
    }
}
