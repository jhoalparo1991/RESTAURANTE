using CapaPresentaciones.Productos.Articulos;
using CapaPresentaciones.Productos.cpDepartamentos;
using CapaPresentaciones.Productos.cpMarcas;
using CapaPresentaciones.Productos.Secciones;
using CapaPresentaciones.Productos.Unidades;
using CapaPresentaciones.PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentaciones.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmVisorMesas frm = new frmVisorMesas();
            frm.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void lblvolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            frmVisorMesas frm = new frmVisorMesas();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha_hora.Text = "Fecha y Hora : " + DateTime.Now.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalPages = tabControl1.TabCount;
            if(totalPages > 1)
            {
                tabControl1.Controls.Remove(tabControl1);
            }
        }

        private void agregarPagina(string titulo,UserControl user)
        {
            TabPage page = new TabPage();
            page.Text = titulo;
            page.Controls.Add(user);
            tabControl1.Controls.Add(page);
            tabControl1.SelectedTab = page;
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidades frm = new frmUnidades();
            frm.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas frm = new frmMarcas();
            frm.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamentos frm = new frmDepartamentos();
            frm.Dock = DockStyle.Fill;
            agregarPagina("Departamentos", frm);
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos frm = new frmArticulos();
            frm.Dock = DockStyle.Fill;
            agregarPagina("Articulos", frm);
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecciones frm = new frmSecciones();
            frm.Top = 0;
            frm.Left = 0;
            agregarPagina("Secciones", frm);
        }
    }
}
