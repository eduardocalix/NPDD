using System;

using System.Windows.Forms;

namespace Restaurante.Clases
{
    class Mensaje
    {
        public static void Informacion(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void Advertencia(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
