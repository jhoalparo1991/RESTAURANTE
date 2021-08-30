using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentaciones
{
    public partial class frmSalones : Form
    {
        public frmSalones()
        {
            InitializeComponent();
            accion = "guardar";
            idSalon = 0;
            txtnombre.Focus();
        }

        public string accion;
        public int idSalon = 0;
        private void frmSalones_Load(object sender, EventArgs e)
        {
            
        }

        private void guardar()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtnombre.Text))
                {
                    if (accion.Equals("guardar"))
                    {
                        bool resultado = Lsalones.insertar(txtnombre.Text.Trim());
                        if (resultado)
                        {
                            for (int i = 0; i < 80; i++)
                            {
                                bool mesa = Lmesas.insertar();
                                if (mesa == false)
                                {
                                    Mensajes.Mensajes.mensajeError("Error al crear las mesas");
                                }

                            }
                            txtnombre.Clear();
                            txtnombre.Focus();
                            accion = "guardar";
                            idSalon = 0;
                        }
                        else
                        {
                            Mensajes.Mensajes.mensajeError("Error al crear el salon");
                        }
                    }else if (accion.Equals("editar"))
                    {
                        bool resultado = Lsalones.editar(idSalon,txtnombre.Text.Trim());
                        if (resultado)
                        {
                            this.Close();
                        }
                        else
                        {
                            Mensajes.Mensajes.mensajeError("Error al editar el salon");
                        }
                    }
                }
                else
                {
                    Mensajes.Mensajes.mensajeWarning("Ingrese el nombre del salon");
                    txtnombre.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
