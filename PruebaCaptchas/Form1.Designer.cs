namespace PruebaCaptchas
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodeImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConfidence = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewDatosEmpresa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownInicio = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFin = new System.Windows.Forms.NumericUpDown();
            this.Rif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLetra = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(395, 157);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(108, 43);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Image:";
            // 
            // textBoxCodeImage
            // 
            this.textBoxCodeImage.Location = new System.Drawing.Point(139, 55);
            this.textBoxCodeImage.Name = "textBoxCodeImage";
            this.textBoxCodeImage.Size = new System.Drawing.Size(161, 22);
            this.textBoxCodeImage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confidence:";
            // 
            // textBoxConfidence
            // 
            this.textBoxConfidence.Location = new System.Drawing.Point(139, 12);
            this.textBoxConfidence.Name = "textBoxConfidence";
            this.textBoxConfidence.Size = new System.Drawing.Size(161, 22);
            this.textBoxConfidence.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Imagen Anterior:";
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(139, 92);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(174, 70);
            this.pictureBoxCaptcha.TabIndex = 8;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(668, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(624, 564);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Url = new System.Uri("http://contribuyente.seniat.gob.ve/BuscaRif/BuscaRif.jsp", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1304, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGridViewDatosEmpresa
            // 
            this.dataGridViewDatosEmpresa.AllowUserToAddRows = false;
            this.dataGridViewDatosEmpresa.AllowUserToDeleteRows = false;
            this.dataGridViewDatosEmpresa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDatosEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rif,
            this.Nombre,
            this.Ocupacion});
            this.dataGridViewDatosEmpresa.Location = new System.Drawing.Point(15, 247);
            this.dataGridViewDatosEmpresa.Name = "dataGridViewDatosEmpresa";
            this.dataGridViewDatosEmpresa.ReadOnly = true;
            this.dataGridViewDatosEmpresa.RowTemplate.Height = 24;
            this.dataGridViewDatosEmpresa.Size = new System.Drawing.Size(647, 329);
            this.dataGridViewDatosEmpresa.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fin:";
            // 
            // numericUpDownInicio
            // 
            this.numericUpDownInicio.Location = new System.Drawing.Point(456, 22);
            this.numericUpDownInicio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownInicio.Name = "numericUpDownInicio";
            this.numericUpDownInicio.Size = new System.Drawing.Size(161, 22);
            this.numericUpDownInicio.TabIndex = 15;
            // 
            // numericUpDownFin
            // 
            this.numericUpDownFin.Location = new System.Drawing.Point(456, 56);
            this.numericUpDownFin.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownFin.Name = "numericUpDownFin";
            this.numericUpDownFin.Size = new System.Drawing.Size(161, 22);
            this.numericUpDownFin.TabIndex = 16;
            this.numericUpDownFin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Rif
            // 
            this.Rif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Rif.HeaderText = "Rif";
            this.Rif.Name = "Rif";
            this.Rif.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre Empresa";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 170;
            // 
            // Ocupacion
            // 
            this.Ocupacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocupacion.HeaderText = "Ocupacion";
            this.Ocupacion.Name = "Ocupacion";
            this.Ocupacion.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Letra:";
            // 
            // comboBoxLetra
            // 
            this.comboBoxLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLetra.FormattingEnabled = true;
            this.comboBoxLetra.Items.AddRange(new object[] {
            "J",
            "G",
            "V",
            "E"});
            this.comboBoxLetra.Location = new System.Drawing.Point(456, 95);
            this.comboBoxLetra.Name = "comboBoxLetra";
            this.comboBoxLetra.Size = new System.Drawing.Size(161, 24);
            this.comboBoxLetra.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 614);
            this.Controls.Add(this.comboBoxLetra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownFin);
            this.Controls.Add(this.numericUpDownInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDatosEmpresa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxConfidence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodeImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodeImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConfidence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridViewDatosEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownInicio;
        private System.Windows.Forms.NumericUpDown numericUpDownFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLetra;
    }
}

