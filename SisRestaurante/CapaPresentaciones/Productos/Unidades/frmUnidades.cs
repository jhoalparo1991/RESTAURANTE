using CapaLogica;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentaciones.Productos.Unidades
{
    public partial class frmUnidades : Form
    {
        public frmUnidades()
        {
            InitializeComponent();
        }
        private string accion;
        private int id;
        private void frmUnidades_Load(object sender, EventArgs e)
        {
            
            inhabilitar();
            limpiar();

        }

        private void inhabilitar()
        {
            btnborrar.Enabled = false;
            btnguardar.Enabled = false;
            btnnuevo.Enabled = true;
            btncancelar.Enabled = false;

            panelRegistro.Visible = false;
        }

        private void habilitar()
        {
            btnborrar.Enabled = false;
            btnguardar.Enabled = true;
            btnnuevo.Enabled = false;
            btncancelar.Enabled = true;

            panelRegistro.Visible = true;
        }

        private void limpiar()
        {
            accion = "guardar";
            id = 0;
            txtNombreCorto.Clear();
            txtNombreLargo.Clear();
            txtNombreLargo.Focus();
            chkEstado.Checked = false;
            mostrar(0);
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrEmpty(txtNombreLargo.Text))
            {
                if (!string.IsNullOrEmpty(txtNombreCorto.Text))
                {
                    return true;
                }
                else
                {
                    Mensajes.Mensajes.mensajeWarning("Ingrese el nombre corto");
                    txtNombreCorto.Focus();
                    return false;
                }
            }
            else
            {
                Mensajes.Mensajes.mensajeWarning("Ingrese el nombre largo");
                txtNombreLargo.Focus();
                return false;
            }
        }


        private void guardar()
        {
            try
            {
                if (validarCampos())
                {
                    if (accion.Equals("guardar"))
                    {
                        bool insert = Lunidades.insertar(txtNombreLargo.Text.Trim(),
                            txtNombreCorto.Text.Trim(),
                            Convert.ToInt32(chkEstado.CheckState));
                        if (insert)
                        {
                            limpiar();
                            habilitar();
                        }
                        else
                        {
                            Mensajes.Mensajes.mensajeError("No se pudo guardar");
                        }
                    }
                    else if (accion.Equals("editar"))
                    {
                        bool editar = Lunidades.editar(id,txtNombreLargo.Text.Trim(),
                            txtNombreCorto.Text.Trim(),Convert.ToInt32(chkEstado.CheckState));
                        if (editar)
                        {
                            limpiar();
                            habilitar();
                        }
                        else
                        {
                            Mensajes.Mensajes.mensajeError("No se pudo modificar");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void mostrar(int estado)
        {
            try
            {
                DataTable dt = new DataTable();
                Lunidades.mostrar(ref dt,estado);
                dgv.DataSource = dt;
                dgv.Columns[1].Visible = false;
                dgv.Columns[4].Visible = false;
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            inhabilitar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgv.Columns["seleccionar"].Index)
            {
                habilitar();
                btnborrar.Enabled = true;
                id = Convert.ToInt32(dgv.CurrentRow.Cells["id"].Value);
                txtNombreLargo.Text = dgv.CurrentRow.Cells["nombre_largo"].Value.ToString();
                txtNombreCorto.Text = dgv.CurrentRow.Cells["nombre_corto"].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(dgv.CurrentRow.Cells["estado"].Value);
                accion = "editar";
                
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            bool result = Mensajes.Mensajes.mensajePregunta("Estas seguro de eliminar este registro");
            if (result)
            {
                Lunidades.eliminar(id);
                limpiar();
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
    }
}
