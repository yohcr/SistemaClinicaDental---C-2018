namespace Sistema_de_Clinica_Dental
{
    partial class FormNuevaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaCita));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCita = new System.Windows.Forms.TextBox();
            this.maskedTextBoxHora = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDentista = new System.Windows.Forms.ComboBox();
            this.comboBoxConsultorio = new System.Windows.Forms.ComboBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLetras = new System.Windows.Forms.ComboBox();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(177, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(150, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(166, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(171, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(150, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dentista";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(129, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Consultorio";
            // 
            // textBoxCita
            // 
            this.textBoxCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCita.Location = new System.Drawing.Point(218, 64);
            this.textBoxCita.Name = "textBoxCita";
            this.textBoxCita.ReadOnly = true;
            this.textBoxCita.Size = new System.Drawing.Size(245, 22);
            this.textBoxCita.TabIndex = 1;
            // 
            // maskedTextBoxHora
            // 
            this.maskedTextBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.maskedTextBoxHora.Location = new System.Drawing.Point(208, 372);
            this.maskedTextBoxHora.Mask = "00:00";
            this.maskedTextBoxHora.Name = "maskedTextBoxHora";
            this.maskedTextBoxHora.Size = new System.Drawing.Size(245, 22);
            this.maskedTextBoxHora.TabIndex = 5;
            this.maskedTextBoxHora.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxHora.Visible = false;
            this.maskedTextBoxHora.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxHora_MaskInputRejected);
            this.maskedTextBoxHora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxHora_MouseClick);
            this.maskedTextBoxHora.TextChanged += new System.EventHandler(this.maskedTextBoxHora_TextChanged);
            this.maskedTextBoxHora.Leave += new System.EventHandler(this.maskedTextBoxHora_Leave);
            // 
            // comboBoxDentista
            // 
            this.comboBoxDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxDentista.FormattingEnabled = true;
            this.comboBoxDentista.Location = new System.Drawing.Point(218, 240);
            this.comboBoxDentista.Name = "comboBoxDentista";
            this.comboBoxDentista.Size = new System.Drawing.Size(245, 24);
            this.comboBoxDentista.TabIndex = 6;
            this.comboBoxDentista.Text = "Selecciona un Dentista";
            this.comboBoxDentista.SelectedIndexChanged += new System.EventHandler(this.comboBoxDentista_SelectedIndexChanged);
            this.comboBoxDentista.Click += new System.EventHandler(this.comboBoxDentista_Click);
            // 
            // comboBoxConsultorio
            // 
            this.comboBoxConsultorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxConsultorio.FormattingEnabled = true;
            this.comboBoxConsultorio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxConsultorio.Location = new System.Drawing.Point(218, 276);
            this.comboBoxConsultorio.Name = "comboBoxConsultorio";
            this.comboBoxConsultorio.Size = new System.Drawing.Size(245, 24);
            this.comboBoxConsultorio.TabIndex = 7;
            this.comboBoxConsultorio.Text = "Selecciona un Consultorio";
            this.comboBoxConsultorio.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsultorio_SelectedIndexChanged);
            // 
            // Registrar
            // 
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(493, 347);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(103, 38);
            this.Registrar.TabIndex = 9;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            this.Registrar.Validating += new System.ComponentModel.CancelEventHandler(this.Registrar_Validating);
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(29, 347);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(97, 38);
            this.Volver.TabIndex = 8;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(241, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nueva Cita";
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(218, 133);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(245, 24);
            this.comboBoxPaciente.TabIndex = 3;
            this.comboBoxPaciente.Text = "Selecciona un Paciente";
            this.comboBoxPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaciente_SelectedIndexChanged);
            this.comboBoxPaciente.Click += new System.EventHandler(this.comboBoxPaciente_Click);
            this.comboBoxPaciente.Leave += new System.EventHandler(this.comboBoxPaciente_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.plec_min;
            this.pictureBox3.Location = new System.Drawing.Point(-207, 400);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(826, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.pictureBox2.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.calendar__1_;
            this.pictureBox2.Location = new System.Drawing.Point(120, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.plec_min;
            this.pictureBox1.Location = new System.Drawing.Point(-52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Location = new System.Drawing.Point(218, 170);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerFecha.TabIndex = 4;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(218, 365);
            this.maskedTextBoxFecha.Mask = "00/00/0000";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(209, 20);
            this.maskedTextBoxFecha.TabIndex = 26;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxFecha.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Inicial";
            // 
            // comboBoxLetras
            // 
            this.comboBoxLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLetras.FormattingEnabled = true;
            this.comboBoxLetras.Location = new System.Drawing.Point(218, 98);
            this.comboBoxLetras.Name = "comboBoxLetras";
            this.comboBoxLetras.Size = new System.Drawing.Size(245, 24);
            this.comboBoxLetras.TabIndex = 2;
            this.comboBoxLetras.Text = "Seleccione una letra";
            this.comboBoxLetras.SelectedIndexChanged += new System.EventHandler(this.comboBoxLetras_SelectedIndexChanged);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(218, 207);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerHora.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Pica aquí";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.comboBoxLetras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.comboBoxConsultorio);
            this.Controls.Add(this.comboBoxDentista);
            this.Controls.Add(this.maskedTextBoxHora);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 460);
            this.MinimumSize = new System.Drawing.Size(634, 460);
            this.Name = "FormNuevaCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva cita";
            this.Load += new System.EventHandler(this.FormNuevaCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHora;
        private System.Windows.Forms.ComboBox comboBoxDentista;
        private System.Windows.Forms.ComboBox comboBoxConsultorio;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLetras;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.Button button1;
    }
}