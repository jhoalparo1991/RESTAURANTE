using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentaciones.Mensajes
{
    public class Mensajes
    {

        public static void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mensajeWarning(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool mensajePregunta(string mensaje)
        {
            DialogResult result = MessageBox.Show(mensaje, "Sistema de resturante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) return true;
            else return false;
        }
    }
}
