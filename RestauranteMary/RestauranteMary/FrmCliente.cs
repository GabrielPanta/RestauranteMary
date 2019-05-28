using CADRestauranteMary;
using System;
using System.Windows.Forms;

namespace RestauranteMary
{
    public partial class FrmCliente : Form
    {
        private int i = 0;
        private bool nuevo;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

            dgvDatos.DataSource = CADCliente.GetData();
            MostrarRegistro();
        }

        private void MostrarRegistro()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIdCliente.Text = dgvDatos.Rows[i].Cells["IdCliente"].Value.ToString();
            txtNombre.Text = dgvDatos.Rows[i].Cells["Nombre"].Value.ToString();
            txtApellidos.Text = dgvDatos.Rows[i].Cells["Apellidos"].Value.ToString();
            txtObservaciones.Text = dgvDatos.Rows[i].Cells["Observaciones"].Value.ToString();
        }

        private void TsbPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            MostrarRegistro();
        }

        private void TsbAnterior_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            MostrarRegistro();
        }

        private void TsbSiguiente_Click(object sender, EventArgs e)
        {
            if (i >= dgvDatos.Rows.Count - 1) return;
            i++;
            MostrarRegistro();
        }

        private void TsbUltimo_Click(object sender, EventArgs e)
        {
            i = dgvDatos.Rows.Count - 1;
            MostrarRegistro();
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

            txtIdCliente.ReadOnly = true;
            txtNombre.ReadOnly = false;
            txtApellidos.ReadOnly = false;
            txtObservaciones.ReadOnly = false;
        }

        private void Tsbcancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            MostrarRegistro();
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

            txtIdCliente.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;
            txtObservaciones.ReadOnly = true;
        }

        private void Tsbnuevo_Click(object sender, EventArgs e)
        {
            txtApellidos.Text = "";
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtObservaciones.Text = "";
            nuevo = true;
            HabilitarCampos();
        }

        private void Tsbguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                CADCliente.InsertCliente(txtNombre.Text,
                                         txtApellidos.Text,
                                         txtObservaciones.Text);
            }
            else
            {
                CADCliente.UpdateCliente(txtNombre.Text,
                                         txtApellidos.Text,
                                         txtObservaciones.Text,
                                         Convert.ToInt32(txtIdCliente.Text));
            }
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCliente.GetData();
            if (nuevo) TsbUltimo_Click(sender, e);
            MostrarRegistro();
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
            CADCliente.DeleteCliente(Convert.ToInt32(txtIdCliente.Text));
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCliente.GetData();
            if (i != 0) i--;//muestra el registro anterior
            MostrarRegistro();
        }
    }
}
