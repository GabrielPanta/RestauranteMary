namespace RestauranteMary
{
    partial class FrmUsuario
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.dSRestauranteMary = new RestauranteMary.DSRestauranteMary();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new RestauranteMary.DSRestauranteMaryTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new RestauranteMary.DSRestauranteMaryTableAdapters.TableAdapterManager();
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.tsbElimina = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSRestauranteMary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(26, 77);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(11, 51);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 4;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new System.Drawing.Point(5, 103);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(64, 13);
            contraseñaLabel.TabIndex = 6;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(265, 51);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(260, 80);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 10;
            apellidosLabel.Text = "Apellidos:";
            // 
            // dSRestauranteMary
            // 
            this.dSRestauranteMary.DataSetName = "DSRestauranteMary";
            this.dSRestauranteMary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dSRestauranteMary;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CocineroTableAdapter = null;
            this.tableAdapterManager.DetalleFacturaTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.MesaTableAdapter = null;
            this.tableAdapterManager.MosoTableAdapter = null;
            this.tableAdapterManager.PlatoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestauranteMary.DSRestauranteMaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = null;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = null;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbEditar,
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbElimina,
            this.tsbBuscar});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(738, 25);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.RightToLeftAutoMirrorImage = true;
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Agregar nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.TsbNuevo_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // tsbElimina
            // 
            this.tsbElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbElimina.Image = ((System.Drawing.Image)(resources.GetObject("tsbElimina.Image")));
            this.tsbElimina.Name = "tsbElimina";
            this.tsbElimina.RightToLeftAutoMirrorImage = true;
            this.tsbElimina.Size = new System.Drawing.Size(23, 22);
            this.tsbElimina.Text = "Eliminar";
            this.tsbElimina.Click += new System.EventHandler(this.TsbElimina_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Enabled = false;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar datos";
            this.tsbGuardar.Click += new System.EventHandler(this.UsuarioBindingNavigatorSaveItem_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.TsbCancelar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.TsbBuscar_Click);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(0, 172);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(738, 258);
            this.usuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(75, 74);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(168, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(75, 48);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.ReadOnly = true;
            this.idUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idUsuarioTextBox.TabIndex = 5;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Contraseña", true));
            this.contraseñaTextBox.Location = new System.Drawing.Point(75, 100);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.ReadOnly = true;
            this.contraseñaTextBox.Size = new System.Drawing.Size(168, 20);
            this.contraseñaTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(318, 48);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(186, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(318, 77);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.ReadOnly = true;
            this.apellidosTextBox.Size = new System.Drawing.Size(186, 20);
            this.apellidosTextBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(585, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(this.idUsuarioTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRestauranteMary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSRestauranteMary dSRestauranteMary;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DSRestauranteMaryTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private DSRestauranteMaryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton tsbElimina;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}