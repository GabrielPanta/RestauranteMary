using CADRestauranteMary;
using System;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmMoso : Form
    {
        private int i = 0;
        private bool nuevo;
        public FrmMoso()
        {
            InitializeComponent();
        }

        private void FrmMoso_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = CADMoso.GetData();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIdMoso.Text = dgvDatos.Rows[i].Cells["IdMoso"].Value.ToString();
            txtNombre.Text = dgvDatos.Rows[i].Cells["Nombre"].Value.ToString();
            txtApellidos.Text = dgvDatos.Rows[i].Cells["Apellidos"].Value.ToString();
        }

        private void TsbPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            MostrarDatos();
        }

        private void TsbAnterior_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            MostrarDatos();
        }

        private void TsbSiguiente_Click(object sender, EventArgs e)
        {
            if (i >= dgvDatos.Rows.Count - 1) return;
            i++;
            MostrarDatos();
        }

        private void TsbUltimo_Click(object sender, EventArgs e)
        {
            i = dgvDatos.Rows.Count - 1;
            MostrarDatos();
        }

        private void Tsbmodificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            tsbAnterior.Enabled = false;
            tsbPrimero.Enabled = false;
            tsbSiguiente.Enabled = false;
            tsbUltimo.Enabled = false;
            tsbnuevo.Enabled = false;
            tsbmodificar.Enabled = false;
            tsbguardar.Enabled = true;
            tsbcancelar.Enabled = true;
            tsbbuscar.Enabled = false;
            tsbeliminar.Enabled = false;

            txtIdMoso.ReadOnly = true;
            txtNombre.ReadOnly = false;
            txtApellidos.ReadOnly = false;
        }

        private void Tsbcancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            MostrarDatos();
        }

        private void DeshabilitarCampos()
        {
            tsbAnterior.Enabled = true;
            tsbPrimero.Enabled = true;
            tsbSiguiente.Enabled = true;
            tsbUltimo.Enabled = true;
            tsbnuevo.Enabled = true;
            tsbmodificar.Enabled = true;
            tsbguardar.Enabled = false;
            tsbcancelar.Enabled = false;
            tsbbuscar.Enabled = true;
            tsbeliminar.Enabled = true;

            txtIdMoso.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;
        }

        private void Tsbnuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarCampos();
            HabilitarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdMoso.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
        }

        private void Tsbguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                CADMoso.InsertMoso(txtNombre.Text, txtApellidos.Text);
            }
            else
            {
                CADMoso.UpdateMoso(txtNombre.Text, txtApellidos.Text, Convert.ToInt32(txtIdMoso.Text));
            }
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADMoso.GetData();
            if (nuevo) TsbUltimo_Click(sender, e);
            MostrarDatos();
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

        private void Tsbeliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estas Seguro de Borrar el Registro Actual?", "Confirmación", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            CADMoso.DeleteMoso(Convert.ToInt32(txtIdMoso.Text));
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADMoso.GetData();
            if (i != 0) i--;//muestra el registro anterior
            MostrarDatos();
        }
    }
}
