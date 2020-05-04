namespace Restaurante
{
    partial class frmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.btnBebidas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMesero = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDisminuirCantidad = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAumentarCantidad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.btnComidas = new System.Windows.Forms.Button();
            this.btnLicores = new System.Windows.Forms.Button();
            this.lblMesa = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnBebidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBebidas.Location = new System.Drawing.Point(327, 19);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(101, 47);
            this.btnBebidas.TabIndex = 80;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.UseVisualStyleBackColor = false;
            this.btnBebidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "RTN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Numero de mesa:";
            // 
            // cmbMesero
            // 
            this.cmbMesero.FormattingEnabled = true;
            this.cmbMesero.Location = new System.Drawing.Point(81, 51);
            this.cmbMesero.Name = "cmbMesero";
            this.cmbMesero.Size = new System.Drawing.Size(165, 21);
            this.cmbMesero.TabIndex = 70;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(23, 54);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(54, 16);
            this.lblUnidad.TabIndex = 71;
            this.lblUnidad.Text = "Mesero";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(914, 34);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 38);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 34);
            this.label1.TabIndex = 67;
            this.label1.Text = "Control de Pedidos\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(18, 62);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(419, 210);
            this.dgvInventario.TabIndex = 82;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPedido);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 272);
            this.panel1.TabIndex = 83;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Cantidads,
            this.PrecioU,
            this.PrecioI});
            this.dgvPedido.Location = new System.Drawing.Point(14, 24);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(413, 227);
            this.dgvPedido.TabIndex = 0;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Cantidads
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Cantidads.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cantidads.HeaderText = "Cantidad";
            this.Cantidads.Name = "Cantidads";
            this.Cantidads.ReadOnly = true;
            this.Cantidads.Width = 50;
            // 
            // PrecioU
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.PrecioU.DefaultCellStyle = dataGridViewCellStyle8;
            this.PrecioU.HeaderText = "Precio Unitario";
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.ReadOnly = true;
            this.PrecioU.Width = 60;
            // 
            // PrecioI
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.PrecioI.DefaultCellStyle = dataGridViewCellStyle9;
            this.PrecioI.HeaderText = "Importe";
            this.PrecioI.Name = "PrecioI";
            this.PrecioI.ReadOnly = true;
            this.PrecioI.Width = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnFactura);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtProducto);
            this.panel2.Controls.Add(this.lblProducto);
            this.panel2.Controls.Add(this.dgvInventario);
            this.panel2.Location = new System.Drawing.Point(524, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 398);
            this.panel2.TabIndex = 84;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 289);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 37);
            this.textBox1.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "Observaciones";
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnFactura.Enabled = false;
            this.btnFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFactura.Location = new System.Drawing.Point(74, 339);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(101, 47);
            this.btnFactura.TabIndex = 92;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Visible = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(311, 21);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 25);
            this.button9.TabIndex = 91;
            this.button9.Text = "Limpiar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(229, 358);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 25);
            this.lblTotal.TabIndex = 86;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotal.Location = new System.Drawing.Point(302, 355);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(135, 31);
            this.txtTotal.TabIndex = 85;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(138, 21);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(156, 20);
            this.txtProducto.TabIndex = 83;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(71, 24);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(68, 16);
            this.lblProducto.TabIndex = 84;
            this.lblProducto.Text = "Producto: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-46, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1102, 91);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // btnDisminuirCantidad
            // 
            this.btnDisminuirCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnDisminuirCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisminuirCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisminuirCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuirCantidad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDisminuirCantidad.Location = new System.Drawing.Point(459, 202);
            this.btnDisminuirCantidad.Name = "btnDisminuirCantidad";
            this.btnDisminuirCantidad.Size = new System.Drawing.Size(58, 31);
            this.btnDisminuirCantidad.TabIndex = 88;
            this.btnDisminuirCantidad.Text = "-";
            this.btnDisminuirCantidad.UseVisualStyleBackColor = false;
            this.btnDisminuirCantidad.Click += new System.EventHandler(this.btnDisminuirCantidad_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnQuitar.Location = new System.Drawing.Point(458, 255);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(59, 31);
            this.btnQuitar.TabIndex = 89;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAumentarCantidad
            // 
            this.btnAumentarCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnAumentarCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAumentarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAumentarCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentarCantidad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAumentarCantidad.Location = new System.Drawing.Point(459, 150);
            this.btnAumentarCantidad.Name = "btnAumentarCantidad";
            this.btnAumentarCantidad.Size = new System.Drawing.Size(59, 31);
            this.btnAumentarCantidad.TabIndex = 87;
            this.btnAumentarCantidad.Text = "+";
            this.btnAumentarCantidad.UseVisualStyleBackColor = false;
            this.btnAumentarCantidad.Click += new System.EventHandler(this.btnAumentarCantidad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCategoria);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.btnComidas);
            this.groupBox1.Controls.Add(this.btnLicores);
            this.groupBox1.Controls.Add(this.btnBebidas);
            this.groupBox1.Location = new System.Drawing.Point(26, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 130);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias de Productos";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(16, 19);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.Size = new System.Drawing.Size(188, 100);
            this.dgvCategoria.TabIndex = 98;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(328, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 47);
            this.button8.TabIndex = 88;
            this.button8.Text = "Enviar Pedidos";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnComidas
            // 
            this.btnComidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnComidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComidas.Location = new System.Drawing.Point(220, 72);
            this.btnComidas.Name = "btnComidas";
            this.btnComidas.Size = new System.Drawing.Size(101, 47);
            this.btnComidas.TabIndex = 85;
            this.btnComidas.Text = "Comidas Solidas";
            this.btnComidas.UseVisualStyleBackColor = false;
            this.btnComidas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLicores
            // 
            this.btnLicores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnLicores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLicores.Location = new System.Drawing.Point(220, 19);
            this.btnLicores.Name = "btnLicores";
            this.btnLicores.Size = new System.Drawing.Size(101, 47);
            this.btnLicores.TabIndex = 82;
            this.btnLicores.Text = "Licores";
            this.btnLicores.UseVisualStyleBackColor = false;
            this.btnLicores.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.Location = new System.Drawing.Point(370, 50);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(83, 27);
            this.lblMesa.TabIndex = 91;
            this.lblMesa.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(723, 3);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(252, 29);
            this.lblFecha.TabIndex = 93;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(734, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 96;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(633, 54);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(101, 16);
            this.lblCliente.TabIndex = 95;
            this.lblCliente.Text = "Nombre Cliente";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(505, 51);
            this.txtRTN.Mask = "99999999999999";
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(112, 20);
            this.txtRTN.TabIndex = 97;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 612);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnDisminuirCantidad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAumentarCantidad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMesero);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMesero;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDisminuirCantidad;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAumentarCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnComidas;
        private System.Windows.Forms.Button btnLicores;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListView lblMesa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.MaskedTextBox txtRTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidads;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioI;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}