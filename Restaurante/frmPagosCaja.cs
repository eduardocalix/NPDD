using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurante
{
    public partial class frmPagosCaja : Form
    {
        public frmPagosCaja()
        {
            InitializeComponent();
            llenarCBServiciosPublicos();
        }

        private void btnSalirPagosCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirAperturarCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Se habilita o deshabilita el uso del Textbox de Descripcion. Si en el ComboBox de Servicios Publicos
        /// se selecciona "Otro", entonces se habilitara, de lo contrario, estara deshabilitado.
        /// </summary>
        private void HabilitarDeshabilitarTxtDescripcion()
        {
            if (Convert.ToString(cbTipoPagoSalida.Text) == "Otro")
            {
                txtDescripcionPagosSalidas.Enabled = true;
                Clases.VariablesGlobales.controlPagoSalida = 1;
            }
            else
            {
                txtDescripcionPagosSalidas.Enabled = false;
                Clases.VariablesGlobales.controlPagoSalida = 0;
            }
        }

        //Se llena el ComboBox de Servicios Publicos
        public void llenarCBServiciosPublicos()
        {
            DataTable dt = new DataTable();
            Clases.Conexión conexión = new Clases.Conexión();
            string sql = @"SELECT Descripcion FROM Restaurante.ServicioPublico";
            SqlCommand cmd = new SqlCommand(sql, conexión.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbTipoPagoSalida.DisplayMember = "Descripcion";
            cbTipoPagoSalida.ValueMember = "Descripcion";
            cbTipoPagoSalida.DataSource = dt;
        }

        //Insercion de los Pagos de Servicios Publicos y Salidas Varias.
        //Se realiza una validacion para saber si se esta ingresando un Pago o una Salida.
        private void btnRegistrarPagoPagosSalidas_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmAperturaCierreCaja.state == 0)
                {
                    MessageBox.Show("Para registrar un pago o salida de caja es necesario realizar la Apertura de Caja", "Error!");
                }
                else
                {
                    if (Clases.VariablesGlobales.controlPagoSalida == 0)
                        Clases.Restaurante.InsertarPagoServicioPublico(Convert.ToString(cbTipoPagoSalida.Text),
                                                                       Convert.ToDecimal(txtMontoPagoSalida.Text),
                                                                       Convert.ToString(txtUsuarioPagosSalidas.Text));
                    else if (Clases.VariablesGlobales.controlPagoSalida == 1)
                    {
                        Clases.Restaurante.InsertarSalida(Convert.ToString(txtDescripcionPagosSalidas.Text),
                                                          Convert.ToDecimal(txtMontoPagoSalida.Text),
                                                          Convert.ToString(txtUsuarioPagosSalidas.Text));
                    }
                }

                LimpiarFormulario();
            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void cbTipoPagoSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarDeshabilitarTxtDescripcion();
        }

        /// <summary>
        /// Se hace la validacion del estado de caja. 1 si la caja esta abierta y 0 si esta cerrada.
        /// Si la caja esta cerrada, los pagos estaran deshabilitados, de lo contrario se habilitaran.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPagosCaja_Load(object sender, EventArgs e)
        {
            txtUsuarioPagosSalidas.Text = Clases.VariablesGlobales.user;
            if (frmAperturaCierreCaja.state == 0)
            {
                btnRegistrarPagoPagosSalidas.Enabled = false;
            }
            else
                btnRegistrarPagoPagosSalidas.Enabled = true;

            LimpiarFormulario();
        }

        private void cbTipoPagoSalida_SelectedValueChanged(object sender, EventArgs e)
        {
            HabilitarDeshabilitarTxtDescripcion();
        }

        private void cbTipoPagoSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToBoolean(e.KeyChar)) 
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtMontoPagoSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void LimpiarFormulario()
        {
            cbTipoPagoSalida.SelectedValue = "";
            txtMontoPagoSalida.Text = "";
            txtDescripcionPagosSalidas.Text = "";
        }
    }
}
