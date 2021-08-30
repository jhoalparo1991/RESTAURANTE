using CapaLogica;
using CapaPresentaciones.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentaciones.Productos.Articulos
{
    public partial class frmArticulos : UserControl
    {
        public frmArticulos()
        {
            InitializeComponent();
        }
        private int id = 0;
        private string accion;
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            ocultar_paneles();
            limpiar();
            mostrar_departamentos();
            mostrar_secciones();
            mostrar_marcas();
            mostrar_presentaciones();
            mostrar_articulos(0);
        }

        private void ocultar_paneles()
        {
            panelListado.Visible = true;
            panelListado.Dock = DockStyle.Fill;
            panelRegistro.Visible = false;

            btnNuevo.Visible = true;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void mostrar_paneles()
        {
            panelListado.Visible = false;
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            btnNuevo.Visible = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void limpiar()
        {
            id = 0;
            accion = "guardar";
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtfecha.Text = "No aplica";
            txtp_compra.Text = "0";
            txtp_venta.Text = "0";
            txtstock_inicial.Text = "0";
            txtstock_minimo.Text = "0";
            chkdescatalogado.Checked = false;
            chkinventariable.Checked = false;
            chkno_aplica.Checked = true;
            pbimagen.Image = Properties.Resources.sin_foto;
            txtdescripcion.Focus();
            txtfecha.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mostrar_paneles();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ocultar_paneles();
            limpiar();
        }

        private void chkinventariable_CheckedChanged(object sender, EventArgs e)
        {
            if(chkinventariable.Checked == true)
            {
                panelStock.Visible = true;
                txtstock_inicial.Focus();
            }else if (chkinventariable.Checked == false)
            {
                panelStock.Visible = false;
                txtfecha.Text = "No aplica";
                chkno_aplica.Checked = true;
            }
        }

        private void chkno_aplica_CheckedChanged(object sender, EventArgs e)
        {
            if(chkno_aplica.Checked == true)
            {
                txtfecha.Text = "No aplica";
                dtfecha_buscar.Enabled = false;
            }else if (chkno_aplica.Checked == false)
            {
                txtfecha.Text = dtfecha_buscar.Text;
                dtfecha_buscar.Enabled = true;
            }
        }

        private void dtfecha_buscar_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            DateTime fechaGuardar = dtfecha_buscar.Value;
            if(fechaGuardar < hoy)
            {
                Mensajes.Mensajes.mensajeWarning("No puedes seleccionar una fecha menor a la actual");
            }
            else
            {
                txtfecha.Text = dtfecha_buscar.Text;
            }
        }

        private void btnbuscarimagen_Click(object sender, EventArgs e)
        {
            Imagenes.cargar_imagen(pbimagen);
        }

        private void mostrar_departamentos()
        {
            try
            {
                DataTable dt = new DataTable();
                Ldepartamentos.mostrar(ref dt, 0);
                cbxdepartamento.DataSource = dt;
                cbxdepartamento.DisplayMember = "descripcion";
                cbxdepartamento.ValueMember = "id";
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void mostrar_secciones()
        {
            try
            {
                DataTable dt = new DataTable();
                Lsecciones.mostrar_secciones_por_departamento(ref dt, Convert.ToInt32(cbxdepartamento.SelectedValue) );
                cbxsecciones.DataSource = dt;
                cbxsecciones.DisplayMember = "descripcion";
                cbxsecciones.ValueMember = "id";
            }
            catch (Exception e)
            {
               // Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void mostrar_marcas()
        {
            try
            {
                DataTable dt = new DataTable();
                Lmarcas.mostrar(ref dt, 0);
                cbxmarcas.DataSource = dt;
                cbxmarcas.DisplayMember = "nombre";
                cbxmarcas.ValueMember = "id";
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void ocultar_filas()
        {
            dgv.Columns[1].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[14].Visible = false;
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].Visible = false;
        }
        private void mostrar_articulos(int estado)
        {
            try
            {
                DataTable dt = new DataTable();
                Larticulos.mostrar_articulos(ref dt, estado,txtbuscar.Text);
                dgv.DataSource = dt;
                ocultar_filas();
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void mostrar_presentaciones()
        {
            try
            {
                DataTable dt = new DataTable();
                Lunidades.mostrar(ref dt, 0);
                cbxpresentaciones.DataSource = dt;
                cbxpresentaciones.DisplayMember = "nombre_largo";
                cbxpresentaciones.ValueMember = "id";
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mostrar_departamentos();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mostrar_marcas();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mostrar_presentaciones();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mostrar_secciones();
        }

        private void cbxdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar_secciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = Guid.NewGuid().ToString("N");
        }

        private bool validar_campos()
        {
            if (!string.IsNullOrEmpty(txtdescripcion.Text)){
                error.SetError(txtdescripcion, "");
                if (!string.IsNullOrEmpty(txtcodigo.Text)){
                    error.SetError(txtcodigo, "");
                    if (!string.IsNullOrEmpty(cbxdepartamento.Text)){
                        error.SetError(cbxdepartamento, "");
                        if (!string.IsNullOrEmpty(cbxsecciones.Text))
                        {
                            error.SetError(cbxsecciones, "");
                            if (!string.IsNullOrEmpty(cbxpresentaciones.Text))
                            {
                                error.SetError(cbxpresentaciones, "");
                                if (!string.IsNullOrEmpty(cbxpresentaciones.Text))
                                {
                                    error.SetError(cbxpresentaciones, "");
                                    if (!string.IsNullOrEmpty(cbxmarcas.Text))
                                    {
                                        error.SetError(cbxmarcas, "");
                                        return true;
                                    }
                                    else
                                    {
                                        error.SetError(cbxmarcas, "Seleccione una marca");
                                        cbxmarcas.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    error.SetError(cbxpresentaciones, "Seleccione una presentacion");
                                    cbxpresentaciones.Focus();
                                    return false;
                                }
                            }
                            else
                            {
                                error.SetError(cbxpresentaciones, "Seleccione una presentacion");
                                cbxpresentaciones.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            error.SetError(cbxsecciones, "Seleccione una seccion");
                            cbxsecciones.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        error.SetError(cbxdepartamento, "Seleccione un departamento");
                        cbxdepartamento.Focus();
                        return false;
                    }
                }
                else
                {
                    error.SetError(txtcodigo, "Ingrese el codigo del articulo");
                    txtcodigo.Focus();
                    return false;
                }
            }
            else
            {
                error.SetError(txtdescripcion, "Ingrese el nombre del articulo");
                txtdescripcion.Focus();
                return false;
            }
        }

        private void txtp_venta_Leave(object sender, EventArgs e)
        {
            Validaciones.colocar_cero(sender, e, txtp_venta);
        }

        private void txtp_compra_Leave(object sender, EventArgs e)
        {
            Validaciones.colocar_cero(sender, e, txtp_compra);
        }

        private void txtstock_inicial_Leave(object sender, EventArgs e)
        {
            Validaciones.colocar_cero(sender, e, txtstock_inicial);
        }

        private void txtstock_minimo_Leave(object sender, EventArgs e)
        {
            Validaciones.colocar_cero(sender, e, txtstock_minimo);
        }

        private void txtp_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.solo_numeros(sender, e);
        }

        private void txtp_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.solo_numeros(sender, e);
        }

        private void txtstock_inicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.solo_numeros(sender, e);
        }

        private void txtstock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.solo_numeros(sender, e);
        }

        private void guardar()
        {
            try
            {
                string descripcion = txtdescripcion.Text.Trim();
                string codigo = txtcodigo.Text.Trim();
                int depto = Convert.ToInt32(cbxdepartamento.SelectedValue);
                int seccion = Convert.ToInt32(cbxsecciones.SelectedValue);
                int marca = Convert.ToInt32(cbxmarcas.SelectedValue);
                int presentacion = Convert.ToInt32(cbxpresentaciones.SelectedValue);
                decimal pventa = Convert.ToDecimal(txtp_venta.Text.Trim());
                decimal pcompra = Convert.ToDecimal(txtp_compra.Text.Trim());
                int inventariable = Convert.ToInt32(chkinventariable.CheckState);
                decimal stock_inicial = Convert.ToDecimal(txtstock_inicial.Text.Trim());
                decimal hay = Convert.ToDecimal(txtstock_inicial.Text.Trim());
                decimal stock_minimo = Convert.ToDecimal(txtstock_minimo.Text.Trim());
                string vence = txtfecha.Text.Trim();
                byte[] imagen = Imagenes.guardar_imagen(pbimagen).GetBuffer();
                int estado = Convert.ToInt32(chkdescatalogado.CheckState);

                if (accion.Equals("guardar"))
                {
                    if(Larticulos.insertar(depto,seccion,marca,codigo,descripcion,presentacion,
                        pventa,pcompra,inventariable,stock_inicial,hay,stock_minimo,
                        vence, imagen, estado))
                    {
                        limpiar();
                        ocultar_paneles();
                        mostrar_articulos(0);
                    }
                }
                else if (accion.Equals("editar"))
                {
                    if (Larticulos.editar(id,depto, seccion, marca, codigo, descripcion, presentacion,
                        pventa, pcompra, inventariable, stock_inicial, stock_minimo,
                        vence, imagen, estado))
                    {
                        limpiar();
                        ocultar_paneles();
                        mostrar_articulos(0);
                    }
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                guardar();
            }
        }

        private void chkestados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkestados.Checked)
            {
                mostrar_articulos(1);
            }
            else
            {
                mostrar_articulos(0);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgv.Columns["ver"].Index)
            {
                mostrar_paneles();
                limpiar();
                btnEliminar.Enabled = true;
                accion = "editar";
                id = Convert.ToInt32(dgv.CurrentRow.Cells["id"].Value.ToString());
                txtcodigo.Text = dgv.CurrentRow.Cells["codigo"].Value.ToString();
                txtdescripcion.Text = dgv.CurrentRow.Cells["articulos"].Value.ToString();
                cbxdepartamento.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells["depto_id"].Value.ToString());
                cbxsecciones.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells["seccion_id"].Value.ToString());
                cbxmarcas.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells["marca_id"].Value.ToString());
                cbxpresentaciones.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells["presentacion_id"].Value.ToString());
                txtp_venta.Text = dgv.CurrentRow.Cells["pventa"].Value.ToString();
                txtp_compra.Text = dgv.CurrentRow.Cells["pcompra"].Value.ToString();
                txtstock_inicial.Text = dgv.CurrentRow.Cells["stock_inicial"].Value.ToString();
                txtstock_minimo.Text = dgv.CurrentRow.Cells["stock_minimo"].Value.ToString();
                txtfecha.Text = dgv.CurrentRow.Cells["vence"].Value.ToString();
                Imagenes.obtener_imagen(pbimagen, dgv, "imagen");
                chkdescatalogado.Checked = Convert.ToBoolean(dgv.CurrentRow.Cells["estado"].Value);
                chkinventariable.Checked = Convert.ToBoolean(dgv.CurrentRow.Cells["inventariable"].Value);
                if(txtfecha.Text != "No aplica")
                {
                    chkno_aplica.Checked = false;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Mensajes.Mensajes.mensajePregunta("Seguro que deseas eliminar este registro"))
            {
                if (Larticulos.eliminar(id))
                {
                    Mensajes.Mensajes.mensajeOk("Registro eliminado con exito");
                    mostrar_articulos(0);
                    ocultar_paneles();
                    limpiar();
                }
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (chkestados.Checked)
            {
                mostrar_articulos(1);
            }
            else
            {
                mostrar_articulos(0);
            }
        }
    }
}
