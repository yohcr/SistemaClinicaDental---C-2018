namespace WindowsFormsApplication2
{
    partial class FormNuevoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoPaciente));
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidoPat = new System.Windows.Forms.Label();
            this.labelApellidoMat = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApePat = new System.Windows.Forms.TextBox();
            this.txtBoxApeMat = new System.Windows.Forms.TextBox();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.radioBtnFemenino = new System.Windows.Forms.RadioButton();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEdad = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturePleca = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePleca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(195, 75);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 18);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(137, 110);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(80, 18);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre(s)";
            // 
            // labelApellidoPat
            // 
            this.labelApellidoPat.AutoSize = true;
            this.labelApellidoPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoPat.Location = new System.Drawing.Point(102, 143);
            this.labelApellidoPat.Name = "labelApellidoPat";
            this.labelApellidoPat.Size = new System.Drawing.Size(115, 18);
            this.labelApellidoPat.TabIndex = 3;
            this.labelApellidoPat.Text = "Apellido Paterno";
            // 
            // labelApellidoMat
            // 
            this.labelApellidoMat.AutoSize = true;
            this.labelApellidoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoMat.Location = new System.Drawing.Point(99, 177);
            this.labelApellidoMat.Name = "labelApellidoMat";
            this.labelApellidoMat.Size = new System.Drawing.Size(118, 18);
            this.labelApellidoMat.TabIndex = 5;
            this.labelApellidoMat.Text = "Apellido Materno";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(175, 214);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(42, 18);
            this.labelEdad.TabIndex = 7;
            this.labelEdad.Text = "Edad";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtboxNombre.Location = new System.Drawing.Point(223, 106);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(203, 22);
            this.txtboxNombre.TabIndex = 1;
            this.txtboxNombre.Text = "Ej. Juan";
            this.txtboxNombre.Click += new System.EventHandler(this.txtboxNombre_Click);
            this.txtboxNombre.TextChanged += new System.EventHandler(this.txtboxNombre_TextChanged);
            this.txtboxNombre.Leave += new System.EventHandler(this.txtboxNombre_Leave);
            // 
            // txtBoxApePat
            // 
            this.txtBoxApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApePat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxApePat.Location = new System.Drawing.Point(223, 141);
            this.txtBoxApePat.Name = "txtBoxApePat";
            this.txtBoxApePat.Size = new System.Drawing.Size(203, 22);
            this.txtBoxApePat.TabIndex = 2;
            this.txtBoxApePat.Text = "Ej. Hernandez";
            this.txtBoxApePat.Click += new System.EventHandler(this.txtBoxApePat_Click);
            this.txtBoxApePat.Leave += new System.EventHandler(this.txtBoxApePat_Leave);
            // 
            // txtBoxApeMat
            // 
            this.txtBoxApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApeMat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxApeMat.Location = new System.Drawing.Point(223, 175);
            this.txtBoxApeMat.Name = "txtBoxApeMat";
            this.txtBoxApeMat.Size = new System.Drawing.Size(203, 22);
            this.txtBoxApeMat.TabIndex = 3;
            this.txtBoxApeMat.Text = "Ej. Lopez";
            this.txtBoxApeMat.Click += new System.EventHandler(this.txtBoxApeMat_Click);
            this.txtBoxApeMat.Leave += new System.EventHandler(this.txtBoxApeMat_Leave);
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMasculino.Location = new System.Drawing.Point(223, 246);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(94, 22);
            this.radioBtnMasculino.TabIndex = 5;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemenino
            // 
            this.radioBtnFemenino.AutoSize = true;
            this.radioBtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFemenino.Location = new System.Drawing.Point(324, 247);
            this.radioBtnFemenino.Name = "radioBtnFemenino";
            this.radioBtnFemenino.Size = new System.Drawing.Size(92, 22);
            this.radioBtnFemenino.TabIndex = 6;
            this.radioBtnFemenino.TabStop = true;
            this.radioBtnFemenino.Text = "Femenino";
            this.radioBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(175, 247);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(42, 18);
            this.labelSexo.TabIndex = 9;
            this.labelSexo.Text = "Sexo";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(151, 279);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(66, 18);
            this.labelTelefono.TabIndex = 12;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidad.Location = new System.Drawing.Point(126, 312);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(91, 18);
            this.labelEspecialidad.TabIndex = 14;
            this.labelEspecialidad.Text = "Especialidad";
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEspecialidad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Items.AddRange(new object[] {
            "Ortodoncia",
            "Odontopediatría",
            "Rehabilitación Oral"});
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(223, 309);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(203, 24);
            this.comboBoxEspecialidad.TabIndex = 8;
            this.comboBoxEspecialidad.Text = "Seleccione especialidad";
            this.comboBoxEspecialidad.Click += new System.EventHandler(this.comboBoxEspecialidad_Click);
            this.comboBoxEspecialidad.Leave += new System.EventHandler(this.comboBoxEspecialidad_Leave);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(491, 356);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(98, 36);
            this.BtnRegistrar.TabIndex = 10;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(387, 357);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 36);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseLeave += new System.EventHandler(this.BtnCancelar_MouseLeave);
            this.BtnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCancelar_MouseMove);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(12, 357);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(98, 36);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxID.Location = new System.Drawing.Point(223, 75);
            this.maskedTextBoxID.Mask = "99999";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.ReadOnly = true;
            this.maskedTextBoxID.Size = new System.Drawing.Size(203, 22);
            this.maskedTextBoxID.TabIndex = 0;
            this.maskedTextBoxID.ValidatingType = typeof(int);
            // 
            // comboBoxEdad
            // 
            this.comboBoxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxEdad.FormattingEnabled = true;
            this.comboBoxEdad.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.comboBoxEdad.Location = new System.Drawing.Point(223, 211);
            this.comboBoxEdad.Name = "comboBoxEdad";
            this.comboBoxEdad.Size = new System.Drawing.Size(203, 24);
            this.comboBoxEdad.TabIndex = 4;
            this.comboBoxEdad.Text = "Seleccione edad";
            this.comboBoxEdad.Click += new System.EventHandler(this.comboBoxEdad_Click);
            // 
            // maskedTextBoxTelefono
            // 
            this.maskedTextBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTelefono.ForeColor = System.Drawing.SystemColors.MenuText;
            this.maskedTextBoxTelefono.Location = new System.Drawing.Point(223, 276);
            this.maskedTextBoxTelefono.Mask = "000-000-0000";
            this.maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            this.maskedTextBoxTelefono.Size = new System.Drawing.Size(203, 22);
            this.maskedTextBoxTelefono.TabIndex = 7;
            this.maskedTextBoxTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelefono_MaskInputRejected);
            this.maskedTextBoxTelefono.Click += new System.EventHandler(this.maskedTextBoxTelefono_Click);
            this.maskedTextBoxTelefono.Leave += new System.EventHandler(this.maskedTextBoxTelefono_Leave);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(234, 15);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(183, 29);
            this.labelTitulo.TabIndex = 16;
            this.labelTitulo.Text = "Nuevo Paciente";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.NuevoPaciente;
            this.pictureBox1.Location = new System.Drawing.Point(188, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // picturePleca
            // 
            this.picturePleca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.picturePleca.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.plec_min;
            this.picturePleca.Location = new System.Drawing.Point(0, -1);
            this.picturePleca.Name = "picturePleca";
            this.picturePleca.Size = new System.Drawing.Size(620, 53);
            this.picturePleca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturePleca.TabIndex = 0;
            this.picturePleca.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.plec_min;
            this.pictureBox3.Location = new System.Drawing.Point(0, 399);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(620, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // FormNuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 421);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.maskedTextBoxTelefono);
            this.Controls.Add(this.comboBoxEdad);
            this.Controls.Add(this.maskedTextBoxID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.comboBoxEspecialidad);
            this.Controls.Add(this.labelEspecialidad);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.radioBtnFemenino);
            this.Controls.Add(this.radioBtnMasculino);
            this.Controls.Add(this.txtBoxApeMat);
            this.Controls.Add(this.txtBoxApePat);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellidoMat);
            this.Controls.Add(this.labelApellidoPat);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.picturePleca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 460);
            this.MinimumSize = new System.Drawing.Size(635, 460);
            this.Name = "FormNuevoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Paciente";
            this.Load += new System.EventHandler(this.FormNuevoPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePleca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePleca;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidoPat;
        private System.Windows.Forms.Label labelApellidoMat;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtBoxApePat;
        private System.Windows.Forms.TextBox txtBoxApeMat;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.RadioButton radioBtnFemenino;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.ComboBox comboBoxEdad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefono;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}