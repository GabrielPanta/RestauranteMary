namespace RestauranteMary
{
    partial class FrmBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarCliente));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRestauranteMary = new RestauranteMary.DSRestauranteMary();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.clienteTableAdapter = new RestauranteMary.DSRestauranteMaryTableAdapters.ClienteTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarfiltros = new System.Windows.Forms.Button();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.rbtTermine = new System.Windows.Forms.RadioButton();
            this.rbtEmpiece = new System.Windows.Forms.RadioButton();
            this.rbtContenga = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRestauranteMary)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.clienteBindingSource;
            this.dgvDatos.Location = new System.Drawing.Point(-2, 128);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(808, 298);
            this.dgvDatos.TabIndex = 0;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSRestauranteMary;
            // 
            // dSRestauranteMary
            // 
            this.dSRestauranteMary.DataSetName = "DSRestauranteMary";
            this.dSRestauranteMary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.apellidosToolStripLabel,
            this.apellidosToolStripTextBox,
            this.tsbBuscar});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(804, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(54, 22);
            this.nombreToolStripLabel.Text = "Nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // apellidosToolStripLabel
            // 
            this.apellidosToolStripLabel.Name = "apellidosToolStripLabel";
            this.apellidosToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.apellidosToolStripLabel.Text = "Apellidos:";
            // 
            // apellidosToolStripTextBox
            // 
            this.apellidosToolStripTextBox.Name = "apellidosToolStripTextBox";
            this.apellidosToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "FillBy";
            this.tsbBuscar.ToolTipText = "Buscar\r\n";
            this.tsbBuscar.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarfiltros);
            this.groupBox1.Controls.Add(this.rbtIgual);
            this.groupBox1.Controls.Add(this.rbtTermine);
            this.groupBox1.Controls.Add(this.rbtEmpiece);
            this.groupBox1.Controls.Add(this.rbtContenga);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Criterio";
            // 
            // btnQuitarfiltros
            // 
            this.btnQuitarfiltros.Location = new System.Drawing.Point(450, 25);
            this.btnQuitarfiltros.Name = "btnQuitarfiltros";
            this.btnQuitarfiltros.Size = new System.Drawing.Size(121, 23);
            this.btnQuitarfiltros.TabIndex = 4;
            this.btnQuitarfiltros.Text = "Quitar Filtros";
            this.btnQuitarfiltros.UseVisualStyleBackColor = true;
            this.btnQuitarfiltros.Click += new System.EventHandler(this.BtnQuitarfiltros_Click);
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Location = new System.Drawing.Point(322, 28);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(66, 17);
            this.rbtIgual.TabIndex = 3;
            this.rbtIgual.Text = "Igual a...";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // rbtTermine
            // 
            this.rbtTermine.AutoSize = true;
            this.rbtTermine.Location = new System.Drawing.Point(217, 28);
            this.rbtTermine.Name = "rbtTermine";
            this.rbtTermine.Size = new System.Drawing.Size(87, 17);
            this.rbtTermine.TabIndex = 2;
            this.rbtTermine.Text = "Termine en...";
            this.rbtTermine.UseVisualStyleBackColor = true;
            // 
            // rbtEmpiece
            // 
            this.rbtEmpiece.AutoSize = true;
            this.rbtEmpiece.Location = new System.Drawing.Point(105, 28);
            this.rbtEmpiece.Name = "rbtEmpiece";
            this.rbtEmpiece.Size = new System.Drawing.Size(93, 17);
            this.rbtEmpiece.TabIndex = 1;
            this.rbtEmpiece.Text = "Empiece por...";
            this.rbtEmpiece.UseVisualStyleBackColor = true;
            // 
            // rbtContenga
            // 
            this.rbtContenga.AutoSize = true;
            this.rbtContenga.Checked = true;
            this.rbtContenga.Location = new System.Drawing.Point(6, 28);
            this.rbtContenga.Name = "rbtContenga";
            this.rbtContenga.Size = new System.Drawing.Size(80, 17);
            this.rbtContenga.TabIndex = 0;
            this.rbtContenga.TabStop = true;
            this.rbtContenga.Text = "Contenga...";
            this.rbtContenga.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(625, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 31);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(625, 88);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 424);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dgvDatos);
            this.Name = "FrmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Buscar Cliente";
            this.Load += new System.EventHandler(this.FrmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRestauranteMary)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private DSRestauranteMary dSRestauranteMary;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DSRestauranteMaryTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellidosToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosToolStripTextBox;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.RadioButton rbtTermine;
        private System.Windows.Forms.RadioButton rbtEmpiece;
        private System.Windows.Forms.RadioButton rbtContenga;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnQuitarfiltros;
    }
}