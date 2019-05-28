using CADRestauranteMary;
using System;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmCocinero : Form
    {
        private int i = 0;
        private bool nuevo;
        public FrmCocinero()
        {
            InitializeComponent();
        }

        private void FrmCocinero_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = CADCocinero.GetData();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIdCocinero.Text = dgvDatos.Rows[i].Cells["IdCocinero"].Value.ToString();
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

            txtIdCocinero.ReadOnly = true;
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

            txtIdCocinero.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;
        }


        private void LimpiarCampos()
        {
            txtIdCocinero.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
        }

        private void Tsbnuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarCampos();
            HabilitarCampos();
        }

        private void Tsbguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                CADCocinero.InsertCocinero(txtNombre.Text, txtApellidos.Text);
            }
            else
            {
                CADCocinero.UpdateCocinero(txtNombre.Text, txtApellidos.Text, Convert.ToInt32(txtIdCocinero.Text));
            }
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCocinero.GetData();
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
            CADCocinero.DeleteCocinero(Convert.ToInt32(txtIdCocinero.Text));
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCocinero.GetData();
            if (i != 0) i--;//muestra el registro anterior
            MostrarDatos();
        }
    }
}
