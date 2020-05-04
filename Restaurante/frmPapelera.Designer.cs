namespace Restaurante
{
    partial class frmPapelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPapelera));
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.ventana = new System.Windows.Forms.TabControl();
            this.usuarios = new System.Windows.Forms.TabPage();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.meseros = new System.Windows.Forms.TabPage();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.proveedores = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.inventario = new System.Windows.Forms.TabPage();
            this.txtCantMinima = new System.Windows.Forms.TextBox();
            this.lblCantMinima = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.insumos = new System.Windows.Forms.TabPage();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.lblCantiMinima = new System.Windows.Forms.Label();
            this.txtDescripcionI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidadI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostoI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdIn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.TabPage();
            this.txtDescripcionC = new System.Windows.Forms.TextBox();
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tipoU = new System.Windows.Forms.TabPage();
            this.txtDescripcionT = new System.Windows.Forms.TextBox();
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.ventana.SuspendLayout();
            this.usuarios.SuspendLayout();
            this.meseros.SuspendLayout();
            this.proveedores.SuspendLayout();
            this.inventario.SuspendLayout();
            this.insumos.SuspendLayout();
            this.categoria.SuspendLayout();
            this.tipoU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodo
            // 
            this.dgvTodo.AllowUserToAddRows = false;
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(31, 239);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.ReadOnly = true;
            this.dgvTodo.Size = new System.Drawing.Size(627, 127);
            this.dgvTodo.TabIndex = 95;
            this.dgvTodo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellClick);
            // 
            // ventana
            // 
            this.ventana.Controls.Add(this.usuarios);
            this.ventana.Controls.Add(this.meseros);
            this.ventana.Controls.Add(this.proveedores);
            this.ventana.Controls.Add(this.inventario);
            this.ventana.Controls.Add(this.insumos);
            this.ventana.Controls.Add(this.categoria);
            this.ventana.Controls.Add(this.tipoU);
            this.ventana.Location = new System.Drawing.Point(26, 44);
            this.ventana.Name = "ventana";
            this.ventana.SelectedIndex = 0;
            this.ventana.Size = new System.Drawing.Size(648, 174);
            this.ventana.TabIndex = 96;
            this.ventana.SelectedIndexChanged += new System.EventHandler(this.ventana_SelectedIndexChanged);
            // 
            // usuarios
            // 
            this.usuarios.Controls.Add(this.btnRestaurar);
            this.usuarios.Controls.Add(this.btnEliminar);
            this.usuarios.Controls.Add(this.txtApellido);
            this.usuarios.Controls.Add(this.lblApellido);
            this.usuarios.Controls.Add(this.txtNombre);
            this.usuarios.Controls.Add(this.txtClave);
            this.usuarios.Controls.Add(this.lblClave);
            this.usuarios.Controls.Add(this.lblNombre);
            this.usuarios.Location = new System.Drawing.Point(4, 22);
            this.usuarios.Name = "usuarios";
            this.usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.usuarios.Size = new System.Drawing.Size(640, 148);
            this.usuarios.TabIndex = 0;
            this.usuarios.Text = "Usuarios";
            this.usuarios.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRestaurar.Location = new System.Drawing.Point(398, 45);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 25);
            this.btnRestaurar.TabIndex = 22;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Location = new System.Drawing.Point(398, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(118, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(198, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(23, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(118, 106);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '•';
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(198, 20);
            this.txtClave.TabIndex = 18;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(23, 106);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(43, 17);
            this.lblClave.TabIndex = 17;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(23, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            // 
            // meseros
            // 
            this.meseros.Controls.Add(this.txtApellido2);
            this.meseros.Controls.Add(this.txtNombre2);
            this.meseros.Controls.Add(this.txtIdentidad);
            this.meseros.Controls.Add(this.lblId);
            this.meseros.Controls.Add(this.label2);
            this.meseros.Controls.Add(this.lblTelefono);
            this.meseros.Controls.Add(this.button1);
            this.meseros.Controls.Add(this.button2);
            this.meseros.Location = new System.Drawing.Point(4, 22);
            this.meseros.Name = "meseros";
            this.meseros.Padding = new System.Windows.Forms.Padding(3);
            this.meseros.Size = new System.Drawing.Size(640, 148);
            this.meseros.TabIndex = 1;
            this.meseros.Text = "Meseros";
            this.meseros.UseVisualStyleBackColor = true;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(131, 107);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(213, 20);
            this.txtApellido2.TabIndex = 27;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(131, 64);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.ReadOnly = true;
            this.txtNombre2.Size = new System.Drawing.Size(213, 20);
            this.txtNombre2.TabIndex = 26;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(131, 16);
            this.txtIdentidad.Mask = "9999-9999-99999";
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.ReadOnly = true;
            this.txtIdentidad.Size = new System.Drawing.Size(213, 20);
            this.txtIdentidad.TabIndex = 25;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 13);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "Identidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(26, 110);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(44, 13);
            this.lblTelefono.TabIndex = 30;
            this.lblTelefono.Text = "Apellido";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(404, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 24;
            this.button1.Text = "Restaurar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(404, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 23;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // proveedores
            // 
            this.proveedores.Controls.Add(this.txtId);
            this.proveedores.Controls.Add(this.txtNombre3);
            this.proveedores.Controls.Add(this.txtTelefono);
            this.proveedores.Controls.Add(this.lblDireccion);
            this.proveedores.Controls.Add(this.txtDireccion);
            this.proveedores.Controls.Add(this.label3);
            this.proveedores.Controls.Add(this.label4);
            this.proveedores.Controls.Add(this.label5);
            this.proveedores.Controls.Add(this.button4);
            this.proveedores.Controls.Add(this.button5);
            this.proveedores.Location = new System.Drawing.Point(4, 22);
            this.proveedores.Name = "proveedores";
            this.proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.proveedores.Size = new System.Drawing.Size(640, 148);
            this.proveedores.TabIndex = 2;
            this.proveedores.Text = "Proveedores";
            this.proveedores.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(91, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(210, 20);
            this.txtId.TabIndex = 25;
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(91, 39);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.ReadOnly = true;
            this.txtNombre3.Size = new System.Drawing.Size(210, 20);
            this.txtNombre3.TabIndex = 26;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(92, 67);
            this.txtTelefono.Mask = "9999-9999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(169, 20);
            this.txtTelefono.TabIndex = 27;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(34, 100);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 32;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(91, 96);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(266, 46);
            this.txtDireccion.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(417, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 24;
            this.button4.Text = "Restaurar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(417, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 23;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // inventario
            // 
            this.inventario.Controls.Add(this.txtCantMinima);
            this.inventario.Controls.Add(this.lblCantMinima);
            this.inventario.Controls.Add(this.txtCantidad);
            this.inventario.Controls.Add(this.lblCantidad);
            this.inventario.Controls.Add(this.txtPrecioVenta);
            this.inventario.Controls.Add(this.lblPrecioVenta);
            this.inventario.Controls.Add(this.lblDescripcion);
            this.inventario.Controls.Add(this.txtCosto);
            this.inventario.Controls.Add(this.lblCosto);
            this.inventario.Controls.Add(this.txtDescripcion);
            this.inventario.Controls.Add(this.txtIdI);
            this.inventario.Controls.Add(this.label6);
            this.inventario.Controls.Add(this.button6);
            this.inventario.Controls.Add(this.button7);
            this.inventario.Location = new System.Drawing.Point(4, 22);
            this.inventario.Name = "inventario";
            this.inventario.Padding = new System.Windows.Forms.Padding(3);
            this.inventario.Size = new System.Drawing.Size(640, 148);
            this.inventario.TabIndex = 3;
            this.inventario.Text = "Inventario";
            this.inventario.UseVisualStyleBackColor = true;
            // 
            // txtCantMinima
            // 
            this.txtCantMinima.Location = new System.Drawing.Point(277, 78);
            this.txtCantMinima.Name = "txtCantMinima";
            this.txtCantMinima.ReadOnly = true;
            this.txtCantMinima.Size = new System.Drawing.Size(109, 20);
            this.txtCantMinima.TabIndex = 49;
            // 
            // lblCantMinima
            // 
            this.lblCantMinima.AutoSize = true;
            this.lblCantMinima.Location = new System.Drawing.Point(210, 81);
            this.lblCantMinima.Name = "lblCantMinima";
            this.lblCantMinima.Size = new System.Drawing.Size(52, 13);
            this.lblCantMinima.TabIndex = 55;
            this.lblCantMinima.Text = "Cant. Min";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(277, 52);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(109, 20);
            this.txtCantidad.TabIndex = 48;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(213, 55);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 54;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(91, 78);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(109, 20);
            this.txtPrecioVenta.TabIndex = 47;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(19, 81);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioVenta.TabIndex = 53;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(147, 23);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 52;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(91, 52);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(109, 20);
            this.txtCosto.TabIndex = 46;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(22, 56);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 51;
            this.lblCosto.Text = "Costo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(216, 18);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(213, 28);
            this.txtDescripcion.TabIndex = 45;
            // 
            // txtIdI
            // 
            this.txtIdI.Enabled = false;
            this.txtIdI.Location = new System.Drawing.Point(91, 18);
            this.txtIdI.Name = "txtIdI";
            this.txtIdI.ReadOnly = true;
            this.txtIdI.Size = new System.Drawing.Size(53, 20);
            this.txtIdI.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Id";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(536, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 25);
            this.button6.TabIndex = 24;
            this.button6.Text = "Restaurar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(536, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 25);
            this.button7.TabIndex = 23;
            this.button7.Text = "Eliminar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // insumos
            // 
            this.insumos.Controls.Add(this.txtMinima);
            this.insumos.Controls.Add(this.lblCantiMinima);
            this.insumos.Controls.Add(this.txtDescripcionI);
            this.insumos.Controls.Add(this.label11);
            this.insumos.Controls.Add(this.txtCantidadI);
            this.insumos.Controls.Add(this.label7);
            this.insumos.Controls.Add(this.txtCostoI);
            this.insumos.Controls.Add(this.label8);
            this.insumos.Controls.Add(this.txtNombreI);
            this.insumos.Controls.Add(this.label9);
            this.insumos.Controls.Add(this.txtIdIn);
            this.insumos.Controls.Add(this.label10);
            this.insumos.Controls.Add(this.button8);
            this.insumos.Controls.Add(this.button9);
            this.insumos.Location = new System.Drawing.Point(4, 22);
            this.insumos.Name = "insumos";
            this.insumos.Padding = new System.Windows.Forms.Padding(3);
            this.insumos.Size = new System.Drawing.Size(640, 148);
            this.insumos.TabIndex = 4;
            this.insumos.Text = "Insumos";
            this.insumos.UseVisualStyleBackColor = true;
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(115, 68);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.ReadOnly = true;
            this.txtMinima.Size = new System.Drawing.Size(61, 20);
            this.txtMinima.TabIndex = 44;
            // 
            // lblCantiMinima
            // 
            this.lblCantiMinima.AutoSize = true;
            this.lblCantiMinima.Location = new System.Drawing.Point(24, 71);
            this.lblCantiMinima.Name = "lblCantiMinima";
            this.lblCantiMinima.Size = new System.Drawing.Size(68, 13);
            this.lblCantiMinima.TabIndex = 51;
            this.lblCantiMinima.Text = "Cant. Minima";
            // 
            // txtDescripcionI
            // 
            this.txtDescripcionI.Location = new System.Drawing.Point(93, 98);
            this.txtDescripcionI.Multiline = true;
            this.txtDescripcionI.Name = "txtDescripcionI";
            this.txtDescripcionI.ReadOnly = true;
            this.txtDescripcionI.Size = new System.Drawing.Size(140, 44);
            this.txtDescripcionI.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Descripción";
            // 
            // txtCantidadI
            // 
            this.txtCantidadI.Location = new System.Drawing.Point(247, 50);
            this.txtCantidadI.Name = "txtCantidadI";
            this.txtCantidadI.ReadOnly = true;
            this.txtCantidadI.Size = new System.Drawing.Size(109, 20);
            this.txtCantidadI.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cantidad";
            // 
            // txtCostoI
            // 
            this.txtCostoI.Location = new System.Drawing.Point(67, 42);
            this.txtCostoI.Name = "txtCostoI";
            this.txtCostoI.ReadOnly = true;
            this.txtCostoI.Size = new System.Drawing.Size(109, 20);
            this.txtCostoI.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Costo";
            // 
            // txtNombreI
            // 
            this.txtNombreI.Location = new System.Drawing.Point(182, 9);
            this.txtNombreI.Name = "txtNombreI";
            this.txtNombreI.ReadOnly = true;
            this.txtNombreI.Size = new System.Drawing.Size(213, 20);
            this.txtNombreI.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Nombre";
            // 
            // txtIdIn
            // 
            this.txtIdIn.Enabled = false;
            this.txtIdIn.Location = new System.Drawing.Point(64, 6);
            this.txtIdIn.Name = "txtIdIn";
            this.txtIdIn.ReadOnly = true;
            this.txtIdIn.Size = new System.Drawing.Size(55, 20);
            this.txtIdIn.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Id";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(531, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 25);
            this.button8.TabIndex = 24;
            this.button8.Text = "Restaurar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(531, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 25);
            this.button9.TabIndex = 23;
            this.button9.Text = "Eliminar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // categoria
            // 
            this.categoria.Controls.Add(this.txtDescripcionC);
            this.categoria.Controls.Add(this.txtIDC);
            this.categoria.Controls.Add(this.label12);
            this.categoria.Controls.Add(this.label13);
            this.categoria.Controls.Add(this.button10);
            this.categoria.Controls.Add(this.button11);
            this.categoria.Location = new System.Drawing.Point(4, 22);
            this.categoria.Name = "categoria";
            this.categoria.Padding = new System.Windows.Forms.Padding(3);
            this.categoria.Size = new System.Drawing.Size(640, 148);
            this.categoria.TabIndex = 5;
            this.categoria.Text = "Categoria del producto";
            this.categoria.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionC
            // 
            this.txtDescripcionC.Location = new System.Drawing.Point(156, 79);
            this.txtDescripcionC.Name = "txtDescripcionC";
            this.txtDescripcionC.ReadOnly = true;
            this.txtDescripcionC.Size = new System.Drawing.Size(213, 20);
            this.txtDescripcionC.TabIndex = 29;
            // 
            // txtIDC
            // 
            this.txtIDC.Enabled = false;
            this.txtIDC.Location = new System.Drawing.Point(156, 36);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.ReadOnly = true;
            this.txtIDC.Size = new System.Drawing.Size(112, 20);
            this.txtIDC.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Descripción";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button10.Location = new System.Drawing.Point(466, 50);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 25);
            this.button10.TabIndex = 24;
            this.button10.Text = "Restaurar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button11.Location = new System.Drawing.Point(466, 91);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 25);
            this.button11.TabIndex = 23;
            this.button11.Text = "Eliminar";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tipoU
            // 
            this.tipoU.Controls.Add(this.txtDescripcionT);
            this.tipoU.Controls.Add(this.txtIDT);
            this.tipoU.Controls.Add(this.label14);
            this.tipoU.Controls.Add(this.label15);
            this.tipoU.Controls.Add(this.button12);
            this.tipoU.Controls.Add(this.button13);
            this.tipoU.Location = new System.Drawing.Point(4, 22);
            this.tipoU.Name = "tipoU";
            this.tipoU.Padding = new System.Windows.Forms.Padding(3);
            this.tipoU.Size = new System.Drawing.Size(640, 148);
            this.tipoU.TabIndex = 6;
            this.tipoU.Text = "Tipo de Unidad";
            this.tipoU.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionT
            // 
            this.txtDescripcionT.Location = new System.Drawing.Point(152, 77);
            this.txtDescripcionT.Name = "txtDescripcionT";
            this.txtDescripcionT.ReadOnly = true;
            this.txtDescripcionT.Size = new System.Drawing.Size(213, 20);
            this.txtDescripcionT.TabIndex = 29;
            // 
            // txtIDT
            // 
            this.txtIDT.Enabled = false;
            this.txtIDT.Location = new System.Drawing.Point(152, 34);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.ReadOnly = true;
            this.txtIDT.Size = new System.Drawing.Size(112, 20);
            this.txtIDT.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Descripción";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button12.Location = new System.Drawing.Point(488, 46);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 25);
            this.button12.TabIndex = 24;
            this.button12.Text = "Restaurar";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button13.Location = new System.Drawing.Point(488, 87);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 25);
            this.button13.TabIndex = 23;
            this.button13.Text = "Eliminar";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(655, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 32);
            this.button3.TabIndex = 103;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-152, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 91);
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-172, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 37);
            this.label1.TabIndex = 101;
            this.label1.Text = "Papelera de Reciclaje";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ventana);
            this.Controls.Add(this.dgvTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPapelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPapelera";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.ventana.ResumeLayout(false);
            this.usuarios.ResumeLayout(false);
            this.usuarios.PerformLayout();
            this.meseros.ResumeLayout(false);
            this.meseros.PerformLayout();
            this.proveedores.ResumeLayout(false);
            this.proveedores.PerformLayout();
            this.inventario.ResumeLayout(false);
            this.inventario.PerformLayout();
            this.insumos.ResumeLayout(false);
            this.insumos.PerformLayout();
            this.categoria.ResumeLayout(false);
            this.categoria.PerformLayout();
            this.tipoU.ResumeLayout(false);
            this.tipoU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.TabControl ventana;
        private System.Windows.Forms.TabPage usuarios;
        private System.Windows.Forms.TabPage meseros;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage proveedores;
        private System.Windows.Forms.TabPage inventario;
        private System.Windows.Forms.TabPage insumos;
        private System.Windows.Forms.TabPage categoria;
        private System.Windows.Forms.TabPage tipoU;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.MaskedTextBox txtIdentidad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantMinima;
        private System.Windows.Forms.Label lblCantMinima;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostoI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Label lblCantiMinima;
        private System.Windows.Forms.TextBox txtDescripcionI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripcionC;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDescripcionT;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}