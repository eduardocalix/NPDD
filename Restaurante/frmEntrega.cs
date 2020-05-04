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
    public partial class frmEntrega : Form
    {
        public int Color1 { get; set; }
        public frmEntrega(int mesa)
        {
            this.id2=mesa;
        InitializeComponent();
        }
        public int id2;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
        public int mesa1;
        public int idPro;
        public string rtn;
        public string nombre;
        public int idMesero;
        public int estado;
        
        /// <summary>
        /// Se llena el text de mesa
        /// </summary>
        private void CargarCMBPedido(int id,int mesa)
        {
            Clases.Pedidos pedidos = new Clases.Pedidos();
            pedidos.ObtenerPedido(id,mesa);
            idMesero = pedidos.IdMesero;
            CargarCMBMesero(idMesero);
            
        }
        private void Id()
        {
            Clases.Pedidos pedidos = new Clases.Pedidos();
            pedidos.ObtenerPedido2(id2,1);
            
                CargarCMBPedido(pedidos.IdPedido, id2);
            
        }

        private void CargarPedidos()
        {
            dgvPedidos.DataSource = Clases.Pedidos.GetDataView(id2);
            if (dgvPedidos.RowCount==0)
            {
                MessageBox.Show("No hay pedidos en mesa");
            }

        }
        private void CargarDGWDetalle(int id)
        {
            try
            {
                dgvDetalle.DataSource = Clases.Detalle.GetDataView(id);        
                dgvDetalle.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                btnPreparacion.Enabled = true;
                if (dgvDetalle.RowCount >= 1)
                {
                    btnEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
        private void CargarCMBMesero(int id3)
        {

            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT * FROM Restaurante.Meseros WHERE id= " + id3 + ";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                // Establecer la conexión
                conexion.Abrir();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lblMesero.Items.Add(Convert.ToString(rdr[2]));
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



        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount==0 )
            {
                Color1 = 1;
            }
            else {
                Color1 = 1; }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {
            btnEntregado.Enabled = false;
            Id();
            CargarPedidos();
            CargarCMBMesa();
        }
        string fecha1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha1 = DateTime.Now.ToString();
            lblFecha.Text = fecha1;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (idgrid != -1 )
            {

                dgvDetalle.Rows[idgrid].DefaultCellStyle.BackColor = Color.Green;
                desbloquear();
            }
        }
        int cuentaGrid=0;
        public void desbloquear()
        {

            for (int i = 0; i < dgvDetalle.RowCount; i++)
            {
                if (dgvDetalle.Rows[i].DefaultCellStyle.BackColor == Color.Green)
                {
                    cuentaGrid += 1;
                    if (cuentaGrid== dgvDetalle.RowCount)
                    {
                        btnEntregado.Enabled = true;
                    }
                }
            }
        }
        public int idgrid;

  
        int tiempo=2000;

        private void btnEntregado_Click(object sender, EventArgs e)
        {

            if (idgrid != -1)
            {
                timer2.Interval =tiempo;
                dgvDetalle.Rows[idgrid].DefaultCellStyle.BackColor = Color.Orange;
                timer2.Start();
            }

        }
        public void tempo() {

            //timer2.Enabled = false;
            timer2.Stop();

            dgvDetalle.Rows.RemoveAt(idgrid);
            Clases.Restaurante.ModificarDetalle(detalle, 2);
            if (dgvDetalle.Rows.Count == 0)
            {
                Clases.Restaurante.ModificarPedido(idPedido, 2);
                dgvPedidos.Enabled = true;
                dgvDetalle.Enabled = false;
                CargarPedidos();
            }
        }
        public int idPedido;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idPedido = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells["Código"].Value.ToString());
                if (idPedido > 0)
                {
                    CargarDGWDetalle(idPedido);
                    dgvDetalle.Enabled = true;
                    dgvPedidos.Enabled = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 2000)
            {
                timer2.Interval += 1000;
            }
            else
            {
                tempo();
                timer2.Stop();
            }
        }
        public int detalle;
        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                detalle = Convert.ToInt32(dgvDetalle.Rows[e.RowIndex].Cells["id"].Value.ToString());
                idgrid = e.RowIndex;
                dgvDetalle.Select();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.Restaurante.ModificarDetalle(detalle, 4);
        }
    }
}
