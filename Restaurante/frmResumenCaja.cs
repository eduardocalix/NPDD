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
    public partial class frmResumenCaja : Form
    {
        public frmResumenCaja()
        {
            InitializeComponent();
        }

        private void btnSalirResumenCaja_Click(object sender, EventArgs e)
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

        private void frmResumenCaja_Load(object sender, EventArgs e)
        {
            CargarDGWResumenCaja();
            llenarCBServiciosPublicos();
            gv(gvResumenCaja);
            ResetFormulario();
        }
        
        private void CargarDGWResumenCaja()
        {
            try
            {
                gvResumenCaja.DataSource = Clases.Caja.GetDataViewGeneral();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalidasVarias_Click(object sender, EventArgs e)
        {
            gvResumenCaja.DataSource = null;
            CargarDGWResumenCajaSalidas();
        }

        private void ResetFormulario()
        {
            cbServiciosPublicos.SelectedValue = "";
        }
        public void llenarCBServiciosPublicos()
        {
            DataTable dt = new DataTable();
            Clases.Conexión conexión = new Clases.Conexión();
            string sql = "SELECT Descripcion FROM Restaurante.ServicioPublico";
            SqlCommand cmd = new SqlCommand(sql, conexión.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbServiciosPublicos.DisplayMember = "Descripcion";
            cbServiciosPublicos.ValueMember = "Descripcion";
            cbServiciosPublicos.DataSource = dt;
        }

        private void CargarDGWResumenCajaSalidas()
        {
            try
            {
                
                gvResumenCaja.DataSource = Clases.OtrasSalidas.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnFiltrarAperturasCierres_Click(object sender, EventArgs e)
        {

        }
    }
}
