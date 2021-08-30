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
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private int idSalon = 0;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmSalones frm = new frmSalones();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblNombreSalon.Text = "";
            mostrarSalones();
        }

        private void mostrarSalones()
        {
            try
            {
                fypSalones.Controls.Clear();
                DataTable dt = new DataTable();
                Lsalones.mostrar(ref dt);
                foreach(DataRow row in dt.Rows)
                {
                    // Panel principal
                    Panel p1 = new Panel();
                    p1.Size = new Size(181, 63);
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    //Boton salon
                    Button b1 = new Button();
                    b1.Dock = DockStyle.Fill;
                    b1.FlatAppearance.BorderSize = 0;
                    b1.FlatAppearance.MouseDownBackColor = Color.Tomato;
                    b1.FlatAppearance.MouseOverBackColor = Color.Green;
                    b1.FlatStyle = FlatStyle.Flat;
                    b1.Font = new Font("SegoeUI", 8);
                    b1.Text = row["nombre"].ToString();
                    b1.Name = row["salon_id"].ToString();
                    b1.ForeColor = Color.Gainsboro;
                    b1.Click += B1_Click;
                    //Panel contenedor boton borrar y editar
                    Panel p2 = new Panel();
                    p2.Size = new Size(45, 63);
                    p2.Dock = DockStyle.Right;
                    p2.BringToFront();
                    //Boton borrar
                    Button b2 = new Button();
                    b2.FlatAppearance.BorderSize = 0;
                    b2.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    b2.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    b2.FlatStyle = FlatStyle.Flat;
                    b2.Font = new Font("SegoeUI", 12);
                    b2.Name = row["salon_id"].ToString();
                    b2.BackgroundImage = Properties.Resources.Rojo;
                    b2.BackgroundImageLayout = ImageLayout.Stretch;
                    b2.Dock = DockStyle.Top;
                    b2.Image = Properties.Resources.trash;
                    b2.Size = new Size(45,28);
                    b2.ForeColor = Color.Gainsboro;
                    b2.Click += B2_Click;
                    //Boton editar
                    Button b3 = new Button();
                    b3.FlatAppearance.BorderSize = 0;
                    b3.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    b3.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    b3.FlatStyle = FlatStyle.Flat;
                    b3.Font = new Font("SegoeUI", 12);
                    b3.Name = row["salon_id"].ToString();
                    b3.Tag = row["nombre"].ToString();
                    b3.BackgroundImage = Properties.Resources.azul;
                    b3.BackgroundImageLayout = ImageLayout.Stretch;
                    b3.Dock = DockStyle.Bottom;
                    b3.Image = Properties.Resources.pencil;
                    b3.Size = new Size(45, 28);
                    b3.ForeColor = Color.Gainsboro;
                    b3.Click += B3_Click;

                    //Agregar elementos
                    p2.Controls.Add(b2);
                    p2.Controls.Add(b3);
                    p1.Controls.Add(b1);
                    p1.Controls.Add(p2);
                    fypSalones.Controls.Add(p1);
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
           
            string nombre = ((Button)sender).Text;
            lblNombreSalon.Text = nombre;
            lblmensaje.Visible = false;
            fypMesas.Visible = true;
            fypMesas.Dock = DockStyle.Fill;
            idSalon = Convert.ToInt32(((Button)sender).Name);
            mostrarMesas(idSalon);

        }

        private void B3_Click(object sender, EventArgs e)
        {
            idSalon = Convert.ToInt32(((Button)sender).Name);
            string nombre = ((Button)sender).Tag.ToString();
            frmSalones frm = new frmSalones();
            frm.accion = "editar";
            frm.idSalon = idSalon;
            frm.txtnombre.Text = nombre;
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mostrarSalones();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            idSalon = Convert.ToInt32(((Button)sender).Name);
            Lsalones.eliminar(idSalon);
            mostrarSalones();
        }

        private void mostrarMesas(int id)
        {
            try
            {
                fypMesas.Controls.Clear();
               
                DataTable dtMesas = new DataTable();
                Lmesas.mostrar_por_id_salon(id, ref dtMesas);
                foreach(DataRow row in dtMesas.Rows)
                {
                    Button bmesas = new Button();
                    bmesas.FlatAppearance.BorderSize = 0;
                    bmesas.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    bmesas.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    bmesas.FlatStyle = FlatStyle.Flat;
                    bmesas.ForeColor = Color.White;
                    int tamanio_mesa = Convert.ToInt32(row["tamanio_mesa"].ToString());
                    int tamanio_fuente = Convert.ToInt32(row["tamanio_fuente"].ToString());
                    bmesas.Font = new Font("SegoeUI", tamanio_fuente);
                    bmesas.Size = new Size(tamanio_mesa,tamanio_mesa);
                    bmesas.Name = row["mesa_id"].ToString();
                    bmesas.Tag = row["tipo"].ToString();
                    if (row["mesa"].ToString() != "NULO")
                    {
                        bmesas.Text = row["mesa"].ToString();
                        if (row["tipo"].ToString() == "CAJA")
                        {
                            bmesas.BackgroundImage = Properties.Resources.naranja;
                        }
                        else
                        {
                            bmesas.BackgroundImage = Properties.Resources.verde;

                        }

                        
                     }
                    else
                    {
                        
                        bmesas.BackgroundImage = Properties.Resources.mesa_vacia;
                    
                    }

                    
                    bmesas.BackgroundImageLayout = ImageLayout.Zoom;
                    bmesas.Click += Bmesas_Click;
                    fypMesas.Controls.Add(bmesas);
                
                }

            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void Bmesas_Click(object sender, EventArgs e)
        {
            int idMesa = Convert.ToInt32(((Button)sender).Name);
            string nombre = ((Button)sender).Text;
            string tipo = ((Button)sender).Tag.ToString();
            string nombreMesa = "";
            frmCrearMesas frmCrear = new frmCrearMesas();
            frmCrear.id_mesa = idMesa;
            if(tipo == "MESA")
            {
                frmCrear.rbMesa.Checked = true;
            }
            else
            {
                frmCrear.rbCaja.Checked = true;
            }

            if(nombre == "")
            {
                nombreMesa = idMesa.ToString();
            }
            else
            {
                nombreMesa = nombre;
            }
            frmCrear.txtmesa.Text = nombreMesa;
            frmCrear.FormClosed += FrmCrear_FormClosed;
            frmCrear.ShowDialog();
        }

        private void FrmCrear_FormClosed(object sender, FormClosedEventArgs e)
        {
            mostrarMesas(idSalon);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lmesas.disminuir_tamanio_fuente();
            mostrarMesas(idSalon);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lmesas.aumentar_tamanio_fuente();
            mostrarMesas(idSalon);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Lmesas.disminuir_tamanio_mesa();
            mostrarMesas(idSalon);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lmesas.aumentar_tamanio_mesa();
            mostrarMesas(idSalon);
        }
    }
}
