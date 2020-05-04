using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frmCategoriaProducto : Form
    {
        public frmCategoriaProducto()
        {
            InitializeComponent();
        }

        private void frmTipoProducto_Load(object sender, EventArgs e)
        {
            CargarDGWTipoProducto();
            ResetFormulario();
        }
        private int id = 0;
        private void CargarDGWTipoProducto()
        {
            try
            {
                dgvCategoriaProducto.DataSource = Clases.CategoriaProducto.GetDataView(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgwTipoUnidadEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarCategoriaProducto
                    (
                        txtDescripcion.Text
                    );
                CargarDGWTipoProducto();

            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar la categoria del producto", "Modificar Categoria Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.ModificarCategoriaProducto
                        (
                            this.id,
                            txtDescripcion.Text
                        );
                    ResetFormulario();
                }
                catch (Exception ex)
                {

                    Clases.Mensaje.Advertencia(ex);
                }

            }
        }

        private void dgvTipoProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CategoriaProducto categoriaproducto = new Clases.CategoriaProducto();
            categoriaproducto.ObtenerCategoriaProducto(
                Convert.ToInt32(
                    dgvCategoriaProducto.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvCategoriaProducto.Select();
            this.id = categoriaproducto.Id;

            txtId.Text = categoriaproducto.Id.ToString();
            txtDescripcion.Text = categoriaproducto.Descripcion;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void ResetFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            CargarDGWTipoProducto();
            dgwTipoUnidadEstilo(dgvCategoriaProducto);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtDescripcion.Enabled = true;
            this.id = 0;
            txtDescripcion.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar la categoria del Producto" + txtDescripcion.Text, "Eliminar la categoria Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarCategoriaProducto(this.id);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
