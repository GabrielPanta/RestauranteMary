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
    public partial class FrmClienteV : Form
    {
        public FrmClienteV()
        {
            InitializeComponent();
        }

        private void ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSRestauranteMary);
            DeshabilitarCampos();
            

        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe Ingresar un Nombre");
                txtNombre.Focus();
                return false;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe Ingresar un Apellido");

                return false;
            }
            errorProvider1.SetError(txtApellidos, "");
            return true;
        }

        private void FrmClienteV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSRestauranteMary.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dSRestauranteMary.Cliente);

        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            tsbEditar.Enabled = false;
            tsbNuevo.Enabled = false;
            tsbBuscar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            tsbGuardar.Enabled = true;


            txtIdCliente.ReadOnly = true;
            txtNombre.ReadOnly = false;
            txtApellidos.ReadOnly = false;
            txtObservaciones.ReadOnly = false;
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            this.clienteBindingSource.CancelEdit();

        }

        private void DeshabilitarCampos()
        {
            tsbEditar.Enabled = true;
            tsbNuevo.Enabled = true;
            tsbCancelar.Enabled = false;
            tsbBuscar.Enabled = true;
            tsbEliminar.Enabled = true;
            tsbGuardar.Enabled = false;


            txtIdCliente.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;
            txtObservaciones.ReadOnly = true;
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            clienteBindingSource.AddNew();

        }

        private void LimpiarCampos()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtObservaciones.Text = "";
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estas Seguro de Borrar el Registro Actual?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            clienteBindingSource.RemoveAt(clienteBindingSource.Position);
        }
    }
}
