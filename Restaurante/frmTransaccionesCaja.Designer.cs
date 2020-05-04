namespace Restaurante
{
    partial class frmTransaccionesCaja
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
            this.gbCaja = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCambioDolar = new System.Windows.Forms.Button();
            this.btnCancelarCuenta = new System.Windows.Forms.Button();
            this.btnSalidasCaja = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.gbCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCaja
            // 
            this.gbCaja.Controls.Add(this.button1);
            this.gbCaja.Controls.Add(this.btnCambioDolar);
            this.gbCaja.Controls.Add(this.btnCancelarCuenta);
            this.gbCaja.Controls.Add(this.btnSalidasCaja);
            this.gbCaja.Controls.Add(this.btnPagos);
            this.gbCaja.Controls.Add(this.btnCierreCaja);
            this.gbCaja.Controls.Add(this.btnAbrirCaja);
            this.gbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCaja.Location = new System.Drawing.Point(41, 12);
            this.gbCaja.Name = "gbCaja";
            this.gbCaja.Size = new System.Drawing.Size(337, 264);
            this.gbCaja.TabIndex = 0;
            this.gbCaja.TabStop = false;
            this.gbCaja.Text = "Caja";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resumen de Caja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCambioDolar
            // 
            this.btnCambioDolar.Location = new System.Drawing.Point(196, 168);
            this.btnCambioDolar.Name = "btnCambioDolar";
            this.btnCambioDolar.Size = new System.Drawing.Size(93, 52);
            this.btnCambioDolar.TabIndex = 5;
            this.btnCambioDolar.Text = "Cambio del Dolar";
            this.btnCambioDolar.UseVisualStyleBackColor = true;
            this.btnCambioDolar.Click += new System.EventHandler(this.btnCambioDolar_Click);
            // 
            // btnCancelarCuenta
            // 
            this.btnCancelarCuenta.Location = new System.Drawing.Point(48, 130);
            this.btnCancelarCuenta.Name = "btnCancelarCuenta";
            this.btnCancelarCuenta.Size = new System.Drawing.Size(93, 52);
            this.btnCancelarCuenta.TabIndex = 4;
            this.btnCancelarCuenta.Text = "Cancelar Cuenta";
            this.btnCancelarCuenta.UseVisualStyleBackColor = true;
            // 
            // btnSalidasCaja
            // 
            this.btnSalidasCaja.Location = new System.Drawing.Point(196, 110);
            this.btnSalidasCaja.Name = "btnSalidasCaja";
            this.btnSalidasCaja.Size = new System.Drawing.Size(93, 52);
            this.btnSalidasCaja.TabIndex = 3;
            this.btnSalidasCaja.Text = "Salidas de Caja";
            this.btnSalidasCaja.UseVisualStyleBackColor = true;
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(48, 95);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(92, 29);
            this.btnPagos.TabIndex = 2;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.Location = new System.Drawing.Point(196, 52);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(93, 52);
            this.btnCierreCaja.TabIndex = 1;
            this.btnCierreCaja.Text = "Cierre de Caja";
            this.btnCierreCaja.UseVisualStyleBackColor = true;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.Location = new System.Drawing.Point(48, 34);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(92, 52);
            this.btnAbrirCaja.TabIndex = 0;
            this.btnAbrirCaja.Text = "Apertura de Caja";
            this.btnAbrirCaja.UseVisualStyleBackColor = true;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // frmTransaccionesCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 288);
            this.Controls.Add(this.gbCaja);
            this.Name = "frmTransaccionesCaja";
            this.Text = "Movimientos de Caja";
            this.gbCaja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCaja;
        private System.Windows.Forms.Button btnSalidasCaja;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.Button btnCambioDolar;
        private System.Windows.Forms.Button btnCancelarCuenta;
        private System.Windows.Forms.Button button1;
    }
}