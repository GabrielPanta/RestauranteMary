using CADRestauranteMary;
using System;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmPlato : Form
    {
        private int i = 0;
        public bool nuevo;
        public FrmPlato()
        {
            InitializeComponent();
        }

        private void FrmPlato_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = CADPlato.GetData();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIdPlato.Text = dgvDatos.Rows[i].Cells["IdPlato"].Value.ToString();
            txtNombre.Text = dgvDatos.Rows[i].Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = dgvDatos.Rows[i].Cells["Descripcion"].Value.ToString();
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

            txtIdPlato.ReadOnly = true;
            txtNombre.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
        }

        private void Tsbnuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarCampos();
            HabilitarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdPlato.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
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

            txtIdPlato.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
        }

        private void Tsbguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                CADPlato.InsertPlato(txtNombre.Text, txtDescripcion.Text);
            }
            else
            {
                CADPlato.UpdatePlato(txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(txtIdPlato.Text));
            }
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADPlato.GetData();
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
            return true;
        }

        private void Tsbeliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estas Seguro de Borrar el Registro Actual?", "Confirmación", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            CADPlato.DeletePlato(Convert.ToInt32(txtIdPlato.Text));
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADPlato.GetData();
            if (i != 0) i--;
            MostrarDatos();
        }
    }
}
