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
    public partial class frmMenuNuevo : Form
    {
        public frmMenuNuevo()
        {
            InitializeComponent();
        }

        private void ControlMesas_Click(object sender, EventArgs e)
        {
            frmControlMesas mesas = new frmControlMesas();
            mesas.ShowDialog();
        }

        private void Pedido_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(51);
            pedido.ShowDialog();
        }

        private void Apertura_Click(object sender, EventArgs e)
        {
            frmAperturaCierreCaja cierreCaja = new frmAperturaCierreCaja();
            cierreCaja.ShowDialog();
        }

        private void Cierre_Click(object sender, EventArgs e)
        {
            frmAperturaCierreCaja cierreCaja = new frmAperturaCierreCaja();
            cierreCaja.ShowDialog();
        }

        private void Transacciones_Click(object sender, EventArgs e)
        {
            frmTransaccionesCaja transaccionesCaja = new frmTransaccionesCaja();
            transaccionesCaja.ShowDialog();
        }

        private void Pagos_Click(object sender, EventArgs e)
        {
            frmPagosCaja pagosCaja = new frmPagosCaja();
            pagosCaja.ShowDialog();
        }

        private void Resumen_Click(object sender, EventArgs e)
        {
            frmResumenCaja resumenCaja = new frmResumenCaja();
            resumenCaja.ShowDialog();
        }

        private void Cambio_Click(object sender, EventArgs e)
        {
            frmCambioDolar cambioDolar = new frmCambioDolar();
            cambioDolar.ShowDialog();
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.ShowDialog();
        
        }

        private void Insumos_Click(object sender, EventArgs e)
        {
            frmInsumos insumos = new frmInsumos();
            insumos.ShowDialog();
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();
            proveedores.ShowDialog();
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            frmCategoriaProducto categoriaProducto = new frmCategoriaProducto();
            categoriaProducto.ShowDialog();
        }

        private void Tipo_Click(object sender, EventArgs e)
        {
            frmTipoUnidad tipoUnidad = new frmTipoUnidad();
            tipoUnidad.ShowDialog();

        }

        private void Meseros_Click(object sender, EventArgs e)
        {
            Mesero mesero = new Mesero();
            mesero.ShowDialog();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void Papelera_Click(object sender, EventArgs e)
        {
            frmPapelera papelera = new frmPapelera();
            papelera.ShowDialog();
        }

        private void CerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string fecha1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha1 = DateTime.Now.ToString();
            lblFecha.Text = fecha1;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Restaurante.Reportes.Reportes reporte = new Reportes.Reportes();
            reporte.Show();
        }
    }
}
