namespace Sistema_de_Clinica_Dental
{
    partial class FormMenuCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuCita));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGestionar = new System.Windows.Forms.Button();
            this.BtnNueva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(12, 287);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(98, 36);
            this.BtnVolver.TabIndex = 4;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Modulo de cita";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.plec_min;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(658, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.plec_min;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGestionar
            // 
            this.BtnGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(188)))), ((int)(((byte)(226)))));
            this.BtnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionar.ForeColor = System.Drawing.Color.White;
            this.BtnGestionar.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.calendar;
            this.BtnGestionar.Location = new System.Drawing.Point(344, 91);
            this.BtnGestionar.Name = "BtnGestionar";
            this.BtnGestionar.Size = new System.Drawing.Size(173, 159);
            this.BtnGestionar.TabIndex = 1;
            this.BtnGestionar.Text = "Gestionar";
            this.BtnGestionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGestionar.UseVisualStyleBackColor = false;
            this.BtnGestionar.Click += new System.EventHandler(this.BtnGestionar_Click);
            // 
            // BtnNueva
            // 
            this.BtnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(105)))), ((int)(((byte)(148)))));
            this.BtnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNueva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNueva.Image = global::Sistema_de_Clinica_Dental.Properties.Resources.calendar__1_;
            this.BtnNueva.Location = new System.Drawing.Point(130, 91);
            this.BtnNueva.Name = "BtnNueva";
            this.BtnNueva.Size = new System.Drawing.Size(173, 159);
            this.BtnNueva.TabIndex = 0;
            this.BtnNueva.Text = "Nueva";
            this.BtnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNueva.UseVisualStyleBackColor = false;
            this.BtnNueva.Click += new System.EventHandler(this.BtnNueva_Click);
            // 
            // FormMenuCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGestionar);
            this.Controls.Add(this.BtnNueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 396);
            this.MinimumSize = new System.Drawing.Size(671, 396);
            this.Name = "FormMenuCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de cita";
            this.Load += new System.EventHandler(this.FormMenuCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNueva;
        private System.Windows.Forms.Button BtnGestionar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label1;
    }
}