using CADRestauranteMary;
using System;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                errorProvider1.SetError(txtCodigo,"Debe Ingresar Codigo");
                txtCodigo.Focus();
                return;
            }
            errorProvider1.SetError(txtCodigo,"");

            if (txtContraseña.Text == "")
            {
                errorProvider1.SetError(txtContraseña, "Debe Ingresar Contraseña");
                txtContraseña.Focus();
                return;
            }
            errorProvider1.SetError(txtCodigo, "");

            if (!CADUsuario.ValidarUsuario(txtCodigo.Text, txtContraseña.Text))
            {
                MessageBox.Show("Codigo o Contraseña no validos", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Text = "";
                txtContraseña.Text = "";
                txtCodigo.Focus();
                return;
            }
            FrmPrincipal miform = new FrmPrincipal();
            miform.Show();
            this.Hide();
        }
    }
}
