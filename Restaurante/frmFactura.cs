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
    public partial class frmFactura : Form
    {
        public frmFactura(int mesa)
        {

            this.id2 = mesa;
            InitializeComponent();
        }
        public int id2;
        public int Color1 { get; set; }
        public int id;
        public string rtn;
        public string nombre;
        public int idMesero;
        public int estado;

        /// <summary>
        /// Se llena el text de mesa
        /// </summary>
        private void CargarCMBMesa()
        {

            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT * FROM Restaurante.Mesas WHERE id= " + id2 + ";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                // Establecer la conexión
                conexion.Abrir();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lblMesa.Items.Add(Convert.ToString(rdr[1]));
                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
            }
            finally
            {
                // Cerrar la conexión
                conexion.Cerrar();
            }
            //lblMesa.Text = Convert.ToString(cmd);
        }
        private void CargarCMBPedido(int id,int mes)
        {
            Clases.Pedidos pedidos = new Clases.Pedidos();
            pedidos.ObtenerPedido(id,mes);
            //id = pedidos.IdPedido;
            //MessageBox.Show(pedidos.Nombre);
           txtRTN.Text  = pedidos.RTN;
            txtNombre.Text = pedidos.Nombre;
            idMesero = pedidos.IdMesero;
            estado = pedidos.Estado;
            //CargarCMBMesero(idMesero);
            //CargarDGWPedido(id);


        }
        public double impuesto;
         public double suma;
        public static double total1;
        public void Contar() {
           
                 
            for (int i = 0; i < dgvDetalle.Rows.Count; i++)
            {
                if (Convert.ToInt16(dgvDetalle.Rows[i].Cells[4].Value) == 2)
                {
                    impuesto += Convert.ToDouble(dgvDetalle.Rows[i].Cells[3].Value);
                }
                else
                {
                    suma += Convert.ToDouble(dgvDetalle.Rows[i].Cells[3].Value);
                }

                //}
            }
             total1 = suma + impuesto;
            txtTotal.Text = Convert.ToString(total1); 
        }
        public static int IdUsuario;
        public static int Idapertura = Clases.VariablesGlobales.idapertura;
        private void Id() {
            Clases.Pedidos pedidos = new Clases.Pedidos();
            pedidos.ObtenerPedido2(id2,2);
            CargarCMBPedido(pedidos.IdPedido,id2);
            Clases.Usuarios usuarios = new Clases.Usuarios();
            usuarios.ObtenerUsuario(Clases.VariablesGlobales.user);
            IdUsuario = usuarios.id;
        }


        private void frmFactura_Load(object sender, EventArgs e)
        {
            Encabezado();
            CargarCMBMesa();
            Id();
            CargarDGWPedido(id2);
            cmbTipo.SelectedItem = 1;
 
        }
        private void CargarDGWDetalle(int id)
        {
            try
            {
                //MessageBox.Show(id.ToString());
                dgvDetalle.DataSource = Clases.Detalle.GetDataView1(id);
                Contar();
                dgvDetalle.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                //dgvPedidos.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDGWPedido(int id2)
        {
            try
            {
                //MessageBox.Show(id.ToString());
                dgvPedido.DataSource = Clases.Pedidos.GetDataView1(id2);
                dgvPedido.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                //dgvPedidos.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Encabezado()
        {

            lblSetFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            int hora = DateTime.Now.Hour;
            if (hora > 0 && hora < 12)
            {
                lblSetJornada.Text = "Matutina";
            }
            else
            {
                if (hora >= 12 && hora < 18)
                {
                    lblSetJornada.Text = "Vespertina";
                }
                else
                {
                    lblSetJornada.Text = "Nocturna";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea imprimir factura?", "Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                int tipo = 0;
                string nombre = cmbTipo.SelectedItem.ToString();
                if (nombre == "Efectivo")
                {
                    tipo = 1;
                }
                else
                {
                    if (nombre == "Tarjeta")
                    {
                        tipo = 2;
                    }
                    else
                    {
                        tipo = 3;
                    }
                }
                Color1 = 4;
                if (txtDescuento.Text == "")
                {
                    txtDescuento.Text = "0";
                }
                try
                {
                    Clases.Factura factura = new Clases.Factura(
                        idPedido, IdUsuario,
                       Convert.ToDecimal(txtSubTotal.Text),
                        Convert.ToDecimal(txtDescuento.Text),
                        Convert.ToDecimal(txtExento.Text),
                       Convert.ToDecimal(txt15.Text),
                        Convert.ToDecimal(txt18.Text),
                       Convert.ToDecimal(txtTotal.Text),
                       1, tipo);

                    factura.Agregar();
                    dgvPedido.Rows.RemoveAt(idgrid);
                    Clases.Restaurante.ModificarPedido(idPedido, 3);
                    limpiar();
                    if (dgvPedido.RowCount == 0)
                    {
                        MessageBox.Show("No hay más pedidos por cobrar");
                        CargarDGWDetalle(150000);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void limpiar()
        {
            txt15.Text = "";
            txt18.Text = "";
            txtDescuento.Text = "";
            txtExento.Text = "";
            txtImporte.Text = "";
            txtNombre.Text = "";
            txtRTN.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtVuelto.Text = "";


        }
        public double total;
        public double importe;
        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            if (txtImporte.Text == "")
            {
                importe = 0;
            }
            else { 
            importe = Convert.ToDouble(txtImporte.Text); }
             
            if (importe < Convert.ToDouble(txtTotal.Text))
            {
                txtVuelto.Text = "0.00";
            }
            else
            {
                txtVuelto.Text = Convert.ToString(importe - Convert.ToDouble(txtTotal.Text));
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {


            txt15.Text = Convert.ToString(suma * 0.15);
                txt18.Text= Convert.ToString(impuesto * 0.15);
            txtSubTotal.Text = Convert.ToString(total1 - (Convert.ToDouble(txt18.Text) + Convert.ToDouble(txt15.Text)));
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (txtDescuento.Text != "")
            {
                txtTotal.Text = Convert.ToString(total1 - Convert.ToDouble(txtDescuento.Text));
            }
            else { txtTotal.Text = Convert.ToString(total1); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvPedido.RowCount >= 1 && Color1 != 4)
            {
                if (Color1 == 3)
                {
                    Color1 = 2;
                }
                else
                {
                    Color1 = 1;
                }
            }
            else
            {
                Color1 = 0;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txt15_TextChanged(object sender, EventArgs e)
        {
            
        }
        public int idPedido;
        public int idgrid;
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idPedido = Convert.ToInt32(dgvPedido.Rows[e.RowIndex].Cells["Código"].Value.ToString());
                if (idPedido > 0)
                {
                    idgrid = e.RowIndex;
                    dgvPedido.Select();
                    total1 = 0;
                    suma = 0;
                    impuesto = 0;
                    CargarDGWDetalle(idPedido);
                   // dgvDetalle.Enabled = true;
                    //dgvPedido.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { DialogResult respuesta = MessageBox.Show("¿Desea imprimir la prefactura?", "Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                MessageBox.Show("Prefactura enviada");
                Color1 = 2;
            }
        }
    }
}
