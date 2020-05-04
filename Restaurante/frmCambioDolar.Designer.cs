namespace Restaurante
{
    partial class frmCambioDolar
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
            this.pnlTituloCambioDolar = new System.Windows.Forms.Panel();
            this.lblCambioDolar = new System.Windows.Forms.Label();
            this.lblDolaresCambioDolar = new System.Windows.Forms.Label();
            this.txtDolaresCambioDolar = new System.Windows.Forms.TextBox();
            this.txtLempirasCambioDolar = new System.Windows.Forms.TextBox();
            this.lblLempirasCambioDolar = new System.Windows.Forms.Label();
            this.btnSalirAperturarCaja = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pnlTituloCambioDolar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTituloCambioDolar
            // 
            this.pnlTituloCambioDolar.Controls.Add(this.lblCambioDolar);
            this.pnlTituloCambioDolar.Location = new System.Drawing.Point(12, 0);
            this.pnlTituloCambioDolar.Name = "pnlTituloCambioDolar";
            this.pnlTituloCambioDolar.Size = new System.Drawing.Size(272, 58);
            this.pnlTituloCambioDolar.TabIndex = 53;
            // 
            // lblCambioDolar
            // 
            this.lblCambioDolar.AutoSize = true;
            this.lblCambioDolar.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.lblCambioDolar.Location = new System.Drawing.Point(25, 9);
            this.lblCambioDolar.Name = "lblCambioDolar";
            this.lblCambioDolar.Size = new System.Drawing.Size(220, 30);
            this.lblCambioDolar.TabIndex = 29;
            this.lblCambioDolar.Text = "Cambio del Dolar";
            // 
            // lblDolaresCambioDolar
            // 
            this.lblDolaresCambioDolar.AutoSize = true;
            this.lblDolaresCambioDolar.Location = new System.Drawing.Point(61, 89);
            this.lblDolaresCambioDolar.Name = "lblDolaresCambioDolar";
            this.lblDolaresCambioDolar.Size = new System.Drawing.Size(43, 13);
            this.lblDolaresCambioDolar.TabIndex = 54;
            this.lblDolaresCambioDolar.Text = "Dolares";
            // 
            // txtDolaresCambioDolar
            // 
            this.txtDolaresCambioDolar.Enabled = false;
            this.txtDolaresCambioDolar.Location = new System.Drawing.Point(116, 86);
            this.txtDolaresCambioDolar.Name = "txtDolaresCambioDolar";
            this.txtDolaresCambioDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolaresCambioDolar.TabIndex = 55;
            this.txtDolaresCambioDolar.Text = "1";
            // 
            // txtLempirasCambioDolar
            // 
            this.txtLempirasCambioDolar.Enabled = false;
            this.txtLempirasCambioDolar.Location = new System.Drawing.Point(116, 127);
            this.txtLempirasCambioDolar.Name = "txtLempirasCambioDolar";
            this.txtLempirasCambioDolar.Size = new System.Drawing.Size(100, 20);
            this.txtLempirasCambioDolar.TabIndex = 57;
            // 
            // lblLempirasCambioDolar
            // 
            this.lblLempirasCambioDolar.AutoSize = true;
            this.lblLempirasCambioDolar.Location = new System.Drawing.Point(61, 130);
            this.lblLempirasCambioDolar.Name = "lblLempirasCambioDolar";
            this.lblLempirasCambioDolar.Size = new System.Drawing.Size(49, 13);
            this.lblLempirasCambioDolar.TabIndex = 56;
            this.lblLempirasCambioDolar.Text = "Lempiras";
            // 
            // btnSalirAperturarCaja
            // 
            this.btnSalirAperturarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSalirAperturarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirAperturarCaja.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalirAperturarCaja.Location = new System.Drawing.Point(141, 170);
            this.btnSalirAperturarCaja.Name = "btnSalirAperturarCaja";
            this.btnSalirAperturarCaja.Size = new System.Drawing.Size(75, 25);
            this.btnSalirAperturarCaja.TabIndex = 58;
            this.btnSalirAperturarCaja.Text = "Salir";
            this.btnSalirAperturarCaja.UseVisualStyleBackColor = false;
            this.btnSalirAperturarCaja.Click += new System.EventHandler(this.btnSalirAperturarCaja_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalcular.Location = new System.Drawing.Point(42, 170);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.TabIndex = 59;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCambioDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 223);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalirAperturarCaja);
            this.Controls.Add(this.txtLempirasCambioDolar);
            this.Controls.Add(this.lblLempirasCambioDolar);
            this.Controls.Add(this.txtDolaresCambioDolar);
            this.Controls.Add(this.lblDolaresCambioDolar);
            this.Controls.Add(this.pnlTituloCambioDolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambioDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCambioDolar";
            this.pnlTituloCambioDolar.ResumeLayout(false);
            this.pnlTituloCambioDolar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloCambioDolar;
        private System.Windows.Forms.Label lblCambioDolar;
        private System.Windows.Forms.Label lblDolaresCambioDolar;
        private System.Windows.Forms.TextBox txtDolaresCambioDolar;
        private System.Windows.Forms.TextBox txtLempirasCambioDolar;
        private System.Windows.Forms.Label lblLempirasCambioDolar;
        private System.Windows.Forms.Button btnSalirAperturarCaja;
        private System.Windows.Forms.Button btnCalcular;
    }
}