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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

            CargarDGWInventario();
            CargarCMBProveedores();
            CargarCMBTipoProducto();
            CargarCMBCategoriaProducto();
            ResetFormulario();
        }
        private int id = 0;
        private int idInsumoInventario = 0;
        private int idInsumo = 0;
        private void CargarDGWInventario()
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

        private void dgwInventarioEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }



        private void CargarCMBProveedores()
        {
            DataTable dt = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "select * FROM Restaurante.Proveedores";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "nombre";
            cmbProveedor.DataSource = dt;
        }

        private void CargarCMBTipoProducto()
        {
            DataTable dt2 = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "select * FROM Restaurante.TipoProducto";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
            cmbTipoProducto.DisplayMember = "nombre";
            cmbTipoProducto.ValueMember = "nombre";
            cmbTipoProducto.DataSource = dt2;
        }

        private void CargarCMBCategoriaProducto()
        {
            DataTable dt3 = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "select * FROM Restaurante.CategoriaProducto";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt3);
            cmbCategoriaProducto.DisplayMember = "descripcion";
            cmbCategoriaProducto.ValueMember = "descripcion";
            cmbCategoriaProducto.DataSource = dt3;
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
        }
            private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Clases.TipoProducto tipoproducto = new Clases.TipoProducto();
                tipoproducto.ObtenerTipoProductoPorNombre(cmbTipoProducto.SelectedValue.ToString());

                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto();
                categoria.ObtenerCategoriaProductoPorNombre(cmbCategoriaProducto.SelectedValue.ToString());
                Clases.Proveedores proveedor = new Clases.Proveedores();

                if (cmbTipoProducto.Text == "Elaborado")
                {
                    proveedor.Id = 1;

                    Clases.Restaurante.AgregarInventario
                    (
                        txtDescripcion.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        Convert.ToDecimal(txtPrecioVenta.Text),
                        Convert.ToDecimal(txtCantidad.Text),
                        Convert.ToDecimal(txtCantMinima.Text),
                        categoria.Id,
                        tipoproducto.Id,
                        proveedor.Id
                    );
                    CargarDGWInventario();

                }
                else
                {

                    proveedor.ObtenerProveedorPorNombre(cmbProveedor.SelectedValue.ToString());
                    //txtCantMinima.Text = "0";
                    Clases.Restaurante.AgregarInventario
                    (
                        txtDescripcion.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        Convert.ToDecimal(txtPrecioVenta.Text),
                        Convert.ToDecimal(txtCantidad.Text),
                        Convert.ToDecimal(txtCantMinima.Text),
                        categoria.Id,
                        tipoproducto.Id,
                        proveedor.Id
                    );
                    CargarDGWInventario();
                }

            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar el Inventario", "Modificar Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Proveedores proveedor = new Clases.Proveedores();

                    Clases.TipoProducto tipoproducto = new Clases.TipoProducto();
                    tipoproducto.ObtenerTipoProductoPorNombre(cmbTipoProducto.SelectedValue.ToString());

                    Clases.CategoriaProducto categoria = new Clases.CategoriaProducto();
                    categoria.ObtenerCategoriaProductoPorNombre(cmbCategoriaProducto.SelectedValue.ToString());

                    if (cmbTipoProducto.Text == "Elaborado")
                    {
                        proveedor.Id = 1;
                        Clases.Restaurante.ModificarInventario
                        (
                        this.id,
                        txtDescripcion.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        Convert.ToDecimal(txtPrecioVenta.Text),
                        Convert.ToDecimal(txtCantidad.Text),
                        Convert.ToDecimal(txtCantMinima.Text),
                        categoria.Id,
                        tipoproducto.Id,
                        proveedor.Id
                        );
                        ResetFormulario();
                    }
                    else
                    {
                        proveedor.ObtenerProveedorPorNombre(cmbProveedor.SelectedValue.ToString());
                        //txtCantMinima.Text = "0";
                        Clases.Restaurante.ModificarInventario
                        (
                        this.id,
                        txtDescripcion.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        Convert.ToDecimal(txtPrecioVenta.Text),
                        Convert.ToDecimal(txtCantidad.Text),
                        Convert.ToDecimal(txtCantMinima.Text),
                        categoria.Id,
                        tipoproducto.Id,
                        proveedor.Id
                        );
                        ResetFormulario();
                    }

                }
                catch (Exception ex)
                {
                    Clases.Mensaje.Advertencia(ex);
                }

            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Inventario inventario = new Clases.Inventario();
            inventario.ObtenerInventario(
                Convert.ToInt32(
                    dgvInventario.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvInventario.Select();
            this.id = inventario.IdInventario;
            CargarDGWInsumosInventario();

            txtId.Text = inventario.IdInventario.ToString();
            txtDescripcion.Text = inventario.Descripcion.ToString();
            txtCosto.Text = inventario.Costo.ToString();
            txtPrecioVenta.Text = inventario.PrecioVenta.ToString();
            txtCantidad.Text = inventario.Cantidad.ToString();
            txtCantMinima.Text = inventario.CantidadMinima.ToString();
            cmbTipoProducto.SelectedIndex = inventario.IdTipoProducto - 1;
            cmbProveedor.SelectedIndex = inventario.IdProveedor - 1;
            cmbCategoriaProducto.SelectedIndex = inventario.IdCategoria - 1;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void ResetFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";
            txtCantMinima.Text = "";
            cmbTipoProducto.SelectedValue = "";
            cmbProveedor.SelectedValue = "";
            cmbCategoriaProducto.SelectedValue = "";
            CargarDGWInventario();
            dgwInventarioEstilo(dgvInventario);

            txtNombreInsumo.Text = "";
            txtCantidadInsumo.Text = "";

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtDescripcion.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecioVenta.Enabled = true;
            this.id = 0;
            txtDescripcion.Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de Eliminar el Inventario", "Eliminar Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarInventario(this.id);
                }
                catch (Exception ex)
                {
                    Clases.Mensaje.Advertencia(ex);
                }
                finally
                {
                    ResetFormulario();
                }

            }
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscarInsumo.DataSource = Clases.Insumos.GetDataViewInsumo(txtNombreInsumo.Text);
        }

        private void txtNombreInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidadInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ObtenerIdInventario()
        {
            Clases.Inventario inventario = new Clases.Inventario();
            inventario.ObtenerIdInventario(this.txtDescripcion.Text);
            this.id = inventario.IdInventario;
        }


        private void CargarDGWInsumosInventario()
        {
            try
            {
                dgvInsumosInv.DataSource = Clases.InsumoProductos.GetDataView(this.id);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarInsumoProducto
                    (
                        this.idInsumo,
                        this.id,
                        Convert.ToDecimal(txtCantidadInsumo.Text)
                    );
                CargarDGWInsumosInventario();
                CargarDGWInventario();
                txtNombreInsumo.Text = "";
                txtCantidadInsumo.Text = "";

            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void dgvBuscarInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Insumos insumos = new Clases.Insumos();
            insumos.ObtenerInsumo(
                Convert.ToInt32(
                    dgvBuscarInsumo.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvBuscarInsumo.Select();
            this.idInsumo = insumos.Id;
            ObtenerIdInventario();
        }

        private void dgvInsumosInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.InsumoProductos insumoproducto = new Clases.InsumoProductos();
            insumoproducto.ObtenerInsumosProductos(
                Convert.ToInt32(
                    dgvInsumosInv.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvInsumosInv.Select();

            this.idInsumoInventario = insumoproducto.IdInsumoProducto;
            this.idInsumo = insumoproducto.IdInsumo;
            this.id = insumoproducto.IdInventario;
            txtCantidadInsumo.Text = insumoproducto.Cantidad.ToString();
            txtNombreInsumo.Text = insumoproducto.Nombre;


        }

        private void btnModificarInsumo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar los Insumos", "Modificar Insumo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.ModificarInsumoProducto
                    (
                        this.idInsumoInventario,
                        this.idInsumo,
                        this.id,
                        Convert.ToDecimal(txtCantidadInsumo.Text)
                    );
                    CargarDGWInsumosInventario();
                    CargarDGWInventario();
                    txtNombreInsumo.Text = "";
                    txtCantidadInsumo.Text = "";

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnEliminarInsumo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de Eliminar el Insumo", "Eliminar Insumo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarInsumoProducto(this.idInsumoInventario, this.id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ResetFormulario();
                }

            }
        }

        private void txtCantMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnNuevoInsumo_Click(object sender, EventArgs e)
        {
            txtNombreInsumo.Text = "";
            txtCantidadInsumo.Text = "";
        }

        private void cmbTipoProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTipoProducto.Text == "Elaborado")
            {
                panel1.Visible = true;
                dgvInsumosInv.Visible = true;
                cmbProveedor.Visible = false;
                lblProveedor.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                dgvInsumosInv.Visible = false;
                cmbProveedor.Visible = true;
                lblProveedor.Visible = true;
            }
        }

        private void cmbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
