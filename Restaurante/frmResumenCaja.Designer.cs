namespace Restaurante
{
    partial class frmResumenCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenCaja));
            this.gvResumenCaja = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbResuemnCaja = new System.Windows.Forms.GroupBox();
            this.btnSalidasVarias = new System.Windows.Forms.Button();
            this.cbServiciosPublicos = new System.Windows.Forms.ComboBox();
            this.lblServicioPublicoResumenCaja = new System.Windows.Forms.Label();
            this.btnSalirAperturarCaja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTituloResumenCaja = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFiltrarAperturasCierres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvResumenCaja)).BeginInit();
            this.gbResuemnCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvResumenCaja
            // 
            this.gvResumenCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResumenCaja.Location = new System.Drawing.Point(310, 73);
            this.gvResumenCaja.Name = "gvResumenCaja";
            this.gvResumenCaja.ReadOnly = true;
            this.gvResumenCaja.Size = new System.Drawing.Size(347, 348);
            this.gvResumenCaja.TabIndex = 0;
            // 
            // gbResuemnCaja
            // 
            this.gbResuemnCaja.Controls.Add(this.btnFiltrarAperturasCierres);
            this.gbResuemnCaja.Controls.Add(this.btnSalidasVarias);
            this.gbResuemnCaja.Controls.Add(this.cbServiciosPublicos);
            this.gbResuemnCaja.Controls.Add(this.lblServicioPublicoResumenCaja);
            this.gbResuemnCaja.Controls.Add(this.btnSalirAperturarCaja);
            this.gbResuemnCaja.Location = new System.Drawing.Point(12, 73);
            this.gbResuemnCaja.Name = "gbResuemnCaja";
            this.gbResuemnCaja.Size = new System.Drawing.Size(292, 348);
            this.gbResuemnCaja.TabIndex = 4;
            this.gbResuemnCaja.TabStop = false;
            // 
            // btnSalidasVarias
            // 
            this.btnSalidasVarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSalidasVarias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalidasVarias.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalidasVarias.Location = new System.Drawing.Point(82, 137);
            this.btnSalidasVarias.Name = "btnSalidasVarias";
            this.btnSalidasVarias.Size = new System.Drawing.Size(106, 25);
            this.btnSalidasVarias.TabIndex = 56;
            this.btnSalidasVarias.Text = "Salidas Varias";
            this.btnSalidasVarias.UseVisualStyleBackColor = false;
            this.btnSalidasVarias.Click += new System.EventHandler(this.btnSalidasVarias_Click);
            // 
            // cbServiciosPublicos
            // 
            this.cbServiciosPublicos.FormattingEnabled = true;
            this.cbServiciosPublicos.Location = new System.Drawing.Point(80, 82);
            this.cbServiciosPublicos.Name = "cbServiciosPublicos";
            this.cbServiciosPublicos.Size = new System.Drawing.Size(189, 21);
            this.cbServiciosPublicos.TabIndex = 55;
            // 
            // lblServicioPublicoResumenCaja
            // 
            this.lblServicioPublicoResumenCaja.AutoSize = true;
            this.lblServicioPublicoResumenCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioPublicoResumenCaja.Location = new System.Drawing.Point(17, 82);
            this.lblServicioPublicoResumenCaja.Name = "lblServicioPublicoResumenCaja";
            this.lblServicioPublicoResumenCaja.Size = new System.Drawing.Size(57, 32);
            this.lblServicioPublicoResumenCaja.TabIndex = 54;
            this.lblServicioPublicoResumenCaja.Text = "Servicio\r\nPublico";
            // 
            // btnSalirAperturarCaja
            // 
            this.btnSalirAperturarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSalirAperturarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirAperturarCaja.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalirAperturarCaja.Location = new System.Drawing.Point(96, 297);
            this.btnSalirAperturarCaja.Name = "btnSalirAperturarCaja";
            this.btnSalirAperturarCaja.Size = new System.Drawing.Size(75, 25);
            this.btnSalirAperturarCaja.TabIndex = 53;
            this.btnSalirAperturarCaja.Text = "Salir";
            this.btnSalirAperturarCaja.UseVisualStyleBackColor = false;
            this.btnSalirAperturarCaja.Click += new System.EventHandler(this.btnSalirAperturarCaja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 79);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTituloResumenCaja);
            this.pnlTitulo.Location = new System.Drawing.Point(155, 5);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(337, 62);
            this.pnlTitulo.TabIndex = 50;
            // 
            // lblTituloResumenCaja
            // 
            this.lblTituloResumenCaja.AutoSize = true;
            this.lblTituloResumenCaja.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResumenCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.lblTituloResumenCaja.Location = new System.Drawing.Point(52, 20);
            this.lblTituloResumenCaja.Name = "lblTituloResumenCaja";
            this.lblTituloResumenCaja.Size = new System.Drawing.Size(217, 30);
            this.lblTituloResumenCaja.TabIndex = 29;
            this.lblTituloResumenCaja.Text = "Resumen de Caja";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(640, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(29, 29);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.TabStop = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFiltrarAperturasCierres
            // 
            this.btnFiltrarAperturasCierres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnFiltrarAperturasCierres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarAperturasCierres.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFiltrarAperturasCierres.Location = new System.Drawing.Point(80, 28);
            this.btnFiltrarAperturasCierres.Name = "btnFiltrarAperturasCierres";
            this.btnFiltrarAperturasCierres.Size = new System.Drawing.Size(106, 25);
            this.btnFiltrarAperturasCierres.TabIndex = 57;
            this.btnFiltrarAperturasCierres.Text = "Aperturas y Cierres";
            this.btnFiltrarAperturasCierres.UseVisualStyleBackColor = false;
            this.btnFiltrarAperturasCierres.Click += new System.EventHandler(this.btnFiltrarAperturasCierres_Click);
            // 
            // frmResumenCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 514);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbResuemnCaja);
            this.Controls.Add(this.gvResumenCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "frmResumenCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de Caja";
            this.Load += new System.EventHandler(this.frmResumenCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResumenCaja)).EndInit();
            this.gbResuemnCaja.ResumeLayout(false);
            this.gbResuemnCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResumenCaja;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbResuemnCaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTituloResumenCaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSalirAperturarCaja;
        private System.Windows.Forms.Button btnSalidasVarias;
        private System.Windows.Forms.ComboBox cbServiciosPublicos;
        private System.Windows.Forms.Label lblServicioPublicoResumenCaja;
        private System.Windows.Forms.Button btnFiltrarAperturasCierres;
    }
}