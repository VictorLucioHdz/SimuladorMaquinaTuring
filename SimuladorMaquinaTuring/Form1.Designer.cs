namespace SimuladorMaquinaTuring
{
    partial class x
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.grbCaptura = new System.Windows.Forms.GroupBox();
            this.dgvCinta = new System.Windows.Forms.DataGridView();
            this.grbMover = new System.Windows.Forms.GroupBox();
            this.btnCabezalDerecha = new System.Windows.Forms.Button();
            this.btnCabezalIzquirda = new System.Windows.Forms.Button();
            this.grbEscribir = new System.Windows.Forms.GroupBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.cmbEscribir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbLectura = new System.Windows.Forms.GroupBox();
            this.lblLeyendo = new System.Windows.Forms.Label();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.EmpezarEn = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.radIzq = new System.Windows.Forms.RadioButton();
            this.radDerecha = new System.Windows.Forms.RadioButton();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.grbBusquedaEscritura = new System.Windows.Forms.GroupBox();
            this.btnBuscarYRemplazar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOcurrencia = new System.Windows.Forms.TextBox();
            this.cboRemplazar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.listaOpe = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMoverIzq = new System.Windows.Forms.RadioButton();
            this.radMoverD = new System.Windows.Forms.RadioButton();
            this.btnMover = new System.Windows.Forms.Button();
            this.lblDefinicionFormal = new System.Windows.Forms.Label();
            this.grbCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).BeginInit();
            this.grbMover.SuspendLayout();
            this.grbEscribir.SuspendLayout();
            this.grbLectura.SuspendLayout();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpezarEn)).BeginInit();
            this.grbBusquedaEscritura.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(86, 50);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 22);
            this.txtCadena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alfabeto:  x y z B";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadena: ";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(40, 94);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(146, 23);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Guardar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // grbCaptura
            // 
            this.grbCaptura.Controls.Add(this.txtCadena);
            this.grbCaptura.Controls.Add(this.btnCapturar);
            this.grbCaptura.Controls.Add(this.label1);
            this.grbCaptura.Controls.Add(this.label2);
            this.grbCaptura.Location = new System.Drawing.Point(23, 25);
            this.grbCaptura.Name = "grbCaptura";
            this.grbCaptura.Size = new System.Drawing.Size(213, 136);
            this.grbCaptura.TabIndex = 4;
            this.grbCaptura.TabStop = false;
            this.grbCaptura.Text = "Cadena";
            // 
            // dgvCinta
            // 
            this.dgvCinta.AllowUserToAddRows = false;
            this.dgvCinta.AllowUserToDeleteRows = false;
            this.dgvCinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinta.ColumnHeadersVisible = false;
            this.dgvCinta.Location = new System.Drawing.Point(470, 176);
            this.dgvCinta.Name = "dgvCinta";
            this.dgvCinta.ReadOnly = true;
            this.dgvCinta.RowHeadersVisible = false;
            this.dgvCinta.RowHeadersWidth = 51;
            this.dgvCinta.RowTemplate.Height = 24;
            this.dgvCinta.Size = new System.Drawing.Size(748, 87);
            this.dgvCinta.TabIndex = 5;
            this.dgvCinta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCinta_CellContentClick);
            // 
            // grbMover
            // 
            this.grbMover.Controls.Add(this.btnCabezalDerecha);
            this.grbMover.Controls.Add(this.btnCabezalIzquirda);
            this.grbMover.Enabled = false;
            this.grbMover.Location = new System.Drawing.Point(255, 25);
            this.grbMover.Name = "grbMover";
            this.grbMover.Size = new System.Drawing.Size(176, 95);
            this.grbMover.TabIndex = 6;
            this.grbMover.TabStop = false;
            this.grbMover.Text = "Mover Cabezal";
            // 
            // btnCabezalDerecha
            // 
            this.btnCabezalDerecha.AutoSize = true;
            this.btnCabezalDerecha.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabezalDerecha.Location = new System.Drawing.Point(90, 35);
            this.btnCabezalDerecha.Name = "btnCabezalDerecha";
            this.btnCabezalDerecha.Size = new System.Drawing.Size(75, 38);
            this.btnCabezalDerecha.TabIndex = 4;
            this.btnCabezalDerecha.Text = "→";
            this.btnCabezalDerecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCabezalDerecha.UseVisualStyleBackColor = true;
            this.btnCabezalDerecha.Click += new System.EventHandler(this.btnCabezalDerecha_Click);
            // 
            // btnCabezalIzquirda
            // 
            this.btnCabezalIzquirda.AutoSize = true;
            this.btnCabezalIzquirda.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabezalIzquirda.Location = new System.Drawing.Point(9, 35);
            this.btnCabezalIzquirda.Name = "btnCabezalIzquirda";
            this.btnCabezalIzquirda.Size = new System.Drawing.Size(75, 38);
            this.btnCabezalIzquirda.TabIndex = 4;
            this.btnCabezalIzquirda.Text = "←";
            this.btnCabezalIzquirda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCabezalIzquirda.UseVisualStyleBackColor = true;
            this.btnCabezalIzquirda.Click += new System.EventHandler(this.btnCabezalIzquirda_Click);
            // 
            // grbEscribir
            // 
            this.grbEscribir.Controls.Add(this.btnEscribir);
            this.grbEscribir.Controls.Add(this.cmbEscribir);
            this.grbEscribir.Controls.Add(this.label3);
            this.grbEscribir.Enabled = false;
            this.grbEscribir.Location = new System.Drawing.Point(30, 176);
            this.grbEscribir.Name = "grbEscribir";
            this.grbEscribir.Size = new System.Drawing.Size(206, 136);
            this.grbEscribir.TabIndex = 7;
            this.grbEscribir.TabStop = false;
            this.grbEscribir.Text = "Escritura";
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(46, 68);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(105, 33);
            this.btnEscribir.TabIndex = 12;
            this.btnEscribir.Text = "Agregar";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // cmbEscribir
            // 
            this.cmbEscribir.FormattingEnabled = true;
            this.cmbEscribir.Items.AddRange(new object[] {
            "x",
            "y",
            "z",
            "B"});
            this.cmbEscribir.Location = new System.Drawing.Point(78, 25);
            this.cmbEscribir.Name = "cmbEscribir";
            this.cmbEscribir.Size = new System.Drawing.Size(121, 24);
            this.cmbEscribir.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Simbolo : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Leyendo : ";
            // 
            // grbLectura
            // 
            this.grbLectura.Controls.Add(this.lblLeyendo);
            this.grbLectura.Controls.Add(this.label4);
            this.grbLectura.Enabled = false;
            this.grbLectura.Location = new System.Drawing.Point(737, 25);
            this.grbLectura.Name = "grbLectura";
            this.grbLectura.Size = new System.Drawing.Size(176, 69);
            this.grbLectura.TabIndex = 9;
            this.grbLectura.TabStop = false;
            this.grbLectura.Text = "Lectura";
            // 
            // lblLeyendo
            // 
            this.lblLeyendo.AutoSize = true;
            this.lblLeyendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyendo.Location = new System.Drawing.Point(90, 26);
            this.lblLeyendo.Name = "lblLeyendo";
            this.lblLeyendo.Size = new System.Drawing.Size(25, 25);
            this.lblLeyendo.TabIndex = 9;
            this.lblLeyendo.Text = "B";
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.EmpezarEn);
            this.grbBusqueda.Controls.Add(this.label11);
            this.grbBusqueda.Controls.Add(this.radIzq);
            this.grbBusqueda.Controls.Add(this.radDerecha);
            this.grbBusqueda.Controls.Add(this.btnBusqueda);
            this.grbBusqueda.Controls.Add(this.label5);
            this.grbBusqueda.Controls.Add(this.cmbBusqueda);
            this.grbBusqueda.Enabled = false;
            this.grbBusqueda.Location = new System.Drawing.Point(255, 244);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(176, 223);
            this.grbBusqueda.TabIndex = 10;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Busqueda";
            // 
            // EmpezarEn
            // 
            this.EmpezarEn.Location = new System.Drawing.Point(95, 108);
            this.EmpezarEn.Name = "EmpezarEn";
            this.EmpezarEn.Size = new System.Drawing.Size(51, 22);
            this.EmpezarEn.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Apartir de : ";
            // 
            // radIzq
            // 
            this.radIzq.AutoSize = true;
            this.radIzq.Location = new System.Drawing.Point(18, 73);
            this.radIzq.Name = "radIzq";
            this.radIzq.Size = new System.Drawing.Size(83, 20);
            this.radIzq.TabIndex = 7;
            this.radIzq.Text = "Izquierda";
            this.radIzq.UseVisualStyleBackColor = true;
            this.radIzq.CheckedChanged += new System.EventHandler(this.radIzq_CheckedChanged);
            // 
            // radDerecha
            // 
            this.radDerecha.AutoSize = true;
            this.radDerecha.Checked = true;
            this.radDerecha.Location = new System.Drawing.Point(23, 48);
            this.radDerecha.Name = "radDerecha";
            this.radDerecha.Size = new System.Drawing.Size(80, 20);
            this.radDerecha.TabIndex = 6;
            this.radDerecha.TabStop = true;
            this.radDerecha.Text = "Derecha";
            this.radDerecha.UseVisualStyleBackColor = true;
            this.radDerecha.CheckedChanged += new System.EventHandler(this.radDerecha_CheckedChanged);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(23, 169);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(105, 33);
            this.btnBusqueda.TabIndex = 5;
            this.btnBusqueda.Text = "Agregar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Simbolo : ";
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "x",
            "y",
            "z",
            "B",
            "#"});
            this.cmbBusqueda.Location = new System.Drawing.Point(90, 22);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(56, 24);
            this.cmbBusqueda.TabIndex = 4;
            // 
            // grbBusquedaEscritura
            // 
            this.grbBusquedaEscritura.Controls.Add(this.btnBuscarYRemplazar);
            this.grbBusquedaEscritura.Controls.Add(this.label7);
            this.grbBusquedaEscritura.Controls.Add(this.txtOcurrencia);
            this.grbBusquedaEscritura.Controls.Add(this.cboRemplazar);
            this.grbBusquedaEscritura.Controls.Add(this.label6);
            this.grbBusquedaEscritura.Controls.Add(this.label8);
            this.grbBusquedaEscritura.Controls.Add(this.cboBuscar);
            this.grbBusquedaEscritura.Enabled = false;
            this.grbBusquedaEscritura.Location = new System.Drawing.Point(1045, 343);
            this.grbBusquedaEscritura.Name = "grbBusquedaEscritura";
            this.grbBusquedaEscritura.Size = new System.Drawing.Size(213, 202);
            this.grbBusquedaEscritura.TabIndex = 11;
            this.grbBusquedaEscritura.TabStop = false;
            this.grbBusquedaEscritura.Text = "cREO QUE  NO NOS SIRVE";
            this.grbBusquedaEscritura.Enter += new System.EventHandler(this.grbBusquedaEscritura_Enter);
            // 
            // btnBuscarYRemplazar
            // 
            this.btnBuscarYRemplazar.Location = new System.Drawing.Point(66, 163);
            this.btnBuscarYRemplazar.Name = "btnBuscarYRemplazar";
            this.btnBuscarYRemplazar.Size = new System.Drawing.Size(105, 33);
            this.btnBuscarYRemplazar.TabIndex = 6;
            this.btnBuscarYRemplazar.Text = "Buscar";
            this.btnBuscarYRemplazar.UseVisualStyleBackColor = true;
            this.btnBuscarYRemplazar.Click += new System.EventHandler(this.btnBuscarYRemplazar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Remplazar por :";
            // 
            // txtOcurrencia
            // 
            this.txtOcurrencia.Location = new System.Drawing.Point(94, 108);
            this.txtOcurrencia.Name = "txtOcurrencia";
            this.txtOcurrencia.Size = new System.Drawing.Size(51, 22);
            this.txtOcurrencia.TabIndex = 11;
            // 
            // cboRemplazar
            // 
            this.cboRemplazar.FormattingEnabled = true;
            this.cboRemplazar.Items.AddRange(new object[] {
            "x",
            "y",
            "z",
            "B"});
            this.cboRemplazar.Location = new System.Drawing.Point(115, 70);
            this.cboRemplazar.Name = "cboRemplazar";
            this.cboRemplazar.Size = new System.Drawing.Size(71, 24);
            this.cboRemplazar.TabIndex = 9;
            this.cboRemplazar.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Busacar : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ocurrencia : ";
            // 
            // cboBuscar
            // 
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "x",
            "y",
            "z",
            "B"});
            this.cboBuscar.Location = new System.Drawing.Point(88, 29);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(83, 24);
            this.cboBuscar.TabIndex = 7;
            // 
            // listaOpe
            // 
            this.listaOpe.FormattingEnabled = true;
            this.listaOpe.ItemHeight = 16;
            this.listaOpe.Location = new System.Drawing.Point(495, 25);
            this.listaOpe.Name = "listaOpe";
            this.listaOpe.Size = new System.Drawing.Size(211, 132);
            this.listaOpe.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnMarcar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(255, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 95);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "#";
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(41, 50);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(105, 33);
            this.btnMarcar.TabIndex = 12;
            this.btnMarcar.Text = "Agregar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Simbolo : ";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(263, 494);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(150, 51);
            this.btnEjecutar.TabIndex = 14;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMoverIzq);
            this.groupBox2.Controls.Add(this.radMoverD);
            this.groupBox2.Controls.Add(this.btnMover);
            this.groupBox2.Location = new System.Drawing.Point(23, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 138);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MOVER";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radMoverIzq
            // 
            this.radMoverIzq.AutoSize = true;
            this.radMoverIzq.Location = new System.Drawing.Point(16, 43);
            this.radMoverIzq.Name = "radMoverIzq";
            this.radMoverIzq.Size = new System.Drawing.Size(83, 20);
            this.radMoverIzq.TabIndex = 7;
            this.radMoverIzq.Text = "Izquierda";
            this.radMoverIzq.UseVisualStyleBackColor = true;
            this.radMoverIzq.CheckedChanged += new System.EventHandler(this.radMoverIzq_CheckedChanged);
            // 
            // radMoverD
            // 
            this.radMoverD.AutoSize = true;
            this.radMoverD.Checked = true;
            this.radMoverD.Location = new System.Drawing.Point(16, 22);
            this.radMoverD.Name = "radMoverD";
            this.radMoverD.Size = new System.Drawing.Size(80, 20);
            this.radMoverD.TabIndex = 6;
            this.radMoverD.TabStop = true;
            this.radMoverD.Text = "Derecha";
            this.radMoverD.UseVisualStyleBackColor = true;
            this.radMoverD.CheckedChanged += new System.EventHandler(this.radMoverD_CheckedChanged);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(22, 81);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(105, 33);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = "Agregar";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // lblDefinicionFormal
            // 
            this.lblDefinicionFormal.AutoSize = true;
            this.lblDefinicionFormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinicionFormal.Location = new System.Drawing.Point(465, 287);
            this.lblDefinicionFormal.Name = "lblDefinicionFormal";
            this.lblDefinicionFormal.Size = new System.Drawing.Size(0, 25);
            this.lblDefinicionFormal.TabIndex = 17;
            // 
            // x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 567);
            this.Controls.Add(this.lblDefinicionFormal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaOpe);
            this.Controls.Add(this.grbBusquedaEscritura);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.grbLectura);
            this.Controls.Add(this.grbEscribir);
            this.Controls.Add(this.grbMover);
            this.Controls.Add(this.dgvCinta);
            this.Controls.Add(this.grbCaptura);
            this.Name = "x";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.x_Load);
            this.grbCaptura.ResumeLayout(false);
            this.grbCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).EndInit();
            this.grbMover.ResumeLayout(false);
            this.grbMover.PerformLayout();
            this.grbEscribir.ResumeLayout(false);
            this.grbEscribir.PerformLayout();
            this.grbLectura.ResumeLayout(false);
            this.grbLectura.PerformLayout();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpezarEn)).EndInit();
            this.grbBusquedaEscritura.ResumeLayout(false);
            this.grbBusquedaEscritura.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.GroupBox grbCaptura;
        private System.Windows.Forms.DataGridView dgvCinta;
        private System.Windows.Forms.GroupBox grbMover;
        private System.Windows.Forms.GroupBox grbEscribir;
        private System.Windows.Forms.ComboBox cmbEscribir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCabezalDerecha;
        private System.Windows.Forms.Button btnCabezalIzquirda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbLectura;
        private System.Windows.Forms.Label lblLeyendo;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.GroupBox grbBusquedaEscritura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRemplazar;
        private System.Windows.Forms.Button btnBuscarYRemplazar;
        private System.Windows.Forms.TextBox txtOcurrencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.RadioButton radIzq;
        private System.Windows.Forms.RadioButton radDerecha;
        private System.Windows.Forms.ListBox listaOpe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown EmpezarEn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMoverIzq;
        private System.Windows.Forms.RadioButton radMoverD;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label lblDefinicionFormal;
    }
}

