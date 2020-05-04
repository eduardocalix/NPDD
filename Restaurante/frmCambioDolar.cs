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
    public partial class frmCambioDolar : Form
    {
        public frmCambioDolar()
        {
            InitializeComponent();
            txtLempirasCambioDolar.Text = Convert.ToString(frmLogin.dolar);
        }

        private void btnSalirAperturarCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
