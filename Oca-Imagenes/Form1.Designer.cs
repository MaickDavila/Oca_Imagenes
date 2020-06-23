namespace Oca_Imagenes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_r_entrada = new System.Windows.Forms.TextBox();
            this.txt_r_salida = new System.Windows.Forms.TextBox();
            this.btn_r_entrada = new System.Windows.Forms.Button();
            this.btn_r_salida = new System.Windows.Forms.Button();
            this.tabla_imagenes = new System.Windows.Forms.DataGridView();
            this.cimagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.csize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_aplicar_cambios = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btntamaniocarnet = new System.Windows.Forms.Button();
            this.check_tamanios = new System.Windows.Forms.CheckBox();
            this.check90 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.track_bar_calidad = new System.Windows.Forms.TrackBar();
            this.panel_tamanios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ancho = new System.Windows.Forms.TextBox();
            this.check_dimesion = new System.Windows.Forms.CheckBox();
            this.txt_alto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_calidad = new System.Windows.Forms.Label();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.list_keys = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardarkey = new System.Windows.Forms.Button();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.hilo = new System.ComponentModel.BackgroundWorker();
            this.lbl_progreso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_imagenes)).BeginInit();
            this.panel_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_bar_calidad)).BeginInit();
            this.panel_tamanios.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_r_entrada
            // 
            this.txt_r_entrada.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_r_entrada.Location = new System.Drawing.Point(11, 149);
            this.txt_r_entrada.Name = "txt_r_entrada";
            this.txt_r_entrada.Size = new System.Drawing.Size(211, 27);
            this.txt_r_entrada.TabIndex = 0;
            // 
            // txt_r_salida
            // 
            this.txt_r_salida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_r_salida.Location = new System.Drawing.Point(11, 224);
            this.txt_r_salida.Name = "txt_r_salida";
            this.txt_r_salida.Size = new System.Drawing.Size(211, 27);
            this.txt_r_salida.TabIndex = 1;
            // 
            // btn_r_entrada
            // 
            this.btn_r_entrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_r_entrada.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_r_entrada.Location = new System.Drawing.Point(11, 112);
            this.btn_r_entrada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_r_entrada.Name = "btn_r_entrada";
            this.btn_r_entrada.Size = new System.Drawing.Size(210, 31);
            this.btn_r_entrada.TabIndex = 4;
            this.btn_r_entrada.Text = "Ruta de entrada:";
            this.btn_r_entrada.UseVisualStyleBackColor = true;
            this.btn_r_entrada.Click += new System.EventHandler(this.btn_r_entrada_Click);
            // 
            // btn_r_salida
            // 
            this.btn_r_salida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_r_salida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_r_salida.Location = new System.Drawing.Point(11, 187);
            this.btn_r_salida.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_r_salida.Name = "btn_r_salida";
            this.btn_r_salida.Size = new System.Drawing.Size(210, 31);
            this.btn_r_salida.TabIndex = 5;
            this.btn_r_salida.Text = "Ruta de salida:";
            this.btn_r_salida.UseVisualStyleBackColor = true;
            this.btn_r_salida.Click += new System.EventHandler(this.btn_r_salida_Click);
            // 
            // tabla_imagenes
            // 
            this.tabla_imagenes.AllowUserToAddRows = false;
            this.tabla_imagenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla_imagenes.BackgroundColor = System.Drawing.Color.White;
            this.tabla_imagenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_imagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_imagenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cimagen,
            this.csize,
            this.cpeso,
            this.cnombre});
            this.tabla_imagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_imagenes.Location = new System.Drawing.Point(3, 3);
            this.tabla_imagenes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabla_imagenes.Name = "tabla_imagenes";
            this.tabla_imagenes.RowHeadersVisible = false;
            this.tabla_imagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_imagenes.Size = new System.Drawing.Size(916, 689);
            this.tabla_imagenes.TabIndex = 9;
            this.tabla_imagenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_imagenes_CellClick);
            this.tabla_imagenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_imagenes_CellDoubleClick);
            // 
            // cimagen
            // 
            this.cimagen.HeaderText = "Imagen";
            this.cimagen.Name = "cimagen";
            this.cimagen.ReadOnly = true;
            this.cimagen.Width = 232;
            // 
            // csize
            // 
            this.csize.HeaderText = "Dim.";
            this.csize.Name = "csize";
            this.csize.ReadOnly = true;
            this.csize.Width = 232;
            // 
            // cpeso
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cpeso.DefaultCellStyle = dataGridViewCellStyle1;
            this.cpeso.HeaderText = "Peso";
            this.cpeso.Name = "cpeso";
            this.cpeso.ReadOnly = true;
            this.cpeso.Width = 232;
            // 
            // cnombre
            // 
            this.cnombre.HeaderText = "Nombre";
            this.cnombre.Name = "cnombre";
            this.cnombre.ReadOnly = true;
            this.cnombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cnombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cnombre.Width = 233;
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.White;
            this.panel_lateral.Controls.Add(this.pictureBox1);
            this.panel_lateral.Controls.Add(this.panel2);
            this.panel_lateral.Controls.Add(this.panel1);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(257, 801);
            this.panel_lateral.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_r_entrada);
            this.panel2.Controls.Add(this.btn_r_salida);
            this.panel2.Controls.Add(this.txt_r_entrada);
            this.panel2.Controls.Add(this.txt_r_salida);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 269);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Panel de Configuración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rutas:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 363);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_aplicar_cambios);
            this.panel4.Controls.Add(this.btn_limpiar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 73);
            this.panel4.TabIndex = 10;
            // 
            // btn_aplicar_cambios
            // 
            this.btn_aplicar_cambios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aplicar_cambios.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_aplicar_cambios.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_aplicar_cambios.FlatAppearance.BorderSize = 2;
            this.btn_aplicar_cambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aplicar_cambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aplicar_cambios.ForeColor = System.Drawing.Color.White;
            this.btn_aplicar_cambios.Location = new System.Drawing.Point(2, 3);
            this.btn_aplicar_cambios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_aplicar_cambios.Name = "btn_aplicar_cambios";
            this.btn_aplicar_cambios.Size = new System.Drawing.Size(253, 30);
            this.btn_aplicar_cambios.TabIndex = 10;
            this.btn_aplicar_cambios.Text = "Aplicar Cambios";
            this.btn_aplicar_cambios.UseVisualStyleBackColor = false;
            this.btn_aplicar_cambios.Click += new System.EventHandler(this.btn_aplicar_cambios_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_limpiar.FlatAppearance.BorderSize = 2;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_limpiar.Location = new System.Drawing.Point(2, 39);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(253, 30);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar Todo";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btntamaniocarnet);
            this.panel3.Controls.Add(this.check_tamanios);
            this.panel3.Controls.Add(this.check90);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.track_bar_calidad);
            this.panel3.Controls.Add(this.panel_tamanios);
            this.panel3.Controls.Add(this.lbl_calidad);
            this.panel3.Location = new System.Drawing.Point(12, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 247);
            this.panel3.TabIndex = 16;
            // 
            // btntamaniocarnet
            // 
            this.btntamaniocarnet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btntamaniocarnet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btntamaniocarnet.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btntamaniocarnet.FlatAppearance.BorderSize = 2;
            this.btntamaniocarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntamaniocarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntamaniocarnet.ForeColor = System.Drawing.Color.White;
            this.btntamaniocarnet.Location = new System.Drawing.Point(156, 18);
            this.btntamaniocarnet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btntamaniocarnet.Name = "btntamaniocarnet";
            this.btntamaniocarnet.Size = new System.Drawing.Size(60, 32);
            this.btntamaniocarnet.TabIndex = 14;
            this.btntamaniocarnet.Text = "Carnét";
            this.btntamaniocarnet.UseVisualStyleBackColor = false;
            this.btntamaniocarnet.Click += new System.EventHandler(this.btntamaniocarnet_Click);
            // 
            // check_tamanios
            // 
            this.check_tamanios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.check_tamanios.Font = new System.Drawing.Font("Tahoma", 12F);
            this.check_tamanios.Location = new System.Drawing.Point(16, 21);
            this.check_tamanios.Name = "check_tamanios";
            this.check_tamanios.Size = new System.Drawing.Size(200, 29);
            this.check_tamanios.TabIndex = 14;
            this.check_tamanios.Text = "Tamaños:";
            this.check_tamanios.UseVisualStyleBackColor = false;
            this.check_tamanios.CheckedChanged += new System.EventHandler(this.check_tamanios_CheckedChanged);
            // 
            // check90
            // 
            this.check90.AutoSize = true;
            this.check90.Location = new System.Drawing.Point(12, 227);
            this.check90.Name = "check90";
            this.check90.Size = new System.Drawing.Size(82, 20);
            this.check90.TabIndex = 15;
            this.check90.Text = "Rotar 90°";
            this.check90.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calidad:";
            // 
            // track_bar_calidad
            // 
            this.track_bar_calidad.Location = new System.Drawing.Point(6, 176);
            this.track_bar_calidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.track_bar_calidad.Maximum = 100;
            this.track_bar_calidad.Name = "track_bar_calidad";
            this.track_bar_calidad.Size = new System.Drawing.Size(220, 45);
            this.track_bar_calidad.TabIndex = 6;
            this.track_bar_calidad.Value = 50;
            this.track_bar_calidad.Scroll += new System.EventHandler(this.track_bar_calidad_Scroll);
            // 
            // panel_tamanios
            // 
            this.panel_tamanios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_tamanios.Controls.Add(this.label2);
            this.panel_tamanios.Controls.Add(this.txt_ancho);
            this.panel_tamanios.Controls.Add(this.check_dimesion);
            this.panel_tamanios.Controls.Add(this.txt_alto);
            this.panel_tamanios.Controls.Add(this.label3);
            this.panel_tamanios.Enabled = false;
            this.panel_tamanios.Location = new System.Drawing.Point(16, 56);
            this.panel_tamanios.Name = "panel_tamanios";
            this.panel_tamanios.Size = new System.Drawing.Size(200, 80);
            this.panel_tamanios.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ancho:";
            // 
            // txt_ancho
            // 
            this.txt_ancho.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ancho.Location = new System.Drawing.Point(2, 20);
            this.txt_ancho.Name = "txt_ancho";
            this.txt_ancho.Size = new System.Drawing.Size(79, 26);
            this.txt_ancho.TabIndex = 1;
            this.txt_ancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // check_dimesion
            // 
            this.check_dimesion.AutoSize = true;
            this.check_dimesion.Location = new System.Drawing.Point(2, 52);
            this.check_dimesion.Name = "check_dimesion";
            this.check_dimesion.Size = new System.Drawing.Size(143, 20);
            this.check_dimesion.TabIndex = 11;
            this.check_dimesion.Text = "Cálculo Proporcional";
            this.check_dimesion.UseVisualStyleBackColor = true;
            // 
            // txt_alto
            // 
            this.txt_alto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alto.Location = new System.Drawing.Point(114, 20);
            this.txt_alto.Name = "txt_alto";
            this.txt_alto.Size = new System.Drawing.Size(79, 26);
            this.txt_alto.TabIndex = 3;
            this.txt_alto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alto:";
            // 
            // lbl_calidad
            // 
            this.lbl_calidad.AutoSize = true;
            this.lbl_calidad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calidad.Location = new System.Drawing.Point(61, 156);
            this.lbl_calidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_calidad.Name = "lbl_calidad";
            this.lbl_calidad.Size = new System.Drawing.Size(24, 18);
            this.lbl_calidad.TabIndex = 12;
            this.lbl_calidad.Text = "50";
            // 
            // progreso
            // 
            this.progreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progreso.Location = new System.Drawing.Point(262, 751);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(930, 24);
            this.progreso.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(262, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 724);
            this.tabControl1.TabIndex = 17;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabla_imagenes);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(922, 695);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Imagenes de Entrada";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnclear);
            this.tabPage1.Controls.Add(this.btnquitar);
            this.tabPage1.Controls.Add(this.list_keys);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnguardarkey);
            this.tabPage1.Controls.Add(this.txtkey);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(922, 695);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(230, 80);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(71, 31);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Limpiar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnquitar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.Location = new System.Drawing.Point(392, 35);
            this.btnquitar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(71, 31);
            this.btnquitar.TabIndex = 18;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Visible = false;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // list_keys
            // 
            this.list_keys.FormattingEnabled = true;
            this.list_keys.ItemHeight = 16;
            this.list_keys.Location = new System.Drawing.Point(16, 133);
            this.list_keys.Name = "list_keys";
            this.list_keys.Size = new System.Drawing.Size(895, 548);
            this.list_keys.TabIndex = 17;
            this.list_keys.SelectedIndexChanged += new System.EventHandler(this.list_keys_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(236, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(151, 16);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.remove.bg/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ingrese la key:";
            // 
            // btnguardarkey
            // 
            this.btnguardarkey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnguardarkey.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarkey.Location = new System.Drawing.Point(16, 80);
            this.btnguardarkey.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnguardarkey.Name = "btnguardarkey";
            this.btnguardarkey.Size = new System.Drawing.Size(210, 31);
            this.btnguardarkey.TabIndex = 6;
            this.btnguardarkey.Text = "Guardar";
            this.btnguardarkey.UseVisualStyleBackColor = true;
            this.btnguardarkey.Click += new System.EventHandler(this.btnguardarkey_Click);
            // 
            // txtkey
            // 
            this.txtkey.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkey.Location = new System.Drawing.Point(16, 38);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(371, 27);
            this.txtkey.TabIndex = 5;
            // 
            // hilo
            // 
            this.hilo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.hilo_DoWork);
            this.hilo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.hilo_ProgressChanged);
            this.hilo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.hilo_RunWorkerCompleted);
            // 
            // lbl_progreso
            // 
            this.lbl_progreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_progreso.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progreso.Location = new System.Drawing.Point(1099, 778);
            this.lbl_progreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_progreso.Name = "lbl_progreso";
            this.lbl_progreso.Size = new System.Drawing.Size(93, 18);
            this.lbl_progreso.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(874, 734);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Puedes dar doble click en la imagen si deseas visualizarla.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 801);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_progreso);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.panel_lateral);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1220, 840);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oca-Imagenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_imagenes)).EndInit();
            this.panel_lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_bar_calidad)).EndInit();
            this.panel_tamanios.ResumeLayout(false);
            this.panel_tamanios.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_r_entrada;
        private System.Windows.Forms.TextBox txt_r_salida;
        private System.Windows.Forms.Button btn_r_entrada;
        private System.Windows.Forms.Button btn_r_salida;
        private System.Windows.Forms.DataGridView tabla_imagenes;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar track_bar_calidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_alto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ancho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Button btn_aplicar_cambios;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker hilo;
        private System.Windows.Forms.CheckBox check_dimesion;
        private System.Windows.Forms.Label lbl_calidad;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Panel panel_tamanios;
        private System.Windows.Forms.CheckBox check_tamanios;
        private System.Windows.Forms.Label lbl_progreso;
        private System.Windows.Forms.DataGridViewImageColumn cimagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn csize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check90;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardarkey;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox list_keys;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btntamaniocarnet;
    }
}

