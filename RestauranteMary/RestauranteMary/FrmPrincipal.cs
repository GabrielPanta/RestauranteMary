using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MosoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente miform = new FrmCliente();
            miform.MdiParent = this;
            miform.Show();
            
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MesaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CocinerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCocinero miform = new FrmCocinero();
            miform.MdiParent = this;
            miform.Show();
        }
    }
}
