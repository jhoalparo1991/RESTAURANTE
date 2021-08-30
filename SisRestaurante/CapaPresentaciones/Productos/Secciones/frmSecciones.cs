using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentaciones.Productos.Secciones
{
    public partial class frmSecciones : UserControl
    {
        public frmSecciones()
        {
            InitializeComponent();
        }

        private string accion;
        private void frmSecciones_Load(object sender, EventArgs e)
        {
            inhabilitar();
            limpiar();
            mostrar(0);
            mostrar_departamentos();
        }

        private void habilitar()
        {
            txtid.Enabled = false;
            txtnombre.Enabled = true;
            cbxdepto.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            chkestado.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void inhabilitar()
        {
            txtid.Enabled = false;
            txtnombre.Enabled = false;
            cbxdepto.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            chkestado.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }

        private void limpiar()
        {
            accion = "guardar";
            txtnombre.Clear();
            txtid.Clear();
            txtnombre.Focus();
            chkestado.Checked = false;
        }

        private void mostrar(int estado)
        {
            try
            {
                DataTable dt = new DataTable();
                Lsecciones.mostrar(ref dt, estado);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void mostrar_departamentos()
        {
            try
            {
                DataTable dt = new DataTable();
                Ldepartamentos.mostrar(ref dt, 0);
                cbxdepto.DataSource = dt;
                cbxdepto.DisplayMember = "descripcion";
                cbxdepto.ValueMember = "id";
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void guardar()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtnombre.Text))
                {
                    error.SetError(txtnombre, "");
                    if (!string.IsNullOrEmpty(cbxdepto.Text))
                    {
                        error.SetError(cbxdepto, "");

                        string nombre = txtnombre.Text.Trim();
                        int depto_id = Convert.ToInt32(cbxdepto.SelectedValue);
                        int estado = Convert.ToInt32(chkestado.CheckState);
                        if (accion.Equals("guardar"))
                        {
                            if (Lsecciones.insertar(depto_id, nombre,estado))
                            {
                                mostrar(0);
                                limpiar();
                                inhabilitar();
                            }
                        }
                        else if (accion.Equals("editar"))
                        {
                            int id = Convert.ToInt32(txtid.Text.Trim());
                            if (Lsecciones.editar(id,depto_id, nombre,estado))
                            {
                                mostrar(0);
                                limpiar();
                                inhabilitar();
                            }
                        }

                    }
                    else
                    {
                        error.SetError(cbxdepto, "Seleccione un departamento");
                        cbxdepto.Focus();
                    }
                }
                else
                {
                    error.SetError(txtnombre, "Ingrese el nombre de la seccion");
                    txtnombre.Focus();
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inhabilitar();
            limpiar();
            mostrar(0);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Mensajes.Mensajes.mensajePregunta("Deseas eliminar este registro"))
            {
                if (Lsecciones.Eliminar(Convert.ToInt32(txtid.Text.Trim())))
                {
                    inhabilitar();
                    limpiar();
                    mostrar(0);
                }
            }
        }

        private void chkestados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkestados.Checked == true)
            {
                mostrar(1);
            }
            else
            {
                mostrar(0);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgv.Columns["ver"].Index)
            {
                habilitar();
                limpiar();
                accion = "editar";
                btnEliminar.Enabled = true;
                txtid.Text = dgv.CurrentRow.Cells["id"].Value.ToString();
                txtnombre.Text = dgv.CurrentRow.Cells["descripcion"].Value.ToString();
                cbxdepto.SelectedValue =Convert.ToInt32(dgv.CurrentRow.Cells["depto_id"].Value);
            }
        }
    }
}
