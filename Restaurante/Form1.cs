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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Clases.Conexión conexion = new Clases.Conexión();
        Clases.Usuarios usuario = new Clases.Usuarios();
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                errorProvider1.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtUsuario, "Solo se permiten letras en el Usuario");
                errorProvider1.GetError(txtUsuario);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (ValidacionCampos())
            {
                errorProvider1.Clear();
                try
                {
                    usuario.ObtenerUsuario(txtUsuario.Text.Trim());
                    if (usuario.usuario != txtUsuario.Text.Trim() || usuario.clave != txtClave.Text.Trim())
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(txtUsuario, "El usuario '" + txtUsuario.Text.ToUpper() + "' no existe ó la clave ingresada es incorrecta");
                       // LimpiarFormulario();
                    }
                    else
                    {
                        Clases.VariablesGlobales.user = txtUsuario.Text;
                        MessageBox.Show("Bienvenido");
                        /* MenuPrincipal menuPrincipal = new MenuPrincipal();
                         menuPrincipal.rol = 1;*/
                        frmMenuNuevo menu = new frmMenuNuevo();

                        this.Hide();
                        menu.ShowDialog();
                        this.Show();
                        LimpiarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n Origen del problema '" + ex.Source + "'\n en el metodo '" + ex.TargetSite + "'");
                }
            }

        }

        private Boolean ValidacionCampos()
        {
            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUsuario, "Ingrese el nombre del usuario");
                return false;
            }
            else if (txtClave.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtClave, "Ingrese la clave del usuario");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Se navega por la pagina web especificada y se captura el dato seleccionado. 
            browser.Navigate("http://www.bch.hn/");
            browser.ScriptErrorsSuppressed = true;
            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.datosCargados);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Contiene la pagina web en la que se buscara el dato.
        /// </summary>
        WebBrowser browser = new WebBrowser();

        /// <summary>
        /// Variable que contiene el cambio de Dolar en Lempiras.
        /// </summary>
        public static decimal dolar { get; set; }

        private void datosCargados(object sender, EventArgs e)
        {
            //Se navega, se busca y se selecciona solo el dato que se necesita.
            int i = 0;
            foreach (HtmlElement item in browser.Document.All)
            {
                if (item.GetAttribute("classname").Contains("neg") && i == 0)
                {
                    dolar = Convert.ToDecimal(item.InnerText);
                    i += 1;
                }
            }
        }
    }
}
