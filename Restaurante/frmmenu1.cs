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
    public partial class frmmenu1 : Form
    {
        public int id2;
        public int color;
        public frmmenu1(int mesa,int color2)
        {
            InitializeComponent();
            this.id2 = mesa;
            this.color = color2;
        }
        public int Color1 { get; set; }
        private void frmmenu1_Load(object sender, EventArgs e)
        {
            if (color==1)
            {
                btnCancelar.Enabled = false;
                btnEntrega.Enabled = false;
            }
            else
            {
                btnCancelar.Enabled = true;
                btnEntrega.Enabled = true;
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(id2);

            if (pedido.ShowDialog() == DialogResult.OK)
            {
                Color1 = pedido.Color1;
            }
            else
            {
                Color1 = 0;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
   

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            frmEntrega entrega = new frmEntrega(id2);
            if(entrega.ShowDialog() == DialogResult.OK)
            {
                Color1 = entrega.Color1;
            }
            else
            {
                Color1 = 0;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura(id2);
           if( factura.ShowDialog() == DialogResult.OK)
            {
                Color1 = factura.Color1;
            }
            else
            {
                Color1 = 0;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Color1 = 0;
        
        DialogResult = DialogResult.OK;
            this.Close();
    }
    }
}
