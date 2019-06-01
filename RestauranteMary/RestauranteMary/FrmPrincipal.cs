using System;
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
            FrmMoso miform = new FrmMoso();
            miform.MdiParent = this;
            miform.Show();
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
            FrmMesa miform = new FrmMesa();
            miform.MdiParent = this;
            miform.Show();
        }

        private void CocinerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCocinero miform = new FrmCocinero();
            miform.MdiParent = this;
            miform.Show();
        }

        private void PlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlato miform = new FrmPlato();
            miform.MdiParent = this;
            miform.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario miform = new FrmUsuario();
            miform.MdiParent = this;
            miform.Show();
        }
    }
}
