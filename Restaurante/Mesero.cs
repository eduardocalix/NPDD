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
    public partial class Mesero : Form
    {
        public Mesero()
        {
            InitializeComponent();
        }

        private void Mesero_Load(object sender, EventArgs e)
        {
            CargarDGWMeseros();
            ResetFormulario();
        }
        private int id = 0;

        private void CargarDGWMeseros()
        {
            try
            {
                dgvMeseros.DataSource = Clases.Mesero.GetDataView(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgwMeseroEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarMesero
                    (
                        txtIdentidad.Text,
                        txtNombre.Text,
                        txtApellido.Text
                    );
                CargarDGWMeseros();
            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar al Mesero ", "Modificar Mesero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {

                try
                {
                    Clases.Restaurante.ModificarMesero(
                        Convert.ToInt32(this.id),
                        txtIdentidad.Text,
                        txtNombre.Text,
                        txtApellido.Text
                        );
                    ResetFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void dgvMeseros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Mesero mesero = new Clases.Mesero();
            mesero.ObtenerMesero(
                Convert.ToInt32(
                    dgvMeseros.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvMeseros.Select();
            this.id = mesero.Id;
            txtIdentidad.Text = Convert.ToString(mesero.Identidad);
            txtNombre.Text = mesero.Nombre;
            txtApellido.Text = mesero.Apellido;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void ResetFormulario()
        {
            txtNombre.Text = "";
            txtIdentidad.Text = "";
            txtApellido.Text = "";
            CargarDGWMeseros();
            dgwMeseroEstilo(dgvMeseros);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtIdentidad.Enabled = true;
            txtApellido.Enabled = true;
            this.id = 0;
            txtIdentidad.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
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

        }

        private void dgvMeseros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar al Mesero " + txtNombre.Text, " Eliminar Mesero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarMesero1(this.id,0);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
