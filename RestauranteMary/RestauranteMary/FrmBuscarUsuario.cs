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
    public partial class FrmBuscarUsuario : Form
    {
        private int idUsuario;

        public int IdUsuario { get => idUsuario;}

        public FrmBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FrmBuscarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSRestauranteMary.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dSRestauranteMary.Usuario);

        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            nombreToolStripTextBox.Text = "";
            apellidosToolStripTextBox.Text = "";
            this.usuarioTableAdapter.Fill(this.dSRestauranteMary.Usuario);
        }

        private void ConsultaBuscarToolStripButton_Click(object sender, EventArgs e)
        {
            string nombre, apellidos;
            if (rbtContenga.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                apellidos = "%" + apellidosToolStripTextBox.Text + "%";
            }
            else if (rbtEmpiece.Checked == true)
            {
                nombre = nombreToolStripTextBox.Text + "%";
                apellidos = apellidosToolStripTextBox + "%";
            }
            else if (rbtTermine.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text;
                apellidos = "%" + apellidosToolStripTextBox.Text;
            }
            else if (rbtIgual.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                apellidos = "%" + apellidosToolStripTextBox.Text + "%";
            }
            else
            {
                nombre = nombreToolStripTextBox.Text;
                apellidos = apellidosToolStripTextBox.Text;
            }
            try
            {
                this.usuarioTableAdapter.ConsultaBuscar(this.dSRestauranteMary.Usuario,
                    nombre, apellidos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBusqueda.Rows.Count == 0)
            {
                idUsuario = 0;
            }
            else if (dgvBusqueda.SelectedRows.Count != 0)
            {
                idUsuario = (int)dgvBusqueda.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                idUsuario = (int)dgvBusqueda.Rows[0].Cells[0].Value;
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            idUsuario = 0;
            this.Close();
        }
    }
}
