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
using System.Data;

namespace Restaurante
{
    public partial class frmControlMesas : Form
    {
        public frmControlMesas()
        {
            InitializeComponent();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int id;
        //private void CargarCMBPedido(int id2)
        //{
        //    Clases.Pedidos pedidos = new Clases.Pedidos();
        //    pedidos.ObtenerPedido(id2, 1);
        //    id = pedidos.IdPedido;

        //    rtn = pedidos.RTN;
        //    nombre = pedidos.Nombre;
        //    idMesero = pedidos.IdMesero;
        //    estado = pedidos.Estado;
        //    CargarCMBMesero(idMesero);
        //    CargarDGWPedido(id);


        //}
        public static Color valorColor;
        public int color;
        public void Llamar(int mesa,int color2) {

            frmmenu1 pedido = new frmmenu1(mesa,color2);

            if (pedido.ShowDialog() == DialogResult.OK)
            {
                 color = pedido.Color1;
            }
            
        }

        public void mesa(int c, PictureBox n)
        {
            if (c == 0)
            {
                PictureBox box = new PictureBox();
                n.BackColor = Color.Transparent;
            }
            else
            {
                if (c == 1)
                {
                    n.BackColor = Color.DarkRed;
                }
                else
                {
                    if (c == 2) { n.BackColor = Color.Yellow; }
                }
            }
        }
        //string color1;
        private void mesas1_Click(object sender, EventArgs e)
        {
            if (mesas1.BackColor == Color.Transparent)
            {
                Llamar(1, 1);
            }
            else
            {
                Llamar(1, 2);
            }
            mesa(color, mesas1);
        }


        private void mesas2_Click(object sender, EventArgs e)
        {
            if (mesas2.BackColor == Color.Transparent)
            {
                Llamar(2, 1);
            }
            else
            {
                Llamar(2, 2);
            }
            mesa(color, mesas2);
        }

        private void mesas3_Click(object sender, EventArgs e)
        {
            if (mesas3.BackColor == Color.Transparent)
            {
                Llamar(3, 1);
            }
            else
            {
                Llamar(3, 2);
            }
            mesa(color, mesas3);
        }

        private void mesas4_Click(object sender, EventArgs e)
        {
            if (mesas4.BackColor == Color.Transparent)
            {
                Llamar(4, 1);
            }
            else
            {
                Llamar(4, 2);
            }
            mesa(color, mesas4);
        }

        private void mesas5_Click(object sender, EventArgs e)
        {
            if (mesas5.BackColor == Color.Transparent)
            {
                Llamar(5, 1);
            }
            else
            {
                Llamar(5, 2);
            }
            mesa(color, mesas5);
        }
        
        private void mesas6_Click(object sender, EventArgs e)
        {
                if (mesas6.BackColor == Color.Transparent)
                {
                    Llamar(6, 1);
                }
                else
                {
                    Llamar(6, 2);
                }
            mesa(color, mesas6);
        }

        private void mesas7_Click(object sender, EventArgs e)
        {
                    if (mesas7.BackColor == Color.Transparent)
                    {
                        Llamar(7, 1);
                    }
                    else
                    {
                        Llamar(7, 2);
                    }
            mesa(color, mesas7);
        }

        private void mesas8_Click(object sender, EventArgs e)
        {
                        if (mesas8.BackColor == Color.Transparent)
                        {
                            Llamar(8, 1);
                        }
                        else
                        {
                Llamar(8, 2);
            }
            mesa(color, mesas8);
        }

        private void mesas9_Click(object sender, EventArgs e)
        {
                            if (mesas9.BackColor == Color.Transparent)
                            {
                                Llamar(9, 1);
                            }
                            else
                            {
                                Llamar(9, 2);
                            }
            mesa(color, mesas9);
        }

        private void mesas10_Click(object sender, EventArgs e)
        {
                                if (mesas10.BackColor == Color.Transparent)
                                {
                                    Llamar(10, 1);
                                }
                                else
                                {
                                    Llamar(10, 2);
                                }
            mesa(color, mesas10);
        }

        private void mesas11_Click(object sender, EventArgs e)
        {
            if (mesas11.BackColor == Color.Transparent)
            {
                Llamar(11, 1);
            }
            else
            {
                Llamar(11, 2);
            }
            mesa(color, mesas11);
        }

        private void mesas12_Click(object sender, EventArgs e)
        {
            if (mesas12.BackColor == Color.Transparent)
            {
                Llamar(12, 1);
            }
            else
            {
                Llamar(12, 2);
            }
            mesa(color, mesas12);
        }

        private void mesas13_Click(object sender, EventArgs e)
        {
            if (mesas13.BackColor == Color.Transparent)
            {
                Llamar(13, 1);
            }
            else
            {
                Llamar(13, 2);
            }
            mesa(color, mesas13);
        }

        private void mesas14_Click(object sender, EventArgs e)
        {
            if (mesas14.BackColor == Color.Transparent)
            {
                Llamar(14, 1);
            }
            else
            {
                Llamar(14, 2);
            }
            mesa(color, mesas14);
        }

        private void mesas15_Click(object sender, EventArgs e)
        {
            if (mesas15.BackColor == Color.Transparent)
            {
                Llamar(15, 1);
            }
            else
            {
                Llamar(15, 2);
            }
            mesa(color, mesas15);
        }

        private void mesas16_Click(object sender, EventArgs e)
        {
            if (mesas16.BackColor == Color.Transparent)
            {
                Llamar(16, 1);
            }
            else
            {

                Llamar(16, 2);
            }
            mesa(color, mesas16);
        }

        private void mesas17_Click(object sender, EventArgs e)
        {
            if (mesas17.BackColor == Color.Transparent)
            {
                Llamar(17, 1);
            }
            else
            {
                Llamar(17, 2);
            }
            mesa(color, mesas17);
        }

        private void mesas18_Click(object sender, EventArgs e)
        {
            if (mesas18.BackColor == Color.Transparent)
            {
                Llamar(18, 1);
            }
            else
            {
                Llamar(18, 2);
            }
            mesa(color, mesas18);
        }

        private void mesas19_Click(object sender, EventArgs e)
        {
            if (mesas19.BackColor == Color.Transparent)
            {
                Llamar(19, 1);
            }
            else
            {
                Llamar(19, 2);
            }
            mesa(color, mesas19);
        }

        private void mesas20_Click(object sender, EventArgs e)
        {
            if (mesas20.BackColor == Color.Transparent)
            {
                Llamar(20, 1);
            }
            else
            {
                Llamar(20, 2);
            }
            mesa(color, mesas20);
        }

        private void mesas21_Click(object sender, EventArgs e)
        {
            if (mesas21.BackColor == Color.Transparent)
            {
                Llamar(21, 1);
            }
            else
            {
                Llamar(21, 2);
            }
            mesa(color, mesas21);
        }

        private void mesas22_Click(object sender, EventArgs e)
        {
            if (mesas22.BackColor == Color.Transparent)
            {
                Llamar(22, 1);
            }
            else
            {
                Llamar(22, 2);
            }
            mesa(color, mesas22);
        }

        private void mesas23_Click(object sender, EventArgs e)
        {
            if (mesas23.BackColor == Color.Transparent)
            {
                Llamar(23, 1);
            }
            else
            {
                Llamar(23, 2);
            }
            mesa(color, mesas23);
        }

        private void mesas24_Click(object sender, EventArgs e)
        {
            if (mesas24.BackColor == Color.Transparent)
            {
                Llamar(24, 1);
            }
            else
            {
                Llamar(24, 2);
            }
            mesa(color, mesas24);
        }

        private void mesas25_Click(object sender, EventArgs e)
        {
            if (mesas25.BackColor == Color.Transparent)
            {
                Llamar(25, 1);
            }
            else
            {
                Llamar(25, 2);
            }
            mesa(color, mesas25);
        }

        private void mesas26_Click(object sender, EventArgs e)
        {
            if (mesas26.BackColor == Color.Transparent)
            {
                Llamar(26, 1);
            }
            else
            {
                Llamar(26, 2);
            }

            mesa(color, mesas26);
        }

        private void mesas27_Click(object sender, EventArgs e)
        {
            if (mesas27.BackColor == Color.Transparent)
            {
                Llamar(27, 1);
            }
            else
            {
                Llamar(27, 2);
            }
            mesa(color, mesas27);
        }

        private void mesas28_Click(object sender, EventArgs e)
        {
            if (mesas28.BackColor == Color.Transparent)
            {
                Llamar(28, 1);
            }
            else
            {
                Llamar(28, 2);
            }
            mesa(color, mesas28);
        }

        private void mesas29_Click(object sender, EventArgs e)
        {
            if (mesas29.BackColor == Color.Transparent)
            {
                Llamar(29, 1);
            }
            else
            {
                Llamar(29, 2);
            }
            mesa(color, mesas29);
        }

        private void mesas30_Click(object sender, EventArgs e)
        {
            if (mesas30.BackColor == Color.Transparent)
            {
                Llamar(30, 1);
            }
            else
            {
                Llamar(30, 2);
            }
            mesa(color, mesas30);
        }

        private void lab6_Click(object sender, EventArgs e)
        {

        }

        private void mesas31_Click(object sender, EventArgs e)
        {
            if (mesas31.BackColor == Color.Transparent)
            {
                Llamar(31, 1);
            }
            else
            {
                Llamar(31, 2);
            }
            mesa(color, mesas31);
        }

        private void mesas32_Click(object sender, EventArgs e)
        {
            if (mesas32.BackColor == Color.Transparent)
            {
                Llamar(32, 1);
            }
            else
            {
                Llamar(32, 2);
            }
            mesa(color, mesas32);
        }

        private void mesas33_Click(object sender, EventArgs e)
        {
            if (mesas33.BackColor == Color.Transparent)
            {
                Llamar(33, 1);
            }
            else
            {
                Llamar(33, 2);
            }
            mesa(color, mesas33);
        }

        private void mesas34_Click(object sender, EventArgs e)
        {
            if (mesas34.BackColor == Color.Transparent)
            {
                Llamar(34, 1);
            }
            else
            {
                Llamar(34, 2);
            }
            mesa(color, mesas34);
        }

        private void mesas35_Click(object sender, EventArgs e)
        {
            if (mesas35.BackColor == Color.Transparent)
            {
                Llamar(35, 1);
            }
            else
            {
                Llamar(35, 2);
            }
            mesa(color, mesas35);
        }

        private void mesas36_Click(object sender, EventArgs e)
        {
            if (mesas36.BackColor == Color.Transparent)
            {
                Llamar(36, 1);
            }
            else
            {
                Llamar(36, 2);
            }
            mesa(color, mesas36);
        }

        private void mesas37_Click(object sender, EventArgs e)
        {
            if (mesas37.BackColor == Color.Transparent)
            {
                Llamar(37, 1);
            }
            else
            {
                Llamar(37, 2);
            }
            mesa(color, mesas37);
        }

        private void mesas38_Click(object sender, EventArgs e)
        {
            if (mesas38.BackColor == Color.Transparent)
            {
                Llamar(38, 1);
            }
            else
            {
                Llamar(38, 2);
            }
            mesa(color, mesas38);
        }

        private void mesas39_Click(object sender, EventArgs e)
        {
            if (mesas39.BackColor == Color.Transparent)
            {
                Llamar(39, 1);
            }
            else
            {
                Llamar(39, 2);
            }
            mesa(color, mesas39);
        }

        private void mesas40_Click(object sender, EventArgs e)
        {
            if (mesas40.BackColor == Color.Transparent)
            {
                Llamar(40, 1);
            }
            else
            {
                Llamar(40, 2);
            }
            mesa(color, mesas40);
        }

        private void mesas41_Click(object sender, EventArgs e)
        {
            if (mesas41.BackColor == Color.Transparent)
            {
                Llamar(41, 1);
            }
            else
            {
                Llamar(41, 2);
            }
            mesa(color, mesas41);
        }

        private void mesas42_Click(object sender, EventArgs e)
        {
            if (mesas42.BackColor == Color.Transparent)
            {
                Llamar(42, 1);
            }
            else
            {
                Llamar(42, 2);
            }
            mesa(color, mesas42);
        }

        private void mesas43_Click(object sender, EventArgs e)
        {
            if (mesas43.BackColor == Color.Transparent)
            {
                Llamar(43, 1);
            }
            else
            {
                Llamar(43, 2);
            }
            mesa(color, mesas43);
        }

        private void mesas44_Click(object sender, EventArgs e)
        {
            if (mesas44.BackColor == Color.Transparent)
            {
                Llamar(44, 1);
            }
            else
            {
                Llamar(44, 2);
            }
            mesa(color, mesas44);
        }

        private void mesas45_Click(object sender, EventArgs e)
        {
            if (mesas45.BackColor == Color.Transparent)
            {
                Llamar(45, 1);
            }
            else
            {
                Llamar(45, 2);
            }
            mesa(color, mesas45);
        }

        private void mesas46_Click(object sender, EventArgs e)
        {
            if (mesas46.BackColor == Color.Transparent)
            {
                Llamar(46, 1);
            }
            else
            {
                Llamar(46, 2);
            }
            mesa(color, mesas46);
        }

        private void mesas47_Click(object sender, EventArgs e)
        {
            if (mesas47.BackColor == Color.Transparent)
            {
                Llamar(47, 1);
            }
            else
            {
                Llamar(47, 2);
            }
            mesa(color, mesas47);
        }

        private void mesas48_Click(object sender, EventArgs e)
        {
            if (mesas48.BackColor == Color.Transparent)
            {
                Llamar(48, 1);
            }
            else
            {
                Llamar(48, 2);
            }
            mesa(color, mesas48);
        }

        private void mesas49_Click(object sender, EventArgs e)
        {
            if (mesas49.BackColor == Color.Transparent)
            {
                Llamar(49, 1);
            }
            else
            {
                Llamar(49, 2);
            }
            mesa(color, mesas49);
        }

        private void mesas50_Click(object sender, EventArgs e)
        {
            if (mesas50.BackColor == Color.Transparent)
            {
                Llamar(50, 1);
            }
            else
            {
                Llamar(50, 2);
            }
            mesa(color, mesas50);
        }
        
        private void frmControlMesas_Load(object sender, EventArgs e)
        {
            CargarCMBMesa();
        }
        //public static int estadoMesa;
        private void CargarCMBMesa()
        {
            for (int i = 1; i <=50; i++)
            {
                int estadoMesa=0;

                Clases.Conexión conexion = new Clases.Conexión();
                string sql = "SELECT id,idMesa,estado FROM Restaurante.Pedidos WHERE idmesa= " + i + " AND estado>=1 and estado<=2";
                SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
                try
                {
                    // Establecer la conexión
                    conexion.Abrir();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        estadoMesa = Convert.ToInt16(rdr[2]);
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



                if (i==1)
                {
                    if(estadoMesa==1 || estadoMesa == 2)
                    {
                        mesas1.BackColor = Color.DarkRed;
                    }
                }
                else
                {
                    if (i == 2)
                    {
                        if (estadoMesa == 1 || estadoMesa == 2)
                        {
                            mesas2.BackColor = Color.DarkRed;
                        }
                    }
                    else
                    {
                        if (i == 3)
                        {
                            if (estadoMesa == 1 || estadoMesa == 2)
                            {
                                mesas3.BackColor = Color.DarkRed;
                            }
                        }
                        else
                        {
                            if (i == 4)
                            {
                                if (estadoMesa == 1 || estadoMesa == 2)
                                {
                                    mesas4.BackColor = Color.DarkRed;
                                }
                            }
                            else
                            {
                                if (i == 5)
                                {
                                    if (estadoMesa == 1 || estadoMesa == 2)
                                    {
                                        mesas5.BackColor = Color.DarkRed;
                                    }
                                }
                                else
                                {
                                    if (i == 6)
                                    {
                                        if (estadoMesa == 1 || estadoMesa == 2)
                                        {
                                            mesas6.BackColor = Color.DarkRed;
                                        }
                                    }
                                    else
                                    {
                                        if (i == 7)
                                        {
                                            if (estadoMesa == 1 || estadoMesa == 2)
                                            {
                                                mesas7.BackColor = Color.DarkRed;
                                            }
                                        }
                                        else
                                        {
                                            if (i == 8)
                                            {
                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                {
                                                    mesas8.BackColor = Color.DarkRed;
                                                }
                                            }
                                            else
                                            {
                                                if (i == 9)
                                                {
                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                    {
                                                        mesas9.BackColor = Color.DarkRed;
                                                    }
                                                }
                                                else
                                                {
                                                    if (i == 10)
                                                    {
                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                        {
                                                            mesas10.BackColor = Color.DarkRed;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (i == 11)
                                                        {
                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                            {
                                                                mesas11.BackColor = Color.DarkRed;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (i == 12)
                                                            {
                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                {
                                                                    mesas12.BackColor = Color.DarkRed;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (i == 13)
                                                                {
                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                    {
                                                                        mesas13.BackColor = Color.DarkRed;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (i == 14)
                                                                    {
                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                        {
                                                                            mesas14.BackColor = Color.DarkRed;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (i == 15)
                                                                        {
                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                            {
                                                                                mesas15.BackColor = Color.DarkRed;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (i == 16)
                                                                            {
                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                {
                                                                                    mesas16.BackColor = Color.DarkRed;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                if (i == 17)
                                                                                {
                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                    {
                                                                                        mesas17.BackColor = Color.DarkRed;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (i == 18)
                                                                                    {
                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                        {
                                                                                            mesas18.BackColor = Color.DarkRed;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (i == 19)
                                                                                        {
                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                            {
                                                                                                mesas19.BackColor = Color.DarkRed;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (i == 20)
                                                                                            {
                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                {
                                                                                                    mesas20.BackColor = Color.DarkRed;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (i == 21)
                                                                                                {
                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                    {
                                                                                                        mesas21.BackColor = Color.DarkRed;
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (i == 22)
                                                                                                    {
                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                        {
                                                                                                            mesas22.BackColor = Color.DarkRed;
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (i == 23)
                                                                                                        {
                                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                            {
                                                                                                                mesas23.BackColor = Color.DarkRed;
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (i == 24)
                                                                                                            {
                                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                {
                                                                                                                    mesas24.BackColor = Color.DarkRed;
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (i == 25)
                                                                                                                {
                                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                    {
                                                                                                                        mesas25.BackColor = Color.DarkRed;
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (i == 26)
                                                                                                                    {
                                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                        {
                                                                                                                            mesas26.BackColor = Color.DarkRed;
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (i == 27)
                                                                                                                        {
                                                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                            {
                                                                                                                                mesas27.BackColor = Color.DarkRed;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (i == 28)
                                                                                                                            {
                                                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                {
                                                                                                                                    mesas28.BackColor = Color.DarkRed;
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (i == 29)
                                                                                                                                {
                                                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                    {
                                                                                                                                        mesas29.BackColor = Color.DarkRed;
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (i == 30)
                                                                                                                                    {
                                                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                        {
                                                                                                                                            mesas30.BackColor = Color.DarkRed;
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (i == 31)
                                                                                                                                        {
                                                                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                            {
                                                                                                                                                mesas31.BackColor = Color.DarkRed;
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (i == 32)
                                                                                                                                            {
                                                                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                {
                                                                                                                                                    mesas32.BackColor = Color.DarkRed;
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (i == 33)
                                                                                                                                                {
                                                                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                    {
                                                                                                                                                        mesas33.BackColor = Color.DarkRed;
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if (i == 34)
                                                                                                                                                    {
                                                                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                        {
                                                                                                                                                            mesas34.BackColor = Color.DarkRed;
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if (i == 35)
                                                                                                                                                        {
                                                                                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                            {
                                                                                                                                                                mesas35.BackColor = Color.DarkRed;
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if (i == 36)
                                                                                                                                                            {
                                                                                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                {
                                                                                                                                                                    mesas36.BackColor = Color.DarkRed;
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                if (i == 37)
                                                                                                                                                                {
                                                                                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                    {
                                                                                                                                                                        mesas37.BackColor = Color.DarkRed;
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    if (i == 38)
                                                                                                                                                                    {
                                                                                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                        {
                                                                                                                                                                            mesas38.BackColor = Color.DarkRed;
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        if (i == 39)
                                                                                                                                                                        {
                                                                                                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                            {
                                                                                                                                                                                mesas39.BackColor = Color.DarkRed;
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            if (i == 40)
                                                                                                                                                                            {
                                                                                                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                {
                                                                                                                                                                                    mesas40.BackColor = Color.DarkRed;
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {
                                                                                                                                                                                if (i == 41)
                                                                                                                                                                                {
                                                                                                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                    {
                                                                                                                                                                                        mesas41.BackColor = Color.DarkRed;
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                {
                                                                                                                                                                                    if (i == 42)
                                                                                                                                                                                    {
                                                                                                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                        {
                                                                                                                                                                                            mesas42.BackColor = Color.DarkRed;
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                    {
                                                                                                                                                                                        if (i == 43)
                                                                                                                                                                                        {
                                                                                                                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                            {
                                                                                                                                                                                                mesas43.BackColor = Color.DarkRed;
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            if (i == 44)
                                                                                                                                                                                            {
                                                                                                                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                                {
                                                                                                                                                                                                    mesas44.BackColor = Color.DarkRed;
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                            {
                                                                                                                                                                                                if (i == 45)
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        mesas45.BackColor = Color.DarkRed;
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                                else
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (i == 46)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            mesas46.BackColor = Color.DarkRed;
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (i == 47)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                                            {
                                                                                                                                                                                                                mesas47.BackColor = Color.DarkRed;
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                        else
                                                                                                                                                                                                        {
                                                                                                                                                                                                            if (i == 48)
                                                                                                                                                                                                            {
                                                                                                                                                                                                                if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    mesas48.BackColor = Color.DarkRed;
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                            else
                                                                                                                                                                                                            {
                                                                                                                                                                                                                if (i == 49)
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        mesas49.BackColor = Color.DarkRed;
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                                else
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    if (i == 50)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        if (estadoMesa == 1 || estadoMesa == 2)
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            mesas50.BackColor = Color.DarkRed;
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                    
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
