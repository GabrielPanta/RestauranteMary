namespace RestauranteMary
{
    partial class FrmBuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarUsuario));
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.rbtContenga = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.rbtTermine = new System.Windows.Forms.RadioButton();
            this.rbtEmpiece = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.consultaBuscarToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.apellidosToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.consultaBuscarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRestauranteMary = new RestauranteMary.DSRestauranteMary();
            this.usuarioTableAdapter = new RestauranteMary.DSRestauranteMaryTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.consultaBuscarToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRestauranteMary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AllowUserToOrderColumns = true;
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.AutoGenerateColumns = false;
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn});
            this.dgvBusqueda.DataSource = this.usuarioBindingSource;
            this.dgvBusqueda.Location = new System.Drawing.Point(0, 128);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(680, 243);
            this.dgvBusqueda.TabIndex = 0;
            // 
            // rbtContenga
            // 
            this.rbtContenga.AutoSize = true;
            this.rbtContenga.Checked = true;
            this.rbtContenga.Location = new System.Drawing.Point(6, 28);
            this.rbtContenga.Name = "rbtContenga";
            this.rbtContenga.Size = new System.Drawing.Size(71, 17);
            this.rbtContenga.TabIndex = 2;
            this.rbtContenga.TabStop = true;
            this.rbtContenga.Text = "Contenga";
            this.rbtContenga.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.rbtIgual);
            this.groupBox1.Controls.Add(this.rbtTermine);
            this.groupBox1.Controls.Add(this.rbtEmpiece);
            this.groupBox1.Controls.Add(this.rbtContenga);
            this.groupBox1.Location = new System.Drawing.Point(4, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Criterio";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(405, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 31);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Location = new System.Drawing.Point(325, 28);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(63, 17);
            this.rbtIgual.TabIndex = 5;
            this.rbtIgual.TabStop = true;
            this.rbtIgual.Text = "Igual a..";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // rbtTermine
            // 
            this.rbtTermine.AutoSize = true;
            this.rbtTermine.Location = new System.Drawing.Point(220, 28);
            this.rbtTermine.Name = "rbtTermine";
            this.rbtTermine.Size = new System.Drawing.Size(69, 17);
            this.rbtTermine.TabIndex = 4;
            this.rbtTermine.TabStop = true;
            this.rbtTermine.Text = "Termine..";
            this.rbtTermine.UseVisualStyleBackColor = true;
            // 
            // rbtEmpiece
            // 
            this.rbtEmpiece.AutoSize = true;
            this.rbtEmpiece.Location = new System.Drawing.Point(115, 28);
            this.rbtEmpiece.Name = "rbtEmpiece";
            this.rbtEmpiece.Size = new System.Drawing.Size(72, 17);
            this.rbtEmpiece.TabIndex = 3;
            this.rbtEmpiece.TabStop = true;
            this.rbtEmpiece.Text = "Empiece..";
            this.rbtEmpiece.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(546, 54);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(546, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // consultaBuscarToolStrip
            // 
            this.consultaBuscarToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.consultaBuscarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel1,
            this.nombreToolStripTextBox,
            this.apellidosToolStripLabel1,
            this.apellidosToolStripTextBox,
            this.consultaBuscarToolStripButton});
            this.consultaBuscarToolStrip.Location = new System.Drawing.Point(9, 9);
            this.consultaBuscarToolStrip.Name = "consultaBuscarToolStrip";
            this.consultaBuscarToolStrip.Size = new System.Drawing.Size(352, 25);
            this.consultaBuscarToolStrip.TabIndex = 6;
            this.consultaBuscarToolStrip.Text = "consultaBuscarToolStrip";
            // 
            // nombreToolStripLabel1
            // 
            this.nombreToolStripLabel1.Name = "nombreToolStripLabel1";
            this.nombreToolStripLabel1.Size = new System.Drawing.Size(54, 22);
            this.nombreToolStripLabel1.Text = "Nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // apellidosToolStripLabel1
            // 
            this.apellidosToolStripLabel1.Name = "apellidosToolStripLabel1";
            this.apellidosToolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.apellidosToolStripLabel1.Text = "Apellidos:";
            // 
            // apellidosToolStripTextBox
            // 
            this.apellidosToolStripTextBox.Name = "apellidosToolStripTextBox";
            this.apellidosToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // consultaBuscarToolStripButton
            // 
            this.consultaBuscarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBuscarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("consultaBuscarToolStripButton.Image")));
            this.consultaBuscarToolStripButton.Name = "consultaBuscarToolStripButton";
            this.consultaBuscarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.consultaBuscarToolStripButton.Text = "ConsultaBuscar";
            this.consultaBuscarToolStripButton.Click += new System.EventHandler(this.ConsultaBuscarToolStripButton_Click);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dSRestauranteMary;
            // 
            // dSRestauranteMary
            // 
            this.dSRestauranteMary.DataSetName = "DSRestauranteMary";
            this.dSRestauranteMary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 369);
            this.Controls.Add(this.consultaBuscarToolStrip);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBusqueda);
            this.Name = "FrmBuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuario";
            this.Load += new System.EventHandler(this.FrmBuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.consultaBuscarToolStrip.ResumeLayout(false);
            this.consultaBuscarToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRestauranteMary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda;
        private DSRestauranteMary dSRestauranteMary;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DSRestauranteMaryTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rbtContenga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.RadioButton rbtTermine;
        private System.Windows.Forms.RadioButton rbtEmpiece;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip consultaBuscarToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellidosToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox apellidosToolStripTextBox;
        private System.Windows.Forms.ToolStripButton consultaBuscarToolStripButton;
    }
}