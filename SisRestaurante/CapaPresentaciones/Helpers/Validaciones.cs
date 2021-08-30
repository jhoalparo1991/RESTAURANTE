using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentaciones.Helpers
{
    public class Validaciones
    {

        public static void colocar_cero(object sender, EventArgs e,TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = "0";
            }
        }

        public static void solo_numeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & e.KeyChar != (char)Keys.Back;
        }
    }
}
