namespace Creador_Licencias_PELByte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerialpc = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.ComboBox();
            this.txtSoftware = new System.Windows.Forms.ComboBox();
            this.txtFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.btnRuta = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCrearLicencia = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.XMLparte1 = new System.Windows.Forms.Label();
            this.xmlParte2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDescencriptar = new System.Windows.Forms.Button();
            this.txtSerialpcCopiada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial PC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Software:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Caducidad:";
            // 
            // txtSerialpc
            // 
            this.txtSerialpc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialpc.Location = new System.Drawing.Point(183, 74);
            this.txtSerialpc.Name = "txtSerialpc";
            this.txtSerialpc.Size = new System.Drawing.Size(397, 27);
            this.txtSerialpc.TabIndex = 4;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.FormattingEnabled = true;
            this.txtPeriodo.Items.AddRange(new object[] {
            "mes(es)",
            "año(s)",
            "perpetua"});
            this.txtPeriodo.Location = new System.Drawing.Point(241, 123);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(121, 26);
            this.txtPeriodo.TabIndex = 5;
            this.txtPeriodo.SelectedIndexChanged += new System.EventHandler(this.txtPeriodo_SelectedIndexChanged);
            // 
            // txtSoftware
            // 
            this.txtSoftware.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoftware.FormattingEnabled = true;
            this.txtSoftware.Items.AddRange(new object[] {
            "PELSoft_System",
            "Sistema_Restaurantes",
            "Control_Personal"});
            this.txtSoftware.Location = new System.Drawing.Point(183, 174);
            this.txtSoftware.Name = "txtSoftware";
            this.txtSoftware.Size = new System.Drawing.Size(228, 26);
            this.txtSoftware.TabIndex = 6;
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Enabled = false;
            this.txtFechaCaducidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaCaducidad.Location = new System.Drawing.Point(183, 221);
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(142, 27);
            this.txtFechaCaducidad.TabIndex = 7;
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.Transparent;
            this.btnRuta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRuta.BackgroundImage")));
            this.btnRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRuta.FlatAppearance.BorderSize = 0;
            this.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuta.Location = new System.Drawing.Point(118, 295);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(44, 34);
            this.btnRuta.TabIndex = 1562;
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtRuta.Location = new System.Drawing.Point(183, 325);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(397, 27);
            this.txtRuta.TabIndex = 1563;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 1561;
            this.label7.Text = "Guardar en:";
            // 
            // btnCrearLicencia
            // 
            this.btnCrearLicencia.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCrearLicencia.FlatAppearance.BorderSize = 0;
            this.btnCrearLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearLicencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrearLicencia.ForeColor = System.Drawing.Color.Black;
            this.btnCrearLicencia.Location = new System.Drawing.Point(620, 271);
            this.btnCrearLicencia.Name = "btnCrearLicencia";
            this.btnCrearLicencia.Size = new System.Drawing.Size(226, 39);
            this.btnCrearLicencia.TabIndex = 1564;
            this.btnCrearLicencia.Text = "Crear Licencia";
            this.btnCrearLicencia.UseVisualStyleBackColor = false;
            this.btnCrearLicencia.Click += new System.EventHandler(this.btnCrearLicencia_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(183, 123);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 27);
            this.txtNumero.TabIndex = 1565;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumero.ValueChanged += new System.EventHandler(this.txtNumero_ValueChanged);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.RichTextBox1);
            this.Panel1.Controls.Add(this.XMLparte1);
            this.Panel1.Controls.Add(this.xmlParte2);
            this.Panel1.Location = new System.Drawing.Point(934, 35);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(24, 25);
            this.Panel1.TabIndex = 1566;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(194, 59);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(157, 102);
            this.RichTextBox1.TabIndex = 602;
            this.RichTextBox1.Text = "<?xml version=\"1.0\"?><database DBcnString=\"pelr\"></database>";
            // 
            // XMLparte1
            // 
            this.XMLparte1.AutoSize = true;
            this.XMLparte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.XMLparte1.ForeColor = System.Drawing.Color.DimGray;
            this.XMLparte1.Location = new System.Drawing.Point(22, 21);
            this.XMLparte1.Name = "XMLparte1";
            this.XMLparte1.Size = new System.Drawing.Size(303, 17);
            this.XMLparte1.TabIndex = 0;
            this.XMLparte1.Text = "<?xml version=\"1.0\"?><database DBcnString=\"";
            // 
            // xmlParte2
            // 
            this.xmlParte2.AutoSize = true;
            this.xmlParte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.xmlParte2.ForeColor = System.Drawing.Color.DimGray;
            this.xmlParte2.Location = new System.Drawing.Point(24, 60);
            this.xmlParte2.Name = "xmlParte2";
            this.xmlParte2.Size = new System.Drawing.Size(100, 17);
            this.xmlParte2.TabIndex = 0;
            this.xmlParte2.Text = "\"></database>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(620, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 86);
            this.pictureBox1.TabIndex = 1567;
            this.pictureBox1.TabStop = false;
            // 
            // btnDescencriptar
            // 
            this.btnDescencriptar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDescencriptar.FlatAppearance.BorderSize = 0;
            this.btnDescencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescencriptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnDescencriptar.ForeColor = System.Drawing.Color.Black;
            this.btnDescencriptar.Location = new System.Drawing.Point(601, 32);
            this.btnDescencriptar.Name = "btnDescencriptar";
            this.btnDescencriptar.Size = new System.Drawing.Size(198, 27);
            this.btnDescencriptar.TabIndex = 1568;
            this.btnDescencriptar.Text = "Descencriptar";
            this.btnDescencriptar.UseVisualStyleBackColor = false;
            this.btnDescencriptar.Click += new System.EventHandler(this.btnDescencriptar_Click);
            // 
            // txtSerialpcCopiada
            // 
            this.txtSerialpcCopiada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialpcCopiada.Location = new System.Drawing.Point(183, 32);
            this.txtSerialpcCopiada.Name = "txtSerialpcCopiada";
            this.txtSerialpcCopiada.Size = new System.Drawing.Size(397, 27);
            this.txtSerialpcCopiada.TabIndex = 1570;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 1569;
            this.label5.Text = "Copiar Serial PC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 430);
            this.Controls.Add(this.txtSerialpcCopiada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDescencriptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnCrearLicencia);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaCaducidad);
            this.Controls.Add(this.txtSoftware);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtSerialpc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador de Licencias Aplicativos by PELByte";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerialpc;
        private System.Windows.Forms.ComboBox txtPeriodo;
        private System.Windows.Forms.ComboBox txtSoftware;
        private System.Windows.Forms.DateTimePicker txtFechaCaducidad;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btnCrearLicencia;
        internal System.Windows.Forms.NumericUpDown txtNumero;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Label XMLparte1;
        internal System.Windows.Forms.Label xmlParte2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btnDescencriptar;
        private System.Windows.Forms.TextBox txtSerialpcCopiada;
        private System.Windows.Forms.Label label5;
    }
}

