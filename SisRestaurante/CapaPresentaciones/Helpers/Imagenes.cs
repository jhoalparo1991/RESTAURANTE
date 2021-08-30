using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentaciones.Helpers
{
    public class Imagenes
    {

        public static void cargar_imagen(PictureBox pbimagen)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Imagenes |*.png;*.jpg;*.jpeg;*.images";
                    ofd.FilterIndex = 4;
                    ofd.InitialDirectory = "";
                    ofd.Title = "Cargar imagen";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pbimagen.Image = null;
                        pbimagen.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensajes.Mensajes.mensajeError(ex.Message);
            }
        }

        public static MemoryStream guardar_imagen(PictureBox pbimagen)
        {
            MemoryStream ms = new MemoryStream();
            pbimagen.Image.Save(ms, pbimagen.Image.RawFormat);
            return ms;
        }

        public static void obtener_imagen(PictureBox pbimagen,DataGridView dgv,string campo)
        {
            byte[] b = (byte[])dgv.CurrentRow.Cells[campo].Value;
            MemoryStream ms = new MemoryStream(b);
            pbimagen.Image = Image.FromStream(ms);
        }
    }
}
