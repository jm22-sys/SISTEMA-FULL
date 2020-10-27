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
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = Models.Criptografia.GetMD5Hash(txtPass.Text);

            

            loginDAL dal = new loginDAL();

            if (dal.auth(user, pass)) 
            {
                this.DialogResult = DialogResult.OK;
            }
            
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
                txtUser.Text = null;
                txtPass.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
