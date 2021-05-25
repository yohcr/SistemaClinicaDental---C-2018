using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsFormsApplication2
{
    public partial class FormNuevoPaciente : Form
    {

        public string Usuario { get; set; }

        public FormNuevoPaciente()
        {
            InitializeComponent();
        }

        private void BtnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnVolver.BackColor = Color.SteelBlue;
            this.BtnVolver.ForeColor = Color.White;
        }

        private void BtnVolver_MouseLeave(object sender, EventArgs e)
        {
            this.BtnVolver.BackColor = Color.Gainsboro;
            this.BtnVolver.ForeColor = Color.Black;
        }

        private void BtnRegistrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnRegistrar.BackColor = Color.SteelBlue;
            this.BtnRegistrar.ForeColor = Color.White;
        }

        private void BtnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnRegistrar.BackColor = Color.Gainsboro;
            this.BtnRegistrar.ForeColor = Color.Black;
        }


        private void BtnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnCancelar.BackColor = Color.SteelBlue;
            this.BtnCancelar.ForeColor = Color.White;
        }

        private void BtnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnCancelar.BackColor = Color.Gainsboro;
            this.BtnCancelar.ForeColor = Color.Black;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text != "Ej. Juan" && txtBoxApePat.Text != "Ej. Hernandez" && txtBoxApeMat.Text != " Ej. Lopez" && maskedTextBoxTelefono.MaskFull == true)
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas volver al menú?", "Advertencia", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    FormPaciente menuPaciente = new FormPaciente();
                    menuPaciente.Usuario = Usuario;
                    menuPaciente.Show();
                }
            
            }
            else {
                this.Hide();
                FormPaciente menuPaciente = new FormPaciente();
                menuPaciente.Usuario = Usuario;
                menuPaciente.Show();
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea cancelar el registro del paciente? ", "Advertencia" , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes) {
                this.Hide();
                FormPaciente menuPaciente = new FormPaciente();
                menuPaciente.Usuario = Usuario;
                menuPaciente.Show();
            }
            
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FormNuevoPaciente_Load(object sender, EventArgs e)
        {
            maskedTextBoxID.Text = Convert.ToString(GestionPaciente.ultimoRegistro()+1);
            //MessageBox.Show(Usuario);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtboxNombre.Text == " Ej. Juan" || txtBoxApePat.Text == "Ej. Hernandez" || txtBoxApeMat.Text == "Ej. Lopez" | maskedTextBoxTelefono.Text == "" || comboBoxEdad.Text == "Seleccione edad" || comboBoxEspecialidad.Text == "Seleccione especialidad")
            {
               MessageBox.Show("Hacen falta datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }else {

                String sexo = "none";
                if (radioBtnFemenino.Checked)
                {
                    sexo = "Femenino";
                }
                else if (radioBtnMasculino.Checked)
                {
                    sexo = "Masculino";
                }

                Paciente paciente = new Paciente();
                paciente.Nombre = txtboxNombre.Text + " " + txtBoxApePat.Text + " " + txtBoxApeMat.Text;
                paciente.Edad = Convert.ToInt32(comboBoxEdad.Text);
                paciente.Sexo = sexo;
                paciente.Telefono = maskedTextBoxTelefono.Text;//textboxTelefono.Text;
                paciente.Especialidad = comboBoxEspecialidad.Text;
                paciente.Fecha_registro = DateTime.Now;
              
                int resultado = GestionPaciente.Agregar(paciente);
                if (resultado > 0)
                {
                    MessageBox.Show("Registro de paciente exitoso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtboxNombre.ForeColor = Color.Gray;
                    txtboxNombre.Text = "Ej. Juan";
                    //txtBoxApePat.ForeColor = Color.Gray;
                    txtBoxApePat.Text = "Ej. Hernandez";
                   // txtBoxApeMat.ForeColor = Color.Gray;
                    txtBoxApeMat.Text = "Ej. Lopez";
                    //comboBoxEdad.ForeColor = Color.Gray;
                    comboBoxEdad.Text = "Seleccione edad";
                    //maskedTextBoxTelefono.ForeColor = Color.Gray;
                    maskedTextBoxTelefono.Text = "000-000-0000";
                    //comboBoxEspecialidad.ForeColor = Color.Gray;
                    comboBoxEspecialidad.Text = "Seleccione Especialidad";

                }
                else
                {
                    MessageBox.Show("No se pudo hacer el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void txtboxNombre_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text == "Ej. Juan")
            {
                txtboxNombre.Clear();
                txtboxNombre.ForeColor = Color.Black;
            }
        }

        private void txtboxNombre_Leave(object sender, EventArgs e)
        {
            if (txtboxNombre.Text == "")
            {
                txtboxNombre.Text = "Ej. Juan";
                txtboxNombre.ForeColor = Color.Black;
            }
        }

        private void txtBoxApePat_Click(object sender, EventArgs e)
        {
            if (txtBoxApePat.Text == "Ej. Hernandez")
            {
                txtBoxApePat.Clear();
                txtBoxApePat.ForeColor = Color.Black;
            }
            
        }

        private void txtBoxApePat_Leave(object sender, EventArgs e)
        {
            if (txtBoxApePat.Text == "")
            {
                txtBoxApePat.Text = "Ej. Hernandez";
                txtBoxApePat.ForeColor = Color.Black;
            }
        }


        private void txtBoxApeMat_Click(object sender, EventArgs e)
        {
            if (txtBoxApeMat.Text == "Ej. Lopez") { 
                txtBoxApeMat.Clear();
                txtBoxApeMat.ForeColor = Color.Black;
            }
            
        }

        private void txtBoxApeMat_Leave(object sender, EventArgs e)
        {
            if (txtBoxApeMat.Text == "")
            {
                txtBoxApeMat.Text = "Ej. Lopez";
                txtBoxApeMat.ForeColor = Color.Black;
            }
        }

        private void comboBoxEdad_Click(object sender, EventArgs e)
        {
            if (comboBoxEdad.Text == "Seleccione edad")
            {
                comboBoxEdad.ForeColor = Color.Black;
            }

        }

        private void maskedTextBoxTelefono_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxTelefono.Text == "")
            {
                maskedTextBoxTelefono.Clear();
                maskedTextBoxTelefono.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxTelefono.Text == "")
            {
                maskedTextBoxTelefono.ForeColor = Color.Black;
                maskedTextBoxTelefono.Text = "000-000-0000";
            }
        }

        private void comboBoxEspecialidad_Click(object sender, EventArgs e)
        {
            if (comboBoxEspecialidad.Text == "Seleccione especialidad")
            {
                comboBoxEspecialidad.ForeColor = Color.Black;
            }

        }

        private void comboBoxEspecialidad_Leave(object sender, EventArgs e)
        {
            if (comboBoxEspecialidad.Text == "")
            {
                comboBoxEspecialidad.ForeColor = Color.Black;
                comboBoxEspecialidad.Text = "Seleccione especialidad";
            }

        }

        private void txtboxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
            
     }

       /*private void maskedTextBoxID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }*/

    
}
