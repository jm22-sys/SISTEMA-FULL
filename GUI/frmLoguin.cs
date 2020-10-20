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
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text;
            var pass = txtPass.Text;

            string userI = "adm";
            string passI = "123";

            if (user == userI && pass == passI)
            {
                
            }
        }
    }
}
