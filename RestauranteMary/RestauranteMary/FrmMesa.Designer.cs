namespace RestauranteMary
{
    partial class FrmMesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesa));
            System.Windows.Forms.PictureBox pictureBox1;
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtNumComensales = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrimero = new System.Windows.Forms.ToolStripButton();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.tsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.tsbUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbmodificar = new System.Windows.Forms.ToolStripButton();
            this.tsbnuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbeliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbguardar = new System.Windows.Forms.ToolStripButton();
            this.tsbcancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbbuscar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Enabled = false;
            this.dgvDatos.Location = new System.Drawing.Point(0, 164);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(604, 210);
            this.dgvDatos.TabIndex = 35;
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.Location = new System.Drawing.Point(82, 54);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.ReadOnly = true;
            this.txtIdMesa.Size = new System.Drawing.Size(75, 20);
            this.txtIdMesa.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "IdMesa";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(82, 80);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(329, 20);
            this.txtUbicacion.TabIndex = 32;
            // 
            // txtNumComensales
            // 
            this.txtNumComensales.Location = new System.Drawing.Point(196, 106);
            this.txtNumComensales.Name = "txtNumComensales";
            this.txtNumComensales.ReadOnly = true;
            this.txtNumComensales.Size = new System.Drawing.Size(215, 20);
            this.txtNumComensales.TabIndex = 31;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(21, 83);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(55, 13);
            this.lab.TabIndex = 30;
            this.lab.Text = "Ubicación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Número Maximo de Comensales";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrimero,
            this.tsbAnterior,
            this.tsbSiguiente,
            this.tsbUltimo,
            this.toolStripSeparator1,
            this.tsbmodificar,
            this.tsbnuevo,
            this.tsbeliminar,
            this.tsbguardar,
            this.tsbcancelar,
            this.tsbbuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrimero
            // 
            this.tsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimero.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrimero.Image")));
            this.tsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimero.Name = "tsbPrimero";
            this.tsbPrimero.Size = new System.Drawing.Size(23, 22);
            this.tsbPrimero.Text = "toolStripButton1";
            this.tsbPrimero.ToolTipText = "va al primero";
            this.tsbPrimero.Click += new System.EventHandler(this.TsbPrimero_Click);
            // 
            // tsbAnterior
            // 
            this.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnterior.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnterior.Image")));
            this.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Size = new System.Drawing.Size(23, 22);
            this.tsbAnterior.Text = "toolStripButton2";
            this.tsbAnterior.ToolTipText = "va al anterior";
            this.tsbAnterior.Click += new System.EventHandler(this.TsbAnterior_Click);
            // 
            // tsbSiguiente
            // 
            this.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("tsbSiguiente.Image")));
            this.tsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSiguiente.Name = "tsbSiguiente";
            this.tsbSiguiente.Size = new System.Drawing.Size(23, 22);
            this.tsbSiguiente.Text = "toolStripButton3";
            this.tsbSiguiente.ToolTipText = "va al siguiente";
            this.tsbSiguiente.Click += new System.EventHandler(this.TsbSiguiente_Click);
            // 
            // tsbUltimo
            // 
            this.tsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUltimo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUltimo.Image")));
            this.tsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUltimo.Name = "tsbUltimo";
            this.tsbUltimo.Size = new System.Drawing.Size(23, 22);
            this.tsbUltimo.Text = "toolStripButton4";
            this.tsbUltimo.ToolTipText = "va al ultimo";
            this.tsbUltimo.Click += new System.EventHandler(this.TsbUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbmodificar
            // 
            this.tsbmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbmodificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbmodificar.Image")));
            this.tsbmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbmodificar.Name = "tsbmodificar";
            this.tsbmodificar.Size = new System.Drawing.Size(23, 22);
            this.tsbmodificar.Text = "toolStripButton5";
            this.tsbmodificar.ToolTipText = "editar";
            this.tsbmodificar.Click += new System.EventHandler(this.Tsbmodificar_Click);
            // 
            // tsbnuevo
            // 
            this.tsbnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbnuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbnuevo.Image")));
            this.tsbnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnuevo.Name = "tsbnuevo";
            this.tsbnuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbnuevo.Text = "toolStripButton6";
            this.tsbnuevo.ToolTipText = "nuevo";
            this.tsbnuevo.Click += new System.EventHandler(this.Tsbnuevo_Click);
            // 
            // tsbeliminar
            // 
            this.tsbeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbeliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbeliminar.Image")));
            this.tsbeliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbeliminar.Name = "tsbeliminar";
            this.tsbeliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbeliminar.Text = "toolStripButton7";
            this.tsbeliminar.ToolTipText = "eliminar";
            this.tsbeliminar.Click += new System.EventHandler(this.Tsbeliminar_Click);
            // 
            // tsbguardar
            // 
            this.tsbguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbguardar.Enabled = false;
            this.tsbguardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbguardar.Image")));
            this.tsbguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbguardar.Name = "tsbguardar";
            this.tsbguardar.Size = new System.Drawing.Size(23, 22);
            this.tsbguardar.Text = "toolStripButton8";
            this.tsbguardar.ToolTipText = "guardar";
            this.tsbguardar.Click += new System.EventHandler(this.Tsbguardar_Click);
            // 
            // tsbcancelar
            // 
            this.tsbcancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbcancelar.Enabled = false;
            this.tsbcancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbcancelar.Image")));
            this.tsbcancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbcancelar.Name = "tsbcancelar";
            this.tsbcancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbcancelar.Text = "toolStripButton9";
            this.tsbcancelar.ToolTipText = "cancelar";
            this.tsbcancelar.Click += new System.EventHandler(this.Tsbcancelar_Click);
            // 
            // tsbbuscar
            // 
            this.tsbbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbbuscar.Image")));
            this.tsbbuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbuscar.Name = "tsbbuscar";
            this.tsbbuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbbuscar.Text = "toolStripButton10";
            this.tsbbuscar.ToolTipText = "buscar";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(435, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(131, 121);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 371);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtIdMesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNumComensales);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMesa";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.FrmMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtIdMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtNumComensales;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrimero;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton tsbSiguiente;
        private System.Windows.Forms.ToolStripButton tsbUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbmodificar;
        private System.Windows.Forms.ToolStripButton tsbnuevo;
        private System.Windows.Forms.ToolStripButton tsbeliminar;
        private System.Windows.Forms.ToolStripButton tsbguardar;
        private System.Windows.Forms.ToolStripButton tsbcancelar;
        private System.Windows.Forms.ToolStripButton tsbbuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}