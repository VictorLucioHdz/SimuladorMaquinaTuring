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
            this.btnEscribirN = new System.Windows.Forms.Button();
            this.brnEscribirDer = new System.Windows.Forms.Button();
            this.btnEscribirIzq = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbLectura = new System.Windows.Forms.GroupBox();
            this.lblLeyendo = new System.Windows.Forms.Label();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLetraBusqueda = new System.Windows.Forms.ComboBox();
            this.grbBusquedaEscritura = new System.Windows.Forms.GroupBox();
            this.txtOcurrencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarYRemplazar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRemplazar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.grbCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).BeginInit();
            this.grbMover.SuspendLayout();
            this.grbEscribir.SuspendLayout();
            this.grbLectura.SuspendLayout();
            this.grbBusqueda.SuspendLayout();
            this.grbBusquedaEscritura.SuspendLayout();
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
            this.grbCaptura.Size = new System.Drawing.Size(201, 136);
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
            this.dgvCinta.Location = new System.Drawing.Point(163, 205);
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
            this.grbMover.Location = new System.Drawing.Point(230, 25);
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
            this.grbEscribir.Controls.Add(this.btnEscribirN);
            this.grbEscribir.Controls.Add(this.brnEscribirDer);
            this.grbEscribir.Controls.Add(this.btnEscribirIzq);
            this.grbEscribir.Controls.Add(this.comboBox1);
            this.grbEscribir.Controls.Add(this.label3);
            this.grbEscribir.Enabled = false;
            this.grbEscribir.Location = new System.Drawing.Point(412, 25);
            this.grbEscribir.Name = "grbEscribir";
            this.grbEscribir.Size = new System.Drawing.Size(206, 136);
            this.grbEscribir.TabIndex = 7;
            this.grbEscribir.TabStop = false;
            this.grbEscribir.Text = "Escritura";
            // 
            // btnEscribirN
            // 
            this.btnEscribirN.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribirN.Location = new System.Drawing.Point(81, 68);
            this.btnEscribirN.Name = "btnEscribirN";
            this.btnEscribirN.Size = new System.Drawing.Size(50, 38);
            this.btnEscribirN.TabIndex = 4;
            this.btnEscribirN.Text = "N";
            this.btnEscribirN.UseVisualStyleBackColor = true;
            // 
            // brnEscribirDer
            // 
            this.brnEscribirDer.AutoSize = true;
            this.brnEscribirDer.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEscribirDer.Location = new System.Drawing.Point(137, 68);
            this.brnEscribirDer.Name = "brnEscribirDer";
            this.brnEscribirDer.Size = new System.Drawing.Size(54, 38);
            this.brnEscribirDer.TabIndex = 3;
            this.brnEscribirDer.Text = "→";
            this.brnEscribirDer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brnEscribirDer.UseVisualStyleBackColor = true;
            // 
            // btnEscribirIzq
            // 
            this.btnEscribirIzq.AutoSize = true;
            this.btnEscribirIzq.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribirIzq.Location = new System.Drawing.Point(19, 68);
            this.btnEscribirIzq.Name = "btnEscribirIzq";
            this.btnEscribirIzq.Size = new System.Drawing.Size(52, 38);
            this.btnEscribirIzq.TabIndex = 2;
            this.btnEscribirIzq.Text = "←";
            this.btnEscribirIzq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEscribirIzq.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "x",
            "y",
            "z",
            "B"});
            this.comboBox1.Location = new System.Drawing.Point(58, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Letra : ";
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
            this.grbLectura.Location = new System.Drawing.Point(624, 25);
            this.grbLectura.Name = "grbLectura";
            this.grbLectura.Size = new System.Drawing.Size(130, 69);
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
            this.grbBusqueda.Controls.Add(this.btnBusqueda);
            this.grbBusqueda.Controls.Add(this.label5);
            this.grbBusqueda.Controls.Add(this.cboLetraBusqueda);
            this.grbBusqueda.Enabled = false;
            this.grbBusqueda.Location = new System.Drawing.Point(770, 25);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(200, 100);
            this.grbBusqueda.TabIndex = 10;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Busqueda";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(49, 55);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(105, 33);
            this.btnBusqueda.TabIndex = 5;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Letra : ";
            // 
            // cboLetraBusqueda
            // 
            this.cboLetraBusqueda.FormattingEnabled = true;
            this.cboLetraBusqueda.Items.AddRange(new object[] {
            "x",
            "y",
            "z",
            "B"});
            this.cboLetraBusqueda.Location = new System.Drawing.Point(58, 25);
            this.cboLetraBusqueda.Name = "cboLetraBusqueda";
            this.cboLetraBusqueda.Size = new System.Drawing.Size(83, 24);
            this.cboLetraBusqueda.TabIndex = 4;
            // 
            // grbBusquedaEscritura
            // 
            this.grbBusquedaEscritura.Controls.Add(this.txtOcurrencia);
            this.grbBusquedaEscritura.Controls.Add(this.label8);
            this.grbBusquedaEscritura.Controls.Add(this.btnBuscarYRemplazar);
            this.grbBusquedaEscritura.Controls.Add(this.label7);
            this.grbBusquedaEscritura.Controls.Add(this.cboRemplazar);
            this.grbBusquedaEscritura.Controls.Add(this.label6);
            this.grbBusquedaEscritura.Controls.Add(this.cboBuscar);
            this.grbBusquedaEscritura.Enabled = false;
            this.grbBusquedaEscritura.Location = new System.Drawing.Point(23, 329);
            this.grbBusquedaEscritura.Name = "grbBusquedaEscritura";
            this.grbBusquedaEscritura.Size = new System.Drawing.Size(213, 202);
            this.grbBusquedaEscritura.TabIndex = 11;
            this.grbBusquedaEscritura.TabStop = false;
            this.grbBusquedaEscritura.Text = "Busqueda y Remplazar ";
            // 
            // txtOcurrencia
            // 
            this.txtOcurrencia.Location = new System.Drawing.Point(94, 109);
            this.txtOcurrencia.Name = "txtOcurrencia";
            this.txtOcurrencia.Size = new System.Drawing.Size(51, 22);
            this.txtOcurrencia.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ocurrencia : ";
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
            // x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 567);
            this.Controls.Add(this.grbBusquedaEscritura);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.grbLectura);
            this.Controls.Add(this.grbEscribir);
            this.Controls.Add(this.grbMover);
            this.Controls.Add(this.dgvCinta);
            this.Controls.Add(this.grbCaptura);
            this.Name = "x";
            this.Text = "Form1";
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
            this.grbBusquedaEscritura.ResumeLayout(false);
            this.grbBusquedaEscritura.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEscribirIzq;
        private System.Windows.Forms.Button btnCabezalDerecha;
        private System.Windows.Forms.Button btnCabezalIzquirda;
        private System.Windows.Forms.Button brnEscribirDer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbLectura;
        private System.Windows.Forms.Label lblLeyendo;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLetraBusqueda;
        private System.Windows.Forms.GroupBox grbBusquedaEscritura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRemplazar;
        private System.Windows.Forms.Button btnBuscarYRemplazar;
        private System.Windows.Forms.TextBox txtOcurrencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEscribirN;
    }
}

