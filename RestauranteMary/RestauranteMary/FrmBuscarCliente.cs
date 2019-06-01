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
    public partial class FrmBuscarCliente : Form
    {
        private int idCliente;

        public int IdCliente { get => idCliente; }

        public FrmBuscarCliente()
        {
         
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSRestauranteMary.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dSRestauranteMary.Cliente);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            string nombre, apellidos;
            if (rbtContenga.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                apellidos = "%" + apellidosToolStripTextBox.Text + "%";
            }else if (rbtEmpiece.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                apellidos = "%" + apellidosToolStripTextBox.Text + "%";
            }else if (rbtTermine.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                apellidos = "%" + apellidosToolStripTextBox.Text + "%";
            }else if (rbtIgual.Checked == true)
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
                this.clienteTableAdapter.FillBy(this.dSRestauranteMary.Cliente,nombre,apellidos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnQuitarfiltros_Click(object sender, EventArgs e)
        {
            nombreToolStripTextBox.Text = "";
            apellidosToolStripTextBox.Text = "";
            FillByToolStripButton_Click(sender, e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            idCliente = 0;
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                idCliente = 0;
            }
            else if (dgvDatos.SelectedRows.Count != 0)
            {
                idCliente = (int)dgvDatos.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                idCliente = (int)dgvDatos.Rows[0].Cells[0].Value;
            }
            this.Close();
        }
    }
}
