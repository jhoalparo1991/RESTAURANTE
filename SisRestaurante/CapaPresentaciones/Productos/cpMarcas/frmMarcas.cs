using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentaciones.Productos.cpMarcas
{
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private string accion;
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            limpiar();
            inhabilitar();
            mostrar(0);
        }

        private void limpiar()
        {
            accion = "guardar";
            txtid.Clear();
            txtnombre.Clear();
            chkestado.Checked = false;
            txtnombre.Focus();
        }

        private void inhabilitar()
        {
            txtid.Enabled = false;
            txtnombre.Enabled = false;
            chkestado.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            tabControl1.SelectedIndex = 0;
        }

        private void habilitar()
        {
            txtid.Enabled = false;
            txtnombre.Enabled = true;
            chkestado.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            tabControl1.SelectedIndex = 1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            inhabilitar();
        }

        private void mostrar(int estado)
        {
            DataTable dt = new DataTable();
            Lmarcas.mostrar(ref dt, estado);
            dgv.DataSource = dt;
            dgv.Columns[1].Visible = false;
            dgv.Columns[3].Visible = false;

        }

        private void chkestados_CheckedChanged(object sender, EventArgs e)
        {
            if(chkestados.Checked == true)
            {
                mostrar(1);
            }
            else
            {
                mostrar(0);
            }
        }

        private void guardar()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtnombre.Text))
                {
                    error.SetError(txtnombre, "");
                    string nombre = txtnombre.Text.Trim();
                    int estado = Convert.ToInt32(chkestado.CheckState);
                    if (accion.Equals("guardar"))
                    {
                        if (Lmarcas.insertar(nombre, estado))
                        {
                            Mensajes.Mensajes.mensajeOk("Marca creada con exito");
                            habilitar();
                            mostrar(0);
                            limpiar();
                        }
                    }else if (accion.Equals("editar"))
                    {
                        int id = Convert.ToInt32(txtid.Text.Trim());
                        if (Lmarcas.editar(id,nombre, estado))
                        {
                            Mensajes.Mensajes.mensajeOk("Marca modificada con exito");
                            habilitar();
                            mostrar(0);
                            limpiar();
                        }
                    }
                }
                else
                {
                    error.SetError(txtnombre,"Ingrese el nombre de la marca");
                    txtnombre.Focus();
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgv.Columns["ver"].Index)
            {
                habilitar();
                limpiar();
                accion = "editar";
                btnEliminar.Enabled = true;
                txtid.Text = dgv.CurrentRow.Cells["id"].Value.ToString().Trim();
                txtnombre.Text = dgv.CurrentRow.Cells["nombre"].Value.ToString().Trim();
                chkestado.Checked = Convert.ToBoolean(dgv.CurrentRow.Cells["estado"].Value);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = Mensajes.Mensajes.mensajePregunta("Seguro que deseas eliminar este registro");
                if (result)
                {
                    int id = Convert.ToInt32(txtid.Text.Trim());
                    if (Lmarcas.eliminar(id))
                    {
                        inhabilitar();
                        mostrar(0);
                        limpiar();
                        chkestado.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Mensajes.Mensajes.mensajeError(ex.Message);
            }
        }
    }
}
