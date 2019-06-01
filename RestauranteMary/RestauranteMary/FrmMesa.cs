using CADRestauranteMary;
using System;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmMesa : Form
    {
        private int i = 0;
        private bool nuevo;
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = CADMesa.GetData();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIdMesa.Text = dgvDatos.Rows[i].Cells["IdMesa"].Value.ToString();
            txtUbicacion.Text = dgvDatos.Rows[i].Cells["Ubicacion"].Value.ToString();
            txtNumComensales.Text = dgvDatos.Rows[i].Cells["NumMaxComensales"].Value.ToString();
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

            txtIdMesa.ReadOnly = true;
            txtUbicacion.ReadOnly = false;
            txtNumComensales.ReadOnly = false;
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

            txtIdMesa.ReadOnly = true;
            txtUbicacion.ReadOnly = true;
            txtNumComensales.ReadOnly = true;
        }

        private void Tsbnuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarCampos();
            HabilitarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdMesa.Text = "";
            txtUbicacion.Text = "";
            txtNumComensales.Text = "";
        }

        private void Tsbguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                CADMesa.InsertMesa(Convert.ToInt32(txtNumComensales.Text), txtUbicacion.Text);
            }
            else
            {
                CADMesa.UpdateMesa(Convert.ToInt32(txtNumComensales.Text), txtUbicacion.Text, Convert.ToInt32(txtIdMesa.Text));
            }
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADMesa.GetData();
            MostrarDatos();
            if (nuevo) TsbUltimo_Click(sender, e);
        }

        private bool ValidarCampos()
        {
            if (txtUbicacion.Text == "")
            {
                errorProvider1.SetError(txtUbicacion, "Debe Ingresar una Ubicación");
                txtUbicacion.Focus();
                return false;
            }
            errorProvider1.SetError(txtUbicacion, "");
            if (txtNumComensales.Text == "")
            {
                errorProvider1.SetError(txtNumComensales, "Debe Ingresar Número de Comensales");
                txtNumComensales.Focus();
                return false;
            }
            errorProvider1.SetError(txtNumComensales, "");
            return true;
        }

        private void Tsbeliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estas Seguro de Borrar el Registro Actual?", "Confirmación", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            CADMesa.DeleteMesa(Convert.ToInt32(txtIdMesa.Text));
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADMesa.GetData();
            if (i != 0) i--;//muestra el registro anterior
            MostrarDatos();
        }
    }
}
