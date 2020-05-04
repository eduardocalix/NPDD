namespace Restaurante
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.dgvInsumosInv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBuscarInsumo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoInsumo = new System.Windows.Forms.Button();
            this.btnModificarInsumo = new System.Windows.Forms.Button();
            this.btnEliminarInsumo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadInsumo = new System.Windows.Forms.TextBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.lblCantidadInsumo = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.grpInventario = new System.Windows.Forms.GroupBox();
            this.txtCantMinima = new System.Windows.Forms.TextBox();
            this.lblCantMinima = new System.Windows.Forms.Label();
            this.cmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosInv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarInsumo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.grpInventario.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInsumosInv
            // 
            this.dgvInsumosInv.AllowUserToAddRows = false;
            this.dgvInsumosInv.AllowUserToDeleteRows = false;
            this.dgvInsumosInv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInsumosInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumosInv.Location = new System.Drawing.Point(458, 429);
            this.dgvInsumosInv.Name = "dgvInsumosInv";
            this.dgvInsumosInv.ReadOnly = true;
            this.dgvInsumosInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumosInv.Size = new System.Drawing.Size(339, 148);
            this.dgvInsumosInv.TabIndex = 47;
            this.dgvInsumosInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumosInv_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvBuscarInsumo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel1.Location = new System.Drawing.Point(458, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 409);
            this.panel1.TabIndex = 46;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 62);
            this.panel2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "Información de Insumos";
            // 
            // dgvBuscarInsumo
            // 
            this.dgvBuscarInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarInsumo.Location = new System.Drawing.Point(18, 262);
            this.dgvBuscarInsumo.Name = "dgvBuscarInsumo";
            this.dgvBuscarInsumo.Size = new System.Drawing.Size(309, 129);
            this.dgvBuscarInsumo.TabIndex = 18;
            this.dgvBuscarInsumo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarInsumo_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoInsumo);
            this.groupBox1.Controls.Add(this.btnModificarInsumo);
            this.groupBox1.Controls.Add(this.btnEliminarInsumo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidadInsumo);
            this.groupBox1.Controls.Add(this.txtNombreInsumo);
            this.groupBox1.Controls.Add(this.btnAgregarInsumo);
            this.groupBox1.Controls.Add(this.lblCantidadInsumo);
            this.groupBox1.Location = new System.Drawing.Point(11, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 312);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // btnNuevoInsumo
            // 
            this.btnNuevoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnNuevoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoInsumo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevoInsumo.Location = new System.Drawing.Point(175, 54);
            this.btnNuevoInsumo.Name = "btnNuevoInsumo";
            this.btnNuevoInsumo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevoInsumo.TabIndex = 42;
            this.btnNuevoInsumo.Text = "Nuevo";
            this.btnNuevoInsumo.UseVisualStyleBackColor = false;
            this.btnNuevoInsumo.Click += new System.EventHandler(this.btnNuevoInsumo_Click);
            // 
            // btnModificarInsumo
            // 
            this.btnModificarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnModificarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarInsumo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificarInsumo.Location = new System.Drawing.Point(125, 142);
            this.btnModificarInsumo.Name = "btnModificarInsumo";
            this.btnModificarInsumo.Size = new System.Drawing.Size(75, 25);
            this.btnModificarInsumo.TabIndex = 19;
            this.btnModificarInsumo.Text = "Modificar";
            this.btnModificarInsumo.UseVisualStyleBackColor = false;
            this.btnModificarInsumo.Click += new System.EventHandler(this.btnModificarInsumo_Click);
            // 
            // btnEliminarInsumo
            // 
            this.btnEliminarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnEliminarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarInsumo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminarInsumo.Location = new System.Drawing.Point(234, 142);
            this.btnEliminarInsumo.Name = "btnEliminarInsumo";
            this.btnEliminarInsumo.Size = new System.Drawing.Size(75, 25);
            this.btnEliminarInsumo.TabIndex = 20;
            this.btnEliminarInsumo.Text = "Eliminar";
            this.btnEliminarInsumo.UseVisualStyleBackColor = false;
            this.btnEliminarInsumo.Click += new System.EventHandler(this.btnEliminarInsumo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar.Location = new System.Drawing.Point(74, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descripción";
            // 
            // txtCantidadInsumo
            // 
            this.txtCantidadInsumo.Location = new System.Drawing.Point(91, 92);
            this.txtCantidadInsumo.Name = "txtCantidadInsumo";
            this.txtCantidadInsumo.Size = new System.Drawing.Size(109, 22);
            this.txtCantidadInsumo.TabIndex = 17;
            this.txtCantidadInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadInsumo_KeyPress);
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(103, 21);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(213, 22);
            this.txtNombreInsumo.TabIndex = 15;
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnAgregarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarInsumo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(11, 142);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(75, 25);
            this.btnAgregarInsumo.TabIndex = 18;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // lblCantidadInsumo
            // 
            this.lblCantidadInsumo.AutoSize = true;
            this.lblCantidadInsumo.Location = new System.Drawing.Point(6, 95);
            this.lblCantidadInsumo.Name = "lblCantidadInsumo";
            this.lblCantidadInsumo.Size = new System.Drawing.Size(62, 16);
            this.lblCantidadInsumo.TabIndex = 41;
            this.lblCantidadInsumo.Text = "Cantidad";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnReportes);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Location = new System.Drawing.Point(353, 107);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(102, 170);
            this.pnlBotones.TabIndex = 45;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReportes.Location = new System.Drawing.Point(13, 129);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 25);
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificar.Location = new System.Drawing.Point(13, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 25);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar.Location = new System.Drawing.Point(13, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Location = new System.Drawing.Point(13, 98);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevo.Location = new System.Drawing.Point(13, 11);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(13, 429);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(439, 148);
            this.dgvInventario.TabIndex = 44;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // grpInventario
            // 
            this.grpInventario.Controls.Add(this.txtCantMinima);
            this.grpInventario.Controls.Add(this.lblCantMinima);
            this.grpInventario.Controls.Add(this.cmbCategoriaProducto);
            this.grpInventario.Controls.Add(this.lblCategoria);
            this.grpInventario.Controls.Add(this.cmbTipoProducto);
            this.grpInventario.Controls.Add(this.lblTipoProducto);
            this.grpInventario.Controls.Add(this.txtCantidad);
            this.grpInventario.Controls.Add(this.lblCantidad);
            this.grpInventario.Controls.Add(this.txtPrecioVenta);
            this.grpInventario.Controls.Add(this.lblPrecioVenta);
            this.grpInventario.Controls.Add(this.cmbProveedor);
            this.grpInventario.Controls.Add(this.lblProveedor);
            this.grpInventario.Controls.Add(this.lblDescripcion);
            this.grpInventario.Controls.Add(this.txtCosto);
            this.grpInventario.Controls.Add(this.lblCosto);
            this.grpInventario.Controls.Add(this.txtDescripcion);
            this.grpInventario.Controls.Add(this.txtId);
            this.grpInventario.Controls.Add(this.lblId);
            this.grpInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpInventario.Location = new System.Drawing.Point(16, 65);
            this.grpInventario.Name = "grpInventario";
            this.grpInventario.Size = new System.Drawing.Size(324, 358);
            this.grpInventario.TabIndex = 43;
            this.grpInventario.TabStop = false;
            // 
            // txtCantMinima
            // 
            this.txtCantMinima.Location = new System.Drawing.Point(102, 215);
            this.txtCantMinima.Name = "txtCantMinima";
            this.txtCantMinima.Size = new System.Drawing.Size(109, 22);
            this.txtCantMinima.TabIndex = 6;
            this.txtCantMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantMinima_KeyPress);
            // 
            // lblCantMinima
            // 
            this.lblCantMinima.AutoSize = true;
            this.lblCantMinima.Location = new System.Drawing.Point(11, 218);
            this.lblCantMinima.Name = "lblCantMinima";
            this.lblCantMinima.Size = new System.Drawing.Size(62, 16);
            this.lblCantMinima.TabIndex = 43;
            this.lblCantMinima.Text = "Cant. Min";
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaProducto.FormattingEnabled = true;
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(102, 248);
            this.cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            this.cmbCategoriaProducto.Size = new System.Drawing.Size(213, 24);
            this.cmbCategoriaProducto.TabIndex = 7;
            this.cmbCategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaProducto_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 251);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 16);
            this.lblCategoria.TabIndex = 41;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(102, 287);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(213, 24);
            this.cmbTipoProducto.TabIndex = 8;
            this.cmbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProducto_SelectedIndexChanged_1);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(3, 290);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(93, 16);
            this.lblTipoProducto.TabIndex = 39;
            this.lblTipoProducto.Text = "Tipo Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(102, 178);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(109, 22);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(11, 181);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 16);
            this.lblCantidad.TabIndex = 37;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(102, 136);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(109, 22);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(11, 139);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(85, 16);
            this.lblPrecioVenta.TabIndex = 35;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(102, 328);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(213, 24);
            this.cmbProveedor.TabIndex = 9;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(11, 331);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(72, 16);
            this.lblProveedor.TabIndex = 33;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(11, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(102, 98);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(109, 22);
            this.txtCosto.TabIndex = 3;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(11, 101);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(43, 16);
            this.lblCosto.TabIndex = 28;
            this.lblCosto.Text = "Costo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(102, 42);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(213, 46);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(102, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(213, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 16);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Id";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Location = new System.Drawing.Point(16, 3);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(337, 62);
            this.pnlTitulo.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Información de Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 79);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(801, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(29, 34);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.TabStop = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvInsumosInv);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.grpInventario);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosInv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarInsumo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.grpInventario.ResumeLayout(false);
            this.grpInventario.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvInsumosInv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBuscarInsumo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevoInsumo;
        private System.Windows.Forms.Button btnModificarInsumo;
        private System.Windows.Forms.Button btnEliminarInsumo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadInsumo;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.Label lblCantidadInsumo;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.GroupBox grpInventario;
        private System.Windows.Forms.TextBox txtCantMinima;
        private System.Windows.Forms.Label lblCantMinima;
        private System.Windows.Forms.ComboBox cmbCategoriaProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
    }
}