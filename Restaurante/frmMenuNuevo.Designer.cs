namespace Restaurante
{
    partial class frmMenuNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuNuevo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.restaurante = new System.Windows.Forms.ToolStripDropDownButton();
            this.ControlMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.Pedido = new System.Windows.Forms.ToolStripMenuItem();
            this.Caja = new System.Windows.Forms.ToolStripMenuItem();
            this.Apertura = new System.Windows.Forms.ToolStripMenuItem();
            this.Pagos = new System.Windows.Forms.ToolStripMenuItem();
            this.Resumen = new System.Windows.Forms.ToolStripMenuItem();
            this.Cambio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Productos = new System.Windows.Forms.ToolStripDropDownButton();
            this.Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.Insumos = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.Tipo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Reportes = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Seguridad = new System.Windows.Forms.ToolStripDropDownButton();
            this.Meseros = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Papelera = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Ayuda = new System.Windows.Forms.ToolStripDropDownButton();
            this.CerrarSesión = new System.Windows.Forms.ToolStripDropDownButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurante,
            this.toolStripSeparator1,
            this.Productos,
            this.toolStripSeparator3,
            this.Reportes,
            this.toolStripSeparator4,
            this.Seguridad,
            this.toolStripSeparator2,
            this.Ayuda,
            this.CerrarSesión});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1080, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // restaurante
            // 
            this.restaurante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlMesas,
            this.Pedido,
            this.Caja});
            this.restaurante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.restaurante.Image = global::Restaurante.Properties.Resources.LogoTenedor1;
            this.restaurante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.restaurante.ImageTransparentColor = System.Drawing.Color.LemonChiffon;
            this.restaurante.Name = "restaurante";
            this.restaurante.Size = new System.Drawing.Size(118, 39);
            this.restaurante.Text = "Restaurante";
            // 
            // ControlMesas
            // 
            this.ControlMesas.BackColor = System.Drawing.SystemColors.Menu;
            this.ControlMesas.Image = global::Restaurante.Properties.Resources.verde2;
            this.ControlMesas.Name = "ControlMesas";
            this.ControlMesas.Size = new System.Drawing.Size(186, 22);
            this.ControlMesas.Text = "Control de las Mesas";
            this.ControlMesas.Click += new System.EventHandler(this.ControlMesas_Click);
            // 
            // Pedido
            // 
            this.Pedido.BackColor = System.Drawing.SystemColors.Menu;
            this.Pedido.Image = global::Restaurante.Properties.Resources._1486505266_dish_food_dome_dish_kitchen_restaurant_81412;
            this.Pedido.Name = "Pedido";
            this.Pedido.Size = new System.Drawing.Size(186, 22);
            this.Pedido.Text = "Nuevo pedido";
            this.Pedido.Click += new System.EventHandler(this.Pedido_Click);
            // 
            // Caja
            // 
            this.Caja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Apertura,
            this.Pagos,
            this.Resumen,
            this.Cambio});
            this.Caja.Image = global::Restaurante.Properties.Resources.pos_cash_register_icon_51178;
            this.Caja.Name = "Caja";
            this.Caja.Size = new System.Drawing.Size(186, 22);
            this.Caja.Text = "Caja";
            // 
            // Apertura
            // 
            this.Apertura.Name = "Apertura";
            this.Apertura.Size = new System.Drawing.Size(180, 22);
            this.Apertura.Text = "Apertura de caja";
            this.Apertura.Click += new System.EventHandler(this.Apertura_Click);
            // 
            // Pagos
            // 
            this.Pagos.Name = "Pagos";
            this.Pagos.Size = new System.Drawing.Size(180, 22);
            this.Pagos.Text = "Pagos Caja";
            this.Pagos.Click += new System.EventHandler(this.Pagos_Click);
            // 
            // Resumen
            // 
            this.Resumen.Name = "Resumen";
            this.Resumen.Size = new System.Drawing.Size(180, 22);
            this.Resumen.Text = "Resumen Caja";
            this.Resumen.Click += new System.EventHandler(this.Resumen_Click);
            // 
            // Cambio
            // 
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(180, 22);
            this.Cambio.Text = "Cambio del Dolar";
            this.Cambio.Click += new System.EventHandler(this.Cambio_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // Productos
            // 
            this.Productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inventario,
            this.Insumos,
            this.Proveedores,
            this.Categoria,
            this.Tipo});
            this.Productos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Productos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Productos.Image = global::Restaurante.Properties.Resources.business_inventory_maintenance_product_box_boxes_2;
            this.Productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Productos.Size = new System.Drawing.Size(119, 39);
            this.Productos.Text = "Productos";
            this.Productos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // Inventario
            // 
            this.Inventario.BackColor = System.Drawing.SystemColors.Menu;
            this.Inventario.Image = global::Restaurante.Properties.Resources.inventario;
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(201, 22);
            this.Inventario.Text = "Inventario";
            this.Inventario.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // Insumos
            // 
            this.Insumos.BackColor = System.Drawing.SystemColors.Menu;
            this.Insumos.Image = global::Restaurante.Properties.Resources._1486504314_check_list_item_item_list_to_do_ui_shopping_81331;
            this.Insumos.Name = "Insumos";
            this.Insumos.Size = new System.Drawing.Size(201, 22);
            this.Insumos.Text = "Insumos";
            this.Insumos.Click += new System.EventHandler(this.Insumos_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.SystemColors.Menu;
            this.Proveedores.Image = global::Restaurante.Properties.Resources.Empleado;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(201, 22);
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // Categoria
            // 
            this.Categoria.BackColor = System.Drawing.SystemColors.Menu;
            this.Categoria.Image = global::Restaurante.Properties.Resources.Listar;
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(201, 22);
            this.Categoria.Text = "Categoria del Producto";
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // Tipo
            // 
            this.Tipo.BackColor = System.Drawing.SystemColors.Menu;
            this.Tipo.Image = global::Restaurante.Properties.Resources.agregar_editar_icono_6607_32;
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(201, 22);
            this.Tipo.Text = "Tipo de Unidad";
            this.Tipo.Click += new System.EventHandler(this.Tipo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // Reportes
            // 
            this.Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.resumenMensualToolStripMenuItem,
            this.pagosRealizadosToolStripMenuItem});
            this.Reportes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Reportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reportes.Image = global::Restaurante.Properties.Resources.Lisra;
            this.Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Reportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Reportes.Size = new System.Drawing.Size(114, 39);
            this.Reportes.Text = "Reportes";
            this.Reportes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "Ventas del dia";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "Inventario";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "Insumos";
            // 
            // resumenMensualToolStripMenuItem
            // 
            this.resumenMensualToolStripMenuItem.Name = "resumenMensualToolStripMenuItem";
            this.resumenMensualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resumenMensualToolStripMenuItem.Text = "Resumen Mensual";
            // 
            // pagosRealizadosToolStripMenuItem
            // 
            this.pagosRealizadosToolStripMenuItem.Name = "pagosRealizadosToolStripMenuItem";
            this.pagosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagosRealizadosToolStripMenuItem.Text = "Pagos Realizados";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // Seguridad
            // 
            this.Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Meseros,
            this.Usuarios,
            this.Papelera});
            this.Seguridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Seguridad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Seguridad.Image = global::Restaurante.Properties.Resources.seh77;
            this.Seguridad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Seguridad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Seguridad.Size = new System.Drawing.Size(119, 39);
            this.Seguridad.Text = "Seguridad";
            this.Seguridad.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // Meseros
            // 
            this.Meseros.BackColor = System.Drawing.SystemColors.Menu;
            this.Meseros.Image = global::Restaurante.Properties.Resources.descarga__2_;
            this.Meseros.Name = "Meseros";
            this.Meseros.Size = new System.Drawing.Size(205, 36);
            this.Meseros.Text = "Meseros";
            this.Meseros.Click += new System.EventHandler(this.Meseros_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.SystemColors.Menu;
            this.Usuarios.Image = global::Restaurante.Properties.Resources.mod;
            this.Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(205, 36);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Papelera
            // 
            this.Papelera.Image = global::Restaurante.Properties.Resources.images_1_;
            this.Papelera.Name = "Papelera";
            this.Papelera.Size = new System.Drawing.Size(205, 36);
            this.Papelera.Text = "Papelera de Reciclaje";
            this.Papelera.Click += new System.EventHandler(this.Papelera_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // Ayuda
            // 
            this.Ayuda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Ayuda.Image = global::Restaurante.Properties.Resources.descarga;
            this.Ayuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ayuda.ImageTransparentColor = System.Drawing.Color.LemonChiffon;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(89, 39);
            this.Ayuda.Text = "Ayuda";
            // 
            // CerrarSesión
            // 
            this.CerrarSesión.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CerrarSesión.Image = global::Restaurante.Properties.Resources.Exit;
            this.CerrarSesión.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrarSesión.ImageTransparentColor = System.Drawing.Color.LemonChiffon;
            this.CerrarSesión.Name = "CerrarSesión";
            this.CerrarSesión.Size = new System.Drawing.Size(124, 39);
            this.CerrarSesión.Text = "Cerrar Sesión";
            this.CerrarSesión.Click += new System.EventHandler(this.CerrarSesión_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-19, 688);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1320, 96);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(819, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(252, 29);
            this.lblFecha.TabIndex = 94;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenuNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.Logo_Especialidades_Las_Marías__3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuNuevo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton restaurante;
        private System.Windows.Forms.ToolStripMenuItem ControlMesas;
        private System.Windows.Forms.ToolStripMenuItem Pedido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton Productos;
        private System.Windows.Forms.ToolStripMenuItem Inventario;
        private System.Windows.Forms.ToolStripMenuItem Insumos;
        private System.Windows.Forms.ToolStripMenuItem Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Categoria;
        private System.Windows.Forms.ToolStripMenuItem Tipo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton Reportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton Seguridad;
        private System.Windows.Forms.ToolStripMenuItem Meseros;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton Ayuda;
        private System.Windows.Forms.ToolStripDropDownButton CerrarSesión;
        private System.Windows.Forms.ToolStripMenuItem Caja;
        private System.Windows.Forms.ToolStripMenuItem Apertura;
        private System.Windows.Forms.ToolStripMenuItem Pagos;
        private System.Windows.Forms.ToolStripMenuItem Resumen;
        private System.Windows.Forms.ToolStripMenuItem Cambio;
        private System.Windows.Forms.ToolStripMenuItem Papelera;
        private System.Windows.Forms.ToolStripMenuItem resumenMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosRealizadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
    }
}