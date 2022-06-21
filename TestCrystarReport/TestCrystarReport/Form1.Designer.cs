namespace TestCrystarReport
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.OFDReporte = new System.Windows.Forms.OpenFileDialog();
            this.txtDireccionReporte = new System.Windows.Forms.TextBox();
            this.btnBuscarReporte = new System.Windows.Forms.Button();
            this.txtDirectorioDestino = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.fbdDirectorioDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMunicipio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbRecinto = new System.Windows.Forms.Label();
            this.lbColegio = new System.Windows.Forms.Label();
            this.lbDistritoNacional = new System.Windows.Forms.Label();
            this.lbcircunscripcion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbSeguridadIntegrada = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tvProvinciasYmunicipios = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbpais = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Reportes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OFDReporte
            // 
            this.OFDReporte.FileName = "openFileDialog1";
            // 
            // txtDireccionReporte
            // 
            this.txtDireccionReporte.Location = new System.Drawing.Point(143, 128);
            this.txtDireccionReporte.Name = "txtDireccionReporte";
            this.txtDireccionReporte.Size = new System.Drawing.Size(452, 20);
            this.txtDireccionReporte.TabIndex = 2;
            // 
            // btnBuscarReporte
            // 
            this.btnBuscarReporte.Location = new System.Drawing.Point(25, 128);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(112, 20);
            this.btnBuscarReporte.TabIndex = 0;
            this.btnBuscarReporte.Text = "Buscar Reportes";
            this.btnBuscarReporte.UseVisualStyleBackColor = true;
            this.btnBuscarReporte.Click += new System.EventHandler(this.btnBuscarReporte_Click);
            // 
            // txtDirectorioDestino
            // 
            this.txtDirectorioDestino.Location = new System.Drawing.Point(143, 155);
            this.txtDirectorioDestino.Name = "txtDirectorioDestino";
            this.txtDirectorioDestino.Size = new System.Drawing.Size(452, 20);
            this.txtDirectorioDestino.TabIndex = 2;
            this.txtDirectorioDestino.TextChanged += new System.EventHandler(this.txtDirectorioDestino_TextChanged);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(25, 154);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(112, 20);
            this.btnDestino.TabIndex = 0;
            this.btnDestino.Text = "Carpeta Destino ";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Provincia:";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Location = new System.Drawing.Point(77, 32);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(19, 13);
            this.lbProvincia.TabIndex = 4;
            this.lbProvincia.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Municipio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbMunicipio
            // 
            this.lbMunicipio.AutoSize = true;
            this.lbMunicipio.Location = new System.Drawing.Point(78, 57);
            this.lbMunicipio.Name = "lbMunicipio";
            this.lbMunicipio.Size = new System.Drawing.Size(19, 13);
            this.lbMunicipio.TabIndex = 4;
            this.lbMunicipio.Text = "----";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbRecinto);
            this.groupBox1.Controls.Add(this.lbColegio);
            this.groupBox1.Controls.Add(this.lbDistritoNacional);
            this.groupBox1.Controls.Add(this.lbMunicipio);
            this.groupBox1.Controls.Add(this.lbcircunscripcion);
            this.groupBox1.Controls.Add(this.lbpais);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbProvincia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(216, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso Actual";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Circunscripción:";
            // 
            // lbRecinto
            // 
            this.lbRecinto.AutoSize = true;
            this.lbRecinto.Location = new System.Drawing.Point(77, 108);
            this.lbRecinto.Name = "lbRecinto";
            this.lbRecinto.Size = new System.Drawing.Size(19, 13);
            this.lbRecinto.TabIndex = 4;
            this.lbRecinto.Text = "----";
            // 
            // lbColegio
            // 
            this.lbColegio.AutoSize = true;
            this.lbColegio.Location = new System.Drawing.Point(78, 127);
            this.lbColegio.Name = "lbColegio";
            this.lbColegio.Size = new System.Drawing.Size(19, 13);
            this.lbColegio.TabIndex = 4;
            this.lbColegio.Text = "----";
            // 
            // lbDistritoNacional
            // 
            this.lbDistritoNacional.AutoSize = true;
            this.lbDistritoNacional.Location = new System.Drawing.Point(128, 92);
            this.lbDistritoNacional.Name = "lbDistritoNacional";
            this.lbDistritoNacional.Size = new System.Drawing.Size(19, 13);
            this.lbDistritoNacional.TabIndex = 4;
            this.lbDistritoNacional.Text = "----";
            // 
            // lbcircunscripcion
            // 
            this.lbcircunscripcion.AutoSize = true;
            this.lbcircunscripcion.Location = new System.Drawing.Point(119, 79);
            this.lbcircunscripcion.Name = "lbcircunscripcion";
            this.lbcircunscripcion.Size = new System.Drawing.Size(19, 13);
            this.lbcircunscripcion.TabIndex = 4;
            this.lbcircunscripcion.Text = "----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Recinto:";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Colegio:";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(16, 92);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(109, 13);
            this.no.TabIndex = 3;
            this.no.Text = "Distrito Municipal:";
            this.no.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(103, 29);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(152, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbSeguridadIntegrada);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtClave);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBaseDatos);
            this.groupBox2.Controls.Add(this.txtServidor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(25, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conectar";
            // 
            // chbSeguridadIntegrada
            // 
            this.chbSeguridadIntegrada.AutoSize = true;
            this.chbSeguridadIntegrada.Location = new System.Drawing.Point(103, 76);
            this.chbSeguridadIntegrada.Name = "chbSeguridadIntegrada";
            this.chbSeguridadIntegrada.Size = new System.Drawing.Size(122, 17);
            this.chbSeguridadIntegrada.TabIndex = 4;
            this.chbSeguridadIntegrada.Text = "Seguridad Integrada";
            this.chbSeguridadIntegrada.UseVisualStyleBackColor = true;
            this.chbSeguridadIntegrada.Visible = false;
            this.chbSeguridadIntegrada.CheckedChanged += new System.EventHandler(this.chbSeguridadIntegrada_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Servidor:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(390, 54);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(152, 20);
            this.txtClave.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(390, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(103, 50);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(152, 20);
            this.txtBaseDatos.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Base Datos:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // tvProvinciasYmunicipios
            // 
            this.tvProvinciasYmunicipios.CheckBoxes = true;
            this.tvProvinciasYmunicipios.Location = new System.Drawing.Point(887, 25);
            this.tvProvinciasYmunicipios.Name = "tvProvinciasYmunicipios";
            this.tvProvinciasYmunicipios.Size = new System.Drawing.Size(220, 239);
            this.tvProvinciasYmunicipios.TabIndex = 7;
            this.tvProvinciasYmunicipios.Visible = false;
            this.tvProvinciasYmunicipios.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvProvinciasYmunicipios_AfterCheck);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(870, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 251);
            this.listBox1.TabIndex = 8;
            this.listBox1.Visible = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(620, 44);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(229, 289);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.Text = "having dm=\'321-CAÑONGO (DM)\' ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(617, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Filtro Específico:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(293, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "PADRON EXTERIOR";
            // 
            // lbpais
            // 
            this.lbpais.AutoSize = true;
            this.lbpais.Location = new System.Drawing.Point(77, 19);
            this.lbpais.Name = "lbpais";
            this.lbpais.Size = new System.Drawing.Size(19, 13);
            this.lbpais.TabIndex = 4;
            this.lbpais.Text = "----";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Pais:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 345);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tvProvinciasYmunicipios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDirectorioDestino);
            this.Controls.Add(this.txtDireccionReporte);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnBuscarReporte);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PADRON EXTERIOR ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OFDReporte;
        private System.Windows.Forms.TextBox txtDireccionReporte;
        private System.Windows.Forms.Button btnBuscarReporte;
        private System.Windows.Forms.TextBox txtDirectorioDestino;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectorioDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMunicipio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbSeguridadIntegrada;
        private System.Windows.Forms.TreeView tvProvinciasYmunicipios;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbDistritoNacional;
        private System.Windows.Forms.Label lbcircunscripcion;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbColegio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRecinto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbpais;
    }
}

