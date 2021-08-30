using CapaLogica;
using CapaPresentaciones.Menu;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentaciones.PuntoDeVenta
{
    public partial class frmVisorMesas : Form
    {
        private int IdSalon;
        private string estadoBarra;
        public frmVisorMesas()
        {
            InitializeComponent();
            IdSalon = Lsalones.obtenerPrimerSalon();
            estadoBarra = "cerrada";
            cambiarEstadoBarra();
        }


        private void frmVisorMesas_Load(object sender, EventArgs e)
        {
            mostrarSalones();
            mostrarMesas();
        }

        private void mostrarSalones()
        {
            try
            {
                DataTable dt = new DataTable();
                Lsalones.mostrar(ref dt);
                fypSalones.Controls.Clear();
                foreach(DataRow row in dt.Rows)
                {
                    Button btnSalones = new Button();
                    btnSalones.Size = new Size(201,36);
                    btnSalones.FlatAppearance.BorderSize = 0;
                    btnSalones.FlatAppearance.MouseDownBackColor = Color.Tomato;
                    btnSalones.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnSalones.FlatStyle = FlatStyle.Flat;
                    btnSalones.Font = new Font("Microsoft Sans Serif", 12);
                    btnSalones.ForeColor = Color.Gainsboro;
                    btnSalones.Text = row["nombre"].ToString();
                    btnSalones.Name = row["salon_id"].ToString();
                    btnSalones.Cursor = Cursors.Hand;
                    btnSalones.Click += BtnSalones_Click;
                    fypSalones.Controls.Add(btnSalones);
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void mostrarMesas()
        {
            try
            {
                DataTable dt = new DataTable();
                Lmesas.mostrar_por_id_salon(IdSalon, ref dt);
                fypMesas.Controls.Clear();
                foreach(DataRow row in dt.Rows)
                {
                    Button btnMesas = new Button();
                    Panel pvacio = new Panel();
                    int tamanioMesa = Convert.ToInt32(row["tamanio_mesa"].ToString());
                    int tamanioFuente = Convert.ToInt32(row["tamanio_fuente"].ToString());
                    pvacio.Size = new Size(tamanioMesa,tamanioMesa);
                    pvacio.BorderStyle = BorderStyle.None;

                    btnMesas.Size = new Size(tamanioMesa, tamanioMesa);
                    btnMesas.FlatAppearance.BorderSize = 0;
                    btnMesas.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btnMesas.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btnMesas.FlatStyle = FlatStyle.Flat;
                    btnMesas.ForeColor = Color.Gainsboro;
                    btnMesas.Name = row["mesa_id"].ToString();
                    btnMesas.BackgroundImageLayout = ImageLayout.Stretch;
                    btnMesas.Cursor = Cursors.Hand;
                    if (row["tipo"].ToString() == "MESA")
                    {
                        btnMesas.Text = row["mesa"].ToString();

                        btnMesas.Font = new Font("Microsoft Sans Serif", tamanioFuente);

                        if (row["estado"].ToString() == "LIBRE")
                        {
                            btnMesas.BackgroundImage = Properties.Resources.verde;

                        }else if (row["estado"].ToString() == "OCUPADO")
                        {
                            btnMesas.BackgroundImage = Properties.Resources.Rojo;
                        }
                        else if (row["estado"].ToString() == "ABIERTA")
                        {
                            btnMesas.BackgroundImage = Properties.Resources.amarillo;
                        }
                    }
                    else if (row["tipo"].ToString() == "CAJA")
                    {
                        btnMesas.BackgroundImage = Properties.Resources.caja_registradora;

                    }

                    if (row["mesa"].ToString() == "NULO")
                    {
                        fypMesas.Controls.Add(pvacio);
                    }
                    else
                    {
                        fypMesas.Controls.Add(btnMesas);
                    }
                }
            }
            catch (Exception e)
            {
                Mensajes.Mensajes.mensajeError(e.Message);
            }
        }

        private void BtnSalones_Click(object sender, EventArgs e)
        {
            IdSalon = Convert.ToInt32(((Button)sender).Name);
            mostrarMesas();
            foreach(Button b in fypSalones.Controls)
            {
                if(b is Button)
                {
                    b.BackColor = Color.Transparent;
                }
            }

            string name = ((Button)sender).Text;
            foreach(Button b in fypSalones.Controls)
            {
                if(b is Button)
                {
                    if(b.Text == name)
                    {
                        b.BackColor = Color.Green;
                    }
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mostrarSalones();
            mostrarMesas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarEstadoBarra()
        {
            if(estadoBarra == "cerrada")
            {
                panelHerramientas.Visible = false;
                estadoBarra = "abierta";
            }else if (estadoBarra == "abierta")
            {
                panelHerramientas.Visible = true;
                estadoBarra = "cerrada";
            }
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            cambiarEstadoBarra();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfechaHora.Text = DateTime.Now.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }
    }
}
