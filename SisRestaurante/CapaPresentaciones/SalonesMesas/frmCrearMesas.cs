using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentaciones.SalonesMesas
{
    public partial class frmCrearMesas : Form
    {
        public frmCrearMesas()
        {
            InitializeComponent();
        }
        public int id_mesa = 0;
        public string tipomesa ="MESA";
        private void frmCrearMesas_Load(object sender, EventArgs e)
        {
            txtmesa.Focus();
        }

        private void guardar()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtmesa.Text))
                {

                    if(rbCaja.Checked == true)
                    {
                        tipomesa = "CAJA";
                    }else if(rbMesa.Checked == true)
                    {
                        tipomesa = "MESA";
                    }

                    bool resultado = Lmesas.editar(id_mesa, txtmesa.Text.Trim(),tipomesa);
                    if (resultado)
                    {
                        this.Close();
                    }
                    else
                    {
                        Mensajes.Mensajes.mensajeError("No se pudo guardar la mesa");
                    }
                }
                else
                {
                    Mensajes.Mensajes.mensajeWarning("Ingrese el nombre o numero de la mesa");
                    txtmesa.Focus();
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
