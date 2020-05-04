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
    public partial class frmPedido : Form
    {
        public int id2;
        public frmPedido(int mesa)
        {
            this.id2 = mesa;
            InitializeComponent();
        }

        public int Color1 { get; set; }


        private void frmPedido_Load(object sender, EventArgs e)
        {
            CargarCMBMeseros();
            CargarCMBMesa();
            CargarLSWCategoria();
            if (id2 == 51)
            {
                btnFactura.Visible = true;
                btnFactura.Enabled = true;
            }
            foreach (DataGridViewColumn c in dgvPedido.Columns)
                if (c.Name != "Cantidads") c.ReadOnly = true;
        }
        //Variable controla la mesa
        public int mesa1;
        /// <summary>
        /// Se llena el text de mesa
        /// </summary>
        private void CargarCMBMesa()
        {
          
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT * FROM Restaurante.Mesas WHERE id= "+id2+";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                // Establecer la conexión
                conexion.Abrir();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                 {
                    lblMesa.Items.Add(Convert.ToString(rdr[1]));
                    mesa1 = Convert.ToInt16(rdr[0]);
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
        private void CargarLSWCategoria()
        {
            try
            {
                dgvCategoria.DataSource = Clases.CategoriaProducto.GetDataView1();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Se encarga de darle estilos a los grid
        /// </summary>
        private void dgwPedidoEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        /// <summary>
        /// Se encarga de mostrar los meseros
        /// </summary>
        private void CargarCMBMeseros()
        {
            DataTable dt = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "select * FROM Restaurante.Meseros";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbMesero.DisplayMember = "nombre";
            cmbMesero.ValueMember = "nombre";
            cmbMesero.DataSource = dt;
        }

        private int id = 0;
        /// <summary>
        /// Llena el grid del inventario
        /// </summary>
        private void CargarDGWinventario()
        {
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// cuando se le da click al grid de inventario se llena el grid de pedidos
        /// </summary>
        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int cantidad = 1;
                Clases.Inventario inventario = new Clases.Inventario();
                inventario.ObtenerInventario2(
                    Convert.ToInt32(
                        dgvInventario.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                        )
                    );
                dgvInventario.Select();
                this.id = inventario.IdInventario;
                decimal importe = inventario.PrecioVenta * cantidad;
                producto(inventario.IdInventario, inventario.Descripcion, cantidad, inventario.PrecioVenta, importe);
            }
   
        }
        /// <summary>
        /// Funcion que hace la suma del importe en el grid de pedido
        /// </summary>
        public void Total()
        {
            decimal total = 0;
            for (int i = 0; i < dgvPedido.Rows.Count ; i++)
            {
                total +=  Convert.ToDecimal(dgvPedido.Rows[i].Cells["PrecioI"].Value);

            }
            txtTotal.Text = Convert.ToString(total);
        }
        /// <summary>
        /// Funcion que hace el traslado de un grid a otro
        /// </summary>
        public void producto(int id, string nombre, int cantidad, decimal precio, decimal importe)
        {
            int igual = 0;
            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                if (Convert.ToInt16(dgvPedido.Rows[i].Cells["Código"].Value)==id)
                {
                    igual = 1;
                   int codigo = Convert.ToInt16(dgvPedido.Rows[i].Cells["Código"].Value);
                    suma(i, 1);
                   
                }
            }
            if (igual == 0)
            {
                        
                dgvPedido.Rows.Add(id.ToString(), nombre, cantidad.ToString(), precio.ToString(), importe.ToString());
                Total();
            }
        }
        int Comidas = 3;
        int Licores = 2;
        int Bebidas = 1;
        int Categoria;

        /// <summary>
        /// Boton de filtro por categoria Comidas
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {

            
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(Comidas);
                Categoria = Comidas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Boton de filtro por categoria Bebidas
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            //Bebidas
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(Bebidas);
                Categoria = Bebidas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Boton de filtro por categoria Licores
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            //licores
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(Licores);
                Categoria = Licores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Boton Salir
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        int idPedido;
        /// <summary>
        /// Boton que hace la insercion de todos los detalle del pedido 
        /// </summary>
        public void Detalle() {      
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT MAX(id) FROM Restaurante.Pedidos";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                // Establecer la conexión
                conexion.Abrir();
                SqlDataReader rdr = cmd.ExecuteReader();
                //MessageBox.Show(Convert.ToString(rdr[0]));
                while (rdr.Read())
                {                  
                    idPedido = Convert.ToInt16(rdr[0]);
                }
                Producto(idPedido);
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
        }

        /// <summary>
        /// Funcion que recorre todo el grid para agregar fila por fila del pedido
        /// </summary>
        public void Producto(int id)
        {
            if (id != 0)
            {
                for (int i = 0; i < dgvPedido.Rows.Count; i++)
                {

                    try
                    {
                        Clases.Detalle detalle = new Clases.Detalle(
                            id,
                            Convert.ToInt16(dgvPedido.Rows[i].Cells["Código"].Value.ToString()),
                            Convert.ToInt16(dgvPedido.Rows[i].Cells["Cantidads"].Value.ToString()),
                           Convert.ToDecimal(dgvPedido.Rows[i].Cells["PrecioI"].Value.ToString())
                         );
                        detalle.Agregar();
                       // MessageBox.Show("Agregado");
                    }
                    catch (Exception ex)
                    {

                        Clases.Mensaje.Advertencia(ex);
                    }
                }
                
                    Color1 = 1;
                
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtRTN.Text == "")
            {
                txtRTN.Text = "CONSUMIDOR FINAL";
            }
            if (txtNombre.Text=="")
            {
                txtNombre.Text = "9999";
            }
            
            try
            {
                Clases.Mesero mesero = new Clases.Mesero();
                mesero.ObteneMeseroPorNombre(cmbMesero.SelectedValue.ToString());
  
                Clases.Restaurante.AgregarPedido
                    (
                        Convert.ToString(fecha1),
                        Convert.ToInt32(mesa1),
                         txtRTN.Text,
                        txtNombre.Text,
                        mesero.Id
                    );

                MessageBox.Show("Comanda enviada");
                Detalle();
                if (mesa1!=51)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
            //int m = 1;
            
            //return m;
        }

        private void btnPreFac_Click(object sender, EventArgs e)
        {
            Color1 = 2; 
            MessageBox.Show("Prefactura imprimiendo");
        }

        private void btnAumentarCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                suma(id3,1);
            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }
        public int id3=0;
        //Selección fila completa.
  

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPedido != null)
            {
                //DataGridViewRow fila = dgvPedido.Rows[e.RowIndex];
                id3 = e.RowIndex;
            }
        }


        string fecha1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha1 = DateTime.Now.ToString();
            lblFecha.Text = fecha1;
        }

        public void suma(int id,int op)
        {

            if (Convert.ToInt16(dgvPedido.Rows[id].Cells["Cantidads"].Value) == 1 && op==-1)
            {
                MessageBox.Show("No se puede disminuir más la cantidad");
            }
            else
            {
                dgvPedido.Rows[id].Cells["Cantidads"].Value = Convert.ToInt16(dgvPedido.Rows[id].Cells["Cantidads"].Value.ToString()) + op;
                decimal cantidad = Convert.ToDecimal(dgvPedido.Rows[id].Cells["Cantidads"].Value.ToString());
                decimal importe = Convert.ToDecimal(dgvPedido.Rows[id].Cells["PrecioU"].Value.ToString());
                dgvPedido.Rows[id].Cells["PrecioI"].Value = importe * cantidad;
                Total();
            }
        }
  

        private void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            suma(id3,-1);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedido != null)
                {
                    dgvPedido.Rows.RemoveAt(id3);
                    Total();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede disminuir más la cantidad");
                throw ex;
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            dgvInventario.DataSource = Clases.Inventario.GetDataViewFiltro(Categoria,txtProducto.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "";
        }



      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int cate=Convert.ToInt32(dgvCategoria.Rows[e.RowIndex].Cells["Código"].Value.ToString());

              dgvInventario.DataSource = Clases.Inventario.GetDataView1(cate);
                Categoria = cate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            frmmenu1 pedido = new frmmenu1(id2, 2);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
