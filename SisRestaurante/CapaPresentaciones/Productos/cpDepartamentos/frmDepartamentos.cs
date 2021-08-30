using CapaLogica;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentaciones.Productos.cpDepartamentos
{
    public partial class frmDepartamentos : UserControl
    {
        private string accion,cfondo,ctexto;
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            getColorFondo();
            getColorTexto();
            inhabilitar();
            limpiar();
            mostrar(0);
        }

        private void getColorFondo()
        {
            try
            {
                string[] colores = { "Red", "Black", "White", "Purple", "Blue", "Green",
                    "Brown","Yellow","Gray","Violet","Pink" };
                fypFondo.Controls.Clear();
                foreach(string c in colores)
                {
                    Panel p = new Panel();
                    p.Size = new Size(31, 26);
                    p.BorderStyle = BorderStyle.FixedSingle;
                    p.BackColor = Color.FromName(c.ToString());
                    p.Name = c.ToString();
                    p.Click += P_Click;
                    fypFondo.Controls.Add(p);
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void getColorTexto()
        {
            try
            {
                string[] colores = { "Red", "Black", "White", "Purple", "Blue", "Green",
                    "Brown","Yellow","Gray","Violet","Pink" };
                fypTexto.Controls.Clear();
                foreach (string c in colores)
                {
                    Panel pTexto = new Panel();
                    pTexto.Size = new Size(31, 26);
                    pTexto.BorderStyle = BorderStyle.FixedSingle;
                    pTexto.BackColor = Color.FromName(c.ToString());
                    pTexto.Name = c.ToString();
                    pTexto.Click += PTexto_Click;
                    fypTexto.Controls.Add(pTexto);
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void PTexto_Click(object sender, EventArgs e)
        {
            ctexto = ((Panel)sender).Name;
            lbltexto.ForeColor = Color.FromName(ctexto);
        }

        private void P_Click(object sender, EventArgs e)
        {
            cfondo = ((Panel)sender).Name;
            lbltexto.BackColor = Color.FromName(cfondo);
        }

        private void limpiar()
        {
            accion = "guardar";
            lbltexto.BackColor = Color.Black;
            lbltexto.ForeColor = Color.White;
            txtid.Clear();
            txtnombre.Clear();
            cfondo = "Black";
            ctexto = "White";
            chkestados.Checked = false;
        }

        private void inhabilitar()
        {
            gbFondo.Enabled = false;
            gbTexto.Enabled = false;
            txtnombre.Enabled = false;
            txtid.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            chkestado.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }

        private void habilitar()
        {
            gbFondo.Enabled = true;
            gbTexto.Enabled = true;
            txtnombre.Enabled = true;
            txtid.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            chkestado.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void mostrar(int estado)
        {
            try
            {
                DataTable dt = new DataTable();
                Ldepartamentos.mostrar(ref dt, estado);
                dgv.DataSource = dt;
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
                    string nombre = txtnombre.Text.Trim();
                    string fondo = cfondo;
                    string texto = ctexto;
                    int estado = Convert.ToInt32(chkestado.CheckState);
                    if (accion.Equals("guardar"))
                    {
                        if (Ldepartamentos.insertar(nombre, fondo, texto, estado))
                        {
                            Mensajes.Mensajes.mensajeOk("Departamento creado con exito");
                            inhabilitar();
                            limpiar();
                            mostrar(0);
                        }
                    }else if (accion.Equals("editar"))
                    {
                        int id = Convert.ToInt32(txtid.Text.Trim());
                        if (Ldepartamentos.editar(id,nombre, fondo, texto, estado))
                        {
                            Mensajes.Mensajes.mensajeOk("Departamento modificado con exito");
                            inhabilitar();
                            limpiar();
                            mostrar(0);
                        }
                    }
                }
                else
                {
                    error.SetError(txtnombre, "Ingrese el nombre del departamento");
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            limpiar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["ver"].Index)
            {
                habilitar();
                btnEliminar.Enabled = true;
                accion = "editar";
                txtid.Text = dgv.CurrentRow.Cells["id"].Value.ToString().Trim();
                txtnombre.Text = dgv.CurrentRow.Cells["descripcion"].Value.ToString().Trim();
                cfondo = dgv.CurrentRow.Cells["colorfondo"].Value.ToString().Trim();
                ctexto = dgv.CurrentRow.Cells["colortexto"].Value.ToString().Trim();
                lbltexto.ForeColor = Color.FromName(ctexto);
                lbltexto.BackColor = Color.FromName(cfondo);
                chkestado.Checked =Convert.ToBoolean(dgv.CurrentRow.Cells["estado"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Mensajes.Mensajes.mensajePregunta("Seguro que deseas eliminar este registro"))
            {
                int id = Convert.ToInt32(txtid.Text);
                if (Ldepartamentos.eliminar(id)){
                    Mensajes.Mensajes.mensajeOk("Registro eliminado con exito");
                    mostrar(0);
                    inhabilitar();
                    limpiar();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inhabilitar();
            limpiar();
            mostrar(0);
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
