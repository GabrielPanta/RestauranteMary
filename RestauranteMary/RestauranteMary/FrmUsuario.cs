using System;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void UsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSRestauranteMary);
            DeshabilitarCampos();
        }

        private bool validarCampos()
        {
            if (codigoTextBox.Text == "")
            {
                errorProvider1.SetError(codigoTextBox, "Debe Ingresar un Codigo");
                codigoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(codigoTextBox, "");
            if (contraseñaTextBox.Text == "")
            {
                errorProvider1.SetError(contraseñaTextBox, "Debe Ingresar una Contraseña");
                contraseñaTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(contraseñaTextBox, "");
            if (nombreTextBox.Text == "")
            {
                errorProvider1.SetError(nombreTextBox, "Debe Ingresar un Codigo");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(nombreTextBox, "");
            if (apellidosTextBox.Text == "")
            {
                errorProvider1.SetError(apellidosTextBox, "Debe Ingresar Apellidos");
                apellidosTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(apellidosTextBox, "");
            return true;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSRestauranteMary.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dSRestauranteMary.Usuario);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            tsbEditar.Enabled = false;
            tsbNuevo.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbBuscar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbElimina.Enabled = false;
            tsbGuardar.Enabled = true;


            idUsuarioTextBox.ReadOnly = true;
            codigoTextBox.ReadOnly = false;
            contraseñaTextBox.ReadOnly = false;
            nombreTextBox.ReadOnly = false;
            apellidosTextBox.ReadOnly = false;
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            this.usuarioBindingSource.CancelEdit();
        }

        private void DeshabilitarCampos()
        {
            tsbEditar.Enabled = true;
            tsbNuevo.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbCancelar.Enabled = false;
            tsbElimina.Enabled = true;
            tsbGuardar.Enabled = false;


            idUsuarioTextBox.ReadOnly = true;
            codigoTextBox.ReadOnly = true;
            contraseñaTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
            apellidosTextBox.ReadOnly = true;
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            usuarioBindingSource.AddNew();
        }

        private void TsbElimina_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estas Seguro de Borrar el Registro Actual?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            usuarioBindingSource.RemoveAt(usuarioBindingSource.Position);
        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario miform = new FrmBuscarUsuario();
            miform.ShowDialog();
            if (miform.IdUsuario == 0) return;
            int position = usuarioBindingSource.Find("IdUsuario", miform.IdUsuario);
            usuarioBindingSource.Position = position;
        }
    }
}
