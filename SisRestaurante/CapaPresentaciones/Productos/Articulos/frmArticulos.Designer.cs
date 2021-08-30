
namespace CapaPresentaciones.Productos.Articulos
{
    partial class frmArticulos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelListado = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.chkestados = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelfoto = new System.Windows.Forms.Panel();
            this.pbimagen = new System.Windows.Forms.PictureBox();
            this.btnbuscarimagen = new System.Windows.Forms.Button();
            this.chkdescatalogado = new System.Windows.Forms.CheckBox();
            this.panelStock = new System.Windows.Forms.Panel();
            this.chkno_aplica = new System.Windows.Forms.CheckBox();
            this.dtfecha_buscar = new System.Windows.Forms.DateTimePicker();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtstock_minimo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstock_inicial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkinventariable = new System.Windows.Forms.CheckBox();
            this.txtp_compra = new System.Windows.Forms.TextBox();
            this.txtp_venta = new System.Windows.Forms.TextBox();
            this.cbxpresentaciones = new System.Windows.Forms.ComboBox();
            this.cbxmarcas = new System.Windows.Forms.ComboBox();
            this.cbxsecciones = new System.Windows.Forms.ComboBox();
            this.cbxdepartamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.panelfoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            this.panelStock.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.Location = new System.Drawing.Point(9, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 30);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 2);
            this.panel2.TabIndex = 1;
            // 
            // panelListado
            // 
            this.panelListado.Controls.Add(this.dgv);
            this.panelListado.Controls.Add(this.panel5);
            this.panelListado.Controls.Add(this.panel3);
            this.panelListado.Location = new System.Drawing.Point(14, 69);
            this.panelListado.Name = "panelListado";
            this.panelListado.Size = new System.Drawing.Size(547, 308);
            this.panelListado.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ver});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 68);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(547, 240);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // ver
            // 
            this.ver.HeaderText = "Ver";
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Text = "Ver";
            this.ver.UseColumnTextForButtonValue = true;
            this.ver.Width = 40;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtbuscar);
            this.panel5.Controls.Add(this.chkestados);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(547, 35);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Location = new System.Drawing.Point(295, 3);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(249, 26);
            this.txtbuscar.TabIndex = 5;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // chkestados
            // 
            this.chkestados.AutoSize = true;
            this.chkestados.Location = new System.Drawing.Point(3, 6);
            this.chkestados.Name = "chkestados";
            this.chkestados.Size = new System.Drawing.Size(200, 24);
            this.chkestados.TabIndex = 4;
            this.chkestados.Text = "Mostrar activos/inactivos";
            this.chkestados.UseVisualStyleBackColor = true;
            this.chkestados.CheckedChanged += new System.EventHandler(this.chkestados_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 33);
            this.panel3.TabIndex = 3;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.button1);
            this.panelRegistro.Controls.Add(this.btn4);
            this.panelRegistro.Controls.Add(this.btn3);
            this.panelRegistro.Controls.Add(this.btn2);
            this.panelRegistro.Controls.Add(this.btn1);
            this.panelRegistro.Controls.Add(this.btnEliminar);
            this.panelRegistro.Controls.Add(this.btnCancelar);
            this.panelRegistro.Controls.Add(this.btnGuardar);
            this.panelRegistro.Controls.Add(this.panelfoto);
            this.panelRegistro.Controls.Add(this.chkdescatalogado);
            this.panelRegistro.Controls.Add(this.panelStock);
            this.panelRegistro.Controls.Add(this.panel6);
            this.panelRegistro.Controls.Add(this.txtp_compra);
            this.panelRegistro.Controls.Add(this.txtp_venta);
            this.panelRegistro.Controls.Add(this.cbxpresentaciones);
            this.panelRegistro.Controls.Add(this.cbxmarcas);
            this.panelRegistro.Controls.Add(this.cbxsecciones);
            this.panelRegistro.Controls.Add(this.cbxdepartamento);
            this.panelRegistro.Controls.Add(this.label9);
            this.panelRegistro.Controls.Add(this.label8);
            this.panelRegistro.Controls.Add(this.label7);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.txtcodigo);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.txtdescripcion);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Location = new System.Drawing.Point(459, 9);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(461, 400);
            this.panelRegistro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CapaPresentaciones.Properties.Resources.refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(591, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generar codigo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = global::CapaPresentaciones.Properties.Resources.refresh;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.Location = new System.Drawing.Point(686, 110);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(24, 23);
            this.btn4.TabIndex = 25;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::CapaPresentaciones.Properties.Resources.refresh;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Location = new System.Drawing.Point(684, 79);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(24, 23);
            this.btn3.TabIndex = 24;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = global::CapaPresentaciones.Properties.Resources.refresh;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.Location = new System.Drawing.Point(338, 110);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(24, 23);
            this.btn2.TabIndex = 23;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::CapaPresentaciones.Properties.Resources.refresh;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Location = new System.Drawing.Point(338, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(24, 23);
            this.btn1.TabIndex = 22;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Location = new System.Drawing.Point(470, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(386, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 30);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(306, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 30);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelfoto
            // 
            this.panelfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelfoto.Controls.Add(this.pbimagen);
            this.panelfoto.Controls.Add(this.btnbuscarimagen);
            this.panelfoto.Location = new System.Drawing.Point(713, 66);
            this.panelfoto.Name = "panelfoto";
            this.panelfoto.Size = new System.Drawing.Size(112, 102);
            this.panelfoto.TabIndex = 9;
            // 
            // pbimagen
            // 
            this.pbimagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbimagen.Image = global::CapaPresentaciones.Properties.Resources.sin_foto;
            this.pbimagen.Location = new System.Drawing.Point(0, 0);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(110, 70);
            this.pbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbimagen.TabIndex = 1;
            this.pbimagen.TabStop = false;
            // 
            // btnbuscarimagen
            // 
            this.btnbuscarimagen.AutoSize = true;
            this.btnbuscarimagen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnbuscarimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarimagen.Location = new System.Drawing.Point(0, 70);
            this.btnbuscarimagen.Name = "btnbuscarimagen";
            this.btnbuscarimagen.Size = new System.Drawing.Size(110, 30);
            this.btnbuscarimagen.TabIndex = 10;
            this.btnbuscarimagen.Text = "Cambiar foto";
            this.btnbuscarimagen.UseVisualStyleBackColor = true;
            this.btnbuscarimagen.Click += new System.EventHandler(this.btnbuscarimagen_Click);
            // 
            // chkdescatalogado
            // 
            this.chkdescatalogado.AutoSize = true;
            this.chkdescatalogado.Location = new System.Drawing.Point(121, 174);
            this.chkdescatalogado.Name = "chkdescatalogado";
            this.chkdescatalogado.Size = new System.Drawing.Size(136, 24);
            this.chkdescatalogado.TabIndex = 11;
            this.chkdescatalogado.Text = "Descatalogado";
            this.chkdescatalogado.UseVisualStyleBackColor = true;
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.chkno_aplica);
            this.panelStock.Controls.Add(this.dtfecha_buscar);
            this.panelStock.Controls.Add(this.txtfecha);
            this.panelStock.Controls.Add(this.label12);
            this.panelStock.Controls.Add(this.txtstock_minimo);
            this.panelStock.Controls.Add(this.label11);
            this.panelStock.Controls.Add(this.txtstock_inicial);
            this.panelStock.Controls.Add(this.label10);
            this.panelStock.Location = new System.Drawing.Point(117, 253);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(600, 66);
            this.panelStock.TabIndex = 14;
            this.panelStock.Visible = false;
            // 
            // chkno_aplica
            // 
            this.chkno_aplica.AutoSize = true;
            this.chkno_aplica.Location = new System.Drawing.Point(271, 35);
            this.chkno_aplica.Name = "chkno_aplica";
            this.chkno_aplica.Size = new System.Drawing.Size(93, 24);
            this.chkno_aplica.TabIndex = 18;
            this.chkno_aplica.Text = "No aplica";
            this.chkno_aplica.UseVisualStyleBackColor = true;
            this.chkno_aplica.CheckedChanged += new System.EventHandler(this.chkno_aplica_CheckedChanged);
            // 
            // dtfecha_buscar
            // 
            this.dtfecha_buscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha_buscar.Location = new System.Drawing.Point(248, 35);
            this.dtfecha_buscar.Name = "dtfecha_buscar";
            this.dtfecha_buscar.Size = new System.Drawing.Size(19, 26);
            this.dtfecha_buscar.TabIndex = 17;
            this.dtfecha_buscar.ValueChanged += new System.EventHandler(this.dtfecha_buscar_ValueChanged);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(107, 35);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(140, 26);
            this.txtfecha.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Vence";
            // 
            // txtstock_minimo
            // 
            this.txtstock_minimo.Location = new System.Drawing.Point(381, 6);
            this.txtstock_minimo.MaxLength = 10;
            this.txtstock_minimo.Name = "txtstock_minimo";
            this.txtstock_minimo.Size = new System.Drawing.Size(160, 26);
            this.txtstock_minimo.TabIndex = 16;
            this.txtstock_minimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_minimo_KeyPress);
            this.txtstock_minimo.Leave += new System.EventHandler(this.txtstock_minimo_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Stock minimo";
            // 
            // txtstock_inicial
            // 
            this.txtstock_inicial.Location = new System.Drawing.Point(107, 6);
            this.txtstock_inicial.MaxLength = 10;
            this.txtstock_inicial.Name = "txtstock_inicial";
            this.txtstock_inicial.Size = new System.Drawing.Size(160, 26);
            this.txtstock_inicial.TabIndex = 15;
            this.txtstock_inicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_inicial_KeyPress);
            this.txtstock_inicial.Leave += new System.EventHandler(this.txtstock_inicial_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Stock inicial";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.chkinventariable);
            this.panel6.Location = new System.Drawing.Point(116, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(417, 40);
            this.panel6.TabIndex = 12;
            // 
            // chkinventariable
            // 
            this.chkinventariable.AutoSize = true;
            this.chkinventariable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkinventariable.Location = new System.Drawing.Point(70, 8);
            this.chkinventariable.Name = "chkinventariable";
            this.chkinventariable.Size = new System.Drawing.Size(252, 24);
            this.chkinventariable.TabIndex = 13;
            this.chkinventariable.Text = "Este articulo maneja inventarios";
            this.chkinventariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkinventariable.UseVisualStyleBackColor = true;
            this.chkinventariable.CheckedChanged += new System.EventHandler(this.chkinventariable_CheckedChanged);
            // 
            // txtp_compra
            // 
            this.txtp_compra.Location = new System.Drawing.Point(482, 142);
            this.txtp_compra.MaxLength = 10;
            this.txtp_compra.Name = "txtp_compra";
            this.txtp_compra.Size = new System.Drawing.Size(201, 26);
            this.txtp_compra.TabIndex = 8;
            this.txtp_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp_compra_KeyPress);
            this.txtp_compra.Leave += new System.EventHandler(this.txtp_compra_Leave);
            // 
            // txtp_venta
            // 
            this.txtp_venta.Location = new System.Drawing.Point(121, 142);
            this.txtp_venta.MaxLength = 10;
            this.txtp_venta.Name = "txtp_venta";
            this.txtp_venta.Size = new System.Drawing.Size(211, 26);
            this.txtp_venta.TabIndex = 7;
            this.txtp_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp_venta_KeyPress);
            this.txtp_venta.Leave += new System.EventHandler(this.txtp_venta_Leave);
            // 
            // cbxpresentaciones
            // 
            this.cbxpresentaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxpresentaciones.FormattingEnabled = true;
            this.cbxpresentaciones.Location = new System.Drawing.Point(482, 109);
            this.cbxpresentaciones.Name = "cbxpresentaciones";
            this.cbxpresentaciones.Size = new System.Drawing.Size(201, 28);
            this.cbxpresentaciones.TabIndex = 6;
            // 
            // cbxmarcas
            // 
            this.cbxmarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxmarcas.FormattingEnabled = true;
            this.cbxmarcas.Location = new System.Drawing.Point(121, 108);
            this.cbxmarcas.Name = "cbxmarcas";
            this.cbxmarcas.Size = new System.Drawing.Size(211, 28);
            this.cbxmarcas.TabIndex = 5;
            // 
            // cbxsecciones
            // 
            this.cbxsecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsecciones.FormattingEnabled = true;
            this.cbxsecciones.Location = new System.Drawing.Point(482, 76);
            this.cbxsecciones.Name = "cbxsecciones";
            this.cbxsecciones.Size = new System.Drawing.Size(201, 28);
            this.cbxsecciones.TabIndex = 4;
            // 
            // cbxdepartamento
            // 
            this.cbxdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxdepartamento.FormattingEnabled = true;
            this.cbxdepartamento.Location = new System.Drawing.Point(121, 75);
            this.cbxdepartamento.Name = "cbxdepartamento";
            this.cbxdepartamento.Size = new System.Drawing.Size(211, 28);
            this.cbxdepartamento.TabIndex = 3;
            this.cbxdepartamento.SelectedIndexChanged += new System.EventHandler(this.cbxdepartamento_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "P. compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "P. venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Presentacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Secciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departamento";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(121, 43);
            this.txtcodigo.MaxLength = 50;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(464, 26);
            this.txtcodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(121, 13);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(579, 26);
            this.txtdescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.panelListado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArticulos";
            this.Size = new System.Drawing.Size(923, 422);
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.panelfoto.ResumeLayout(false);
            this.panelfoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelListado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkestados;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkinventariable;
        private System.Windows.Forms.TextBox txtp_compra;
        private System.Windows.Forms.TextBox txtp_venta;
        private System.Windows.Forms.ComboBox cbxpresentaciones;
        private System.Windows.Forms.ComboBox cbxmarcas;
        private System.Windows.Forms.ComboBox cbxsecciones;
        private System.Windows.Forms.ComboBox cbxdepartamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.CheckBox chkno_aplica;
        private System.Windows.Forms.DateTimePicker dtfecha_buscar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtstock_minimo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtstock_inicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkdescatalogado;
        private System.Windows.Forms.Panel panelfoto;
        private System.Windows.Forms.PictureBox pbimagen;
        private System.Windows.Forms.Button btnbuscarimagen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider error;
    }
}
