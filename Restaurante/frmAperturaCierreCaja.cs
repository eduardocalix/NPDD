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
    public partial class frmAperturaCierreCaja : Form
    {
        public frmAperturaCierreCaja()
        {
            InitializeComponent();
        }

        private void btnCancelarCierreCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBilletes500CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void btnCancelarCerrarCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirAperturarCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Insercion de la Apertura de Caja/
        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            if (state == 0)
                try
                {
                    if (Convert.ToDecimal(txtSaldoInicialAperturaCaja.Text) >
                        Convert.ToDecimal(txtSaldoTotalAperturaCaja.Text))
                        MessageBox.Show("El Saldo de Apertura no puede ser mayor al Saldo Total existente/Saldo del Ultimo" +
                                          "Cierre! Porfavor revise la cantidad!", "Error!");
                    else
                    {
                        Clases.Restaurante.AperturarCaja(Convert.ToDecimal(txtSaldoInicialAperturaCaja.Text),
                                                         Convert.ToInt16(txtDolares.Text),
                                                         Convert.ToInt16(txtL500.Text), Convert.ToInt16(txtL100.Text),
                                                         Convert.ToInt16(txtL50.Text), Convert.ToInt16(txtL20.Text),
                                                         Convert.ToInt16(txtL10.Text), Convert.ToInt16(txtL5.Text),
                                                         Convert.ToInt16(txtL2.Text), Convert.ToInt16(txtL1.Text),
                                                         Convert.ToString(txtUsuarioAperturaCaja.Text));
                        this.Close();
                        //Clases.VariablesGlobales.state = 1;
                    }
                }
                catch (Exception ex)
                {
                    Clases.Mensaje.Advertencia(ex);
                }
            else
                MessageBox.Show("No se puede hacer la Apertura de caja porque no se ha cerrado. " +
                                "Realice el Cierre de caja primero para poder aperturarla.", "Error!");
        }


        /// <summary>
        /// Calculo de la cantidad de dinero con la que se hara la Apertura de Caja. Se hace el calculo de
        /// los Lempiras y Dolares.
        /// </summary>
        private void CalcularTotalApertura()
        {
            int L500 = 0;
            int.TryParse(txtL500.Text, out L500);
            int L100 = 0;
            int.TryParse(txtL100.Text, out L100);
            int L50 = 0;
            int.TryParse(txtL50.Text, out L50);
            int L20 = 0;
            int.TryParse(txtL20.Text, out L20);
            int L10 = 0;
            int.TryParse(txtL10.Text, out L10);
            int L5 = 0;
            int.TryParse(txtL5.Text, out L5);
            int L2 = 0;
            int.TryParse(txtL2.Text, out L2);
            int L1 = 0;
            int.TryParse(txtL1.Text, out L1);
            int Dolar = 0;
            int.TryParse(txtDolares.Text, out Dolar);

            txtTotal.Text = Convert.ToString(Convert.ToDecimal((L500 * 500) + (L100 * 100) + (L50 * 50) + (L20 * 20)
                                                               + (L10 * 10) + (L5 * 5) + (L2 * 2) + L1 + 
                                                               (frmLogin.dolar * Dolar)));
            Convert.ToDecimal(txtSaldoInicialAperturaCaja.Text = Convert.ToString(Convert.ToDecimal((L500 * 500) +
                                                                                 (L100 * 100) + (L50 * 50) +
                                                                                 (L20 * 20) + (L10 * 10) + (L5 * 5) +
                                                                                 (L2 * 2) + L1 + 
                                                                                 (frmLogin.dolar * Dolar))));
        }

        private void txtL500_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtL100_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtL50_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtL20_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtL10_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtL5_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtL2_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtL1_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        //Insercion del Cierre de Caja
        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (state == 1)
                try
                {
                        Clases.Restaurante.CierreCaja(Convert.ToDecimal(txtSaldoFinalDiaCierreCaja.Text),
                                                      Convert.ToInt16(txtTotalDolaresCierreCaja.Text), 
                                                      Convert.ToDecimal(txtTotalPOSCierreCaja.Text),
                                                      Convert.ToInt16(txtBilletes500CierreCaja.Text), 
                                                      Convert.ToInt16(txtBilletes100CierreCaja.Text),
                                                      Convert.ToInt16(txtBilletes50CierreCaja.Text), 
                                                      Convert.ToInt16(txtBilletes20CierreCaja.Text),
                                                      Convert.ToInt16(txtBilletes10CierreCaja.Text), 
                                                      Convert.ToInt16(txtBilletes5CierreCaja.Text),
                                                      Convert.ToInt16(txtBilletes2CierreCaja.Text), 
                                                      Convert.ToInt16(txtBilletes1CierreCaja.Text),
                                                      Convert.ToString(txtUsuarioCierreCaja.Text));
                        this.Close();
                        //Clases.VariablesGlobales.state = 0;
                }
                catch (Exception ex)
                {

                    Clases.Mensaje.Advertencia(ex);
                }
            else
                MessageBox.Show(@"El cierre de caja no se ha podido realizar porque aun no se ha hecho la  " +
                                "Apertura de la caja. Realice la Apertura primero.", "Error!");
        }

        /// <summary>
        /// Calculo del Total de los billetes, dolares y POS al momento de realizar el Cierre de Caja.
        /// </summary>
        private void CalcularTotalCierre()
        {
            int L500 = 0;
            int.TryParse(txtBilletes500CierreCaja.Text, out L500);
            int L100 = 0;
            int.TryParse(txtBilletes100CierreCaja.Text, out L100);
            int L50 = 0;
            int.TryParse(txtBilletes50CierreCaja.Text, out L50);
            int L20 = 0;
            int.TryParse(txtBilletes20CierreCaja.Text, out L20);
            int L10 = 0;
            int.TryParse(txtBilletes10CierreCaja.Text, out L10);
            int L5 = 0;
            int.TryParse(txtBilletes5CierreCaja.Text, out L5);
            int L2 = 0;
            int.TryParse(txtBilletes2CierreCaja.Text, out L2);
            int L1 = 0;
            int.TryParse(txtBilletes1CierreCaja.Text, out L1);
            decimal POS = 0;
            decimal.TryParse(txtTotalPOSCierreCaja.Text, out POS);
            decimal Dolar = 0;
            decimal.TryParse(txtTotalDolaresCierreCaja.Text, out Dolar);

            txtCantidadTotalCierreCaja.Text = Convert.ToString(Convert.ToDecimal(((L500 * 500) + (L100 * 100) + 
                                                              (L50 * 50) + (L20 * 20) + (L10 * 10) + (L5 * 5) + 
                                                              (L2 * 2) + L1 + POS + 
                                                              (frmLogin.dolar * Dolar))));
            Convert.ToDecimal(txtSaldoFinalDiaCierreCaja.Text = Convert.ToString(Convert.ToDecimal((L500 * 500) +
                                                                                (L100 * 100) + (L50 * 50) +
                                                                                (L20 * 20) + (L10 * 10) + (L5 * 5) +
                                                                                (L2 * 2) + L1 + POS + 
                                                                                (frmLogin.dolar * Dolar))));
        }

        private void txtBilletes100CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtBilletes50CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtBilletes20CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtBilletes10CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtBilletes5CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtBilletes2CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtBilletes1CierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtTotalDolaresCierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        private void txtTotalPOSCierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCierre();
        }

        //Se carga el formulario y se hace la comparacion de la variable "state" para control la
        //deshabilitacion o habilitacion de los modulos cerrar y aperturar caja respectivamente. Si uno
        //esta habilitado, el otro tendra que esta deshabilitado. Los dos no pueden estar habilitados al mismo tiempo.
        private void frmAperturaCierreCaja_Load(object sender, EventArgs e)
        {
            if (state == 0)
            {
                Clases.Caja.saldoUltimo(txtSaldoTotalAperturaCaja);
                btnCerrarCaja.Enabled = false;
            }
            else if (state == 1)
            {
                Clases.Caja.saldoUltimo(txtSaldoInicialDiaCierreCaja);
                btnAbrirCaja.Enabled = false;
            }
            //Se captura el usuario que se logueo al sistema y se carga en los modulos de Apertura y Cierre.
            txtUsuarioAperturaCaja.Text = Clases.VariablesGlobales.user;
            txtUsuarioCierreCaja.Text = Clases.VariablesGlobales.user;
        }

        /// <summary>
        /// Se realiza el calculo de la diferencia del Total de Cierre de Caja con respecto
        /// al Total de la Apertura de Caja anterior
        /// </summary>
        private void CalculoDiferencia()
        {
            decimal saldoInicial = 0;
            decimal.TryParse(txtSaldoInicialDiaCierreCaja.Text, out saldoInicial);
            decimal saldoFinal = 0;
            decimal.TryParse(txtSaldoFinalDiaCierreCaja.Text, out saldoFinal);

            txtUtilidadPerdidaCierreCaja.Text = Convert.ToString(saldoFinal - saldoInicial);
        }

        private void txtSaldoFinalDiaCierreCaja_TextChanged(object sender, EventArgs e)
        {
            CalculoDiferencia();
        }

        private void txtBilletes500CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtBilletes100CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtBilletes50CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtBilletes20CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtBilletes5CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtBilletes10CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtBilletes2CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtBilletes1CierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtTotalDolaresCierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtTotalPOSCierreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtL1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        private void txtDolares_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalApertura();
        }

        private void txtDolares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)))
                errorProvider1.Clear();
            else
                e.Handled = true;
        }

        //Variable que controla el estado de caja.
        //Si la caja esta abierta la variable tomara el valor de 1. De lo contrario, tendra el valor de 0
        public static int state;

        /// <summary>
        /// Se hace la consulta a la base para saber si el ultimo movimiento de la tabla Caja
        /// fue Apertura o Cierre.
        /// Si fue apertura, la variable state tomara el valor de 1, de lo contrario tomara el valor de 0.
        /// </summary>
        public static void estado()
        {
            int var;
            Clases.Conexión conn = new Clases.Conexión();
            string query = "SELECT MAX(idDetalleCaja) FROM Restaurante.Caja WHERE idDetalleCaja = 1";
            SqlCommand cmd = new SqlCommand(query, conn.conexion);


            try
            {
                conn.Abrir();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {
                        reader.Read();

                        var = Convert.ToInt16(reader[0]);

                        if (var == 2)
                            state = 0;
                        else if (var == 1)
                            state = 1;
                    }
            }
            catch (Exception ex)
            {
                throw new Clases.Excepcion("Error!", ex);
            }
            finally
            {
                conn.Cerrar();
            }
        }
    }
}
