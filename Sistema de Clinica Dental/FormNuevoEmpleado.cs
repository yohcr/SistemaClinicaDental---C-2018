using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Clinica_Dental
{
    public partial class FormNuevoEmpleado : Form
    {
        int bandera = 1;
        public String Usuario { set; get; }
        public FormNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuEmpleado frm = new FormMenuEmpleado();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Ejemplo: Jose Luis Rendon Avila" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "Selecciona un Perfil" || comboBoxArea.Text == "Selecciona un Area" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
                {
                    bandera = 0;
                }
                else
                {
                    if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                    {
                        bandera = 0;
                    }
                    else
                    {
                        bandera = 1;
                    }
                }
            textBoxNombre.ForeColor = Color.Black;
            textBoxNombre.BackColor = Color.White;
        }

        /*private void maskedTextBoxEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            {
                if (textBoxNombre.Text == "" || maskedTextBoxEdad.Text == "" | comboBoxPerfil.Text == "" || comboBoxArea.Text == "" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
                {
                    bandera = 0;
                }
                else
                {
                    if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                    {
                        bandera = 0;
                    }
                    else
                    {
                        bandera = 1;
                    }
                }
            }
        }*/

        private void comboBoxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Ejemplo: Jose Luis Rendon Avila" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "Selecciona un Perfil" || comboBoxArea.Text == "Selecciona un Area" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
            {
                bandera = 0;
            }
            else
            {
                if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                {
                    bandera = 0;
                }
                else
                {
                    bandera = 1;
                }
            }
            comboBoxPerfil.ForeColor = Color.Black;
            comboBoxPerfil.BackColor = Color.White;
        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (textBoxNombre.Text == "" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "" || comboBoxArea.Text == "" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
                {
                    bandera = 0;
                }
                else
                {
                    if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                    {
                        bandera = 0;
                    }
                    else
                    {
                        bandera = 1;
                    }
                }
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBoxNombre.Text == "Ejemplo: Jose Luis Rendon Avila" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "Selecciona un Perfil" || comboBoxArea.Text == "Selecciona un Area" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
                {
                    bandera = 0;
                }
                else
                {
                    if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                    {
                        bandera = 0;
                    }
                    else
                    {
                        bandera = 1;
                    }
                }
                textBoxUsuario.ForeColor = Color.Black;
                textBoxUsuario.BackColor = Color.White;
            }
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Ejemplo: Jose Luis Rendon Avila" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "Selecciona un Perfil" || comboBoxArea.Text == "Selecciona un Area" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
            {
                bandera = 0;
            }
            else
            {
                if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                {
                    bandera = 0;
                }
                else
                {
                    bandera = 1;
                }
            }
            textBoxContraseña.ForeColor = Color.Black;
            textBoxContraseña.BackColor = Color.White;
        }

        private void FormNuevoEmpleado_Load(object sender, EventArgs e)
        {
            textBoxID.Text = Convert.ToString(GestionEmpleado.ultimoRegistro()+1);
            
            bandera = 0;
            dateTimePickerFecha.Enabled = false;
            //MessageBox.Show(Usuario);
        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (textBoxNombre.Text == "" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "" || comboBoxArea.Text == "" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
                {
                    bandera = 0;
                }
                else
                {
                    if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                    {
                        bandera = 0;
                    }
                    else
                    {
                        bandera = 1;
                    }
                }
            }
        }

        private void radioButtonFemenino_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (textBoxNombre.Text == "" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "" || comboBoxArea.Text == "" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
                {
                    bandera = 0;
                }
                else
                {
                    if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                    {
                        bandera = 0;
                    }
                    else
                    {
                        bandera = 1;
                    }
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
            {
                MessageBox.Show("Error, faltan campos por llenar");
                if (textBoxContraseña.Text == "")
                {
                    textBoxContraseña.BackColor = Color.LightGray;
                    textBoxContraseña.Focus();
                }
                if (textBoxUsuario.Text == "")
                {
                    textBoxUsuario.BackColor = Color.LightGray;
                    textBoxUsuario.Focus();
                }
                if (comboBoxArea.Text == "Selecciona un Area")
                {
                    comboBoxArea.BackColor = Color.LightGray;
                    comboBoxArea.Focus();
                }

                if (comboBoxPerfil.Text == "Selecciona un Perfil")
                {
                    comboBoxPerfil.BackColor = Color.LightGray;
                    comboBoxPerfil.Focus();
                }
                if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                {
                    radioButtonFemenino.BackColor = Color.LightGray;
                    radioButtonMasculino.BackColor = Color.LightGray;
                }
                if (comboBoxEdad.Text == "Selecciona edad")
                {
                    comboBoxEdad.BackColor = Color.LightGray;
                    comboBoxEdad.Focus();
                }
                if (textBoxNombre.Text == "Ejemplo: Jose Luis Rendon Avila")
                {
                    textBoxNombre.BackColor = Color.LightGray;
                    textBoxNombre.Focus();
                }
            }
            else {
                int band = 1;
                //ConexionALaBD.conectar();
                //MessageBox.Show("Wow, si esto estuviera programado ya, podrias registrar tu empleado :3");
                Empleado empleado = new Empleado();
                empleado.Nombre = textBoxNombre.Text.Trim();
                try
                {
                    empleado.Edad = Convert.ToInt32(comboBoxEdad.Text);
                }
                catch (Exception) {
                    MessageBox.Show("La edad no fue introducida correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    band = 0;
                }
                if (radioButtonFemenino.Checked == true)
                {
                    empleado.Sexo = "Femenino";
                }
                else {
                    empleado.Sexo = "Masculino";
                }
                empleado.Fecha = DateTime.Now;
                empleado.Perfil = comboBoxPerfil.Text.Trim();
                empleado.Area = comboBoxArea.Text.Trim();
                empleado.Usuario = textBoxUsuario.Text.Trim();
                empleado.Contraseña = textBoxContraseña.Text.Trim();
                int retorno = -1;
                if (band == 1)
                {
                    retorno = GestionEmpleado.Add(empleado);
                }
                if (retorno > 0)
                {
                    MessageBox.Show("Empleado registdo correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede guardar el empleado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                textBoxNombre.Text = "Ejemplo: Jose Luis Rendon Avila";
                comboBoxEdad.Text = "Selecciona Edad";
                radioButtonMasculino.Checked = false;
                radioButtonFemenino.Checked = false;
                comboBoxPerfil.Text = "Selecciona un Perfil";
                comboBoxArea.Text = "Selecciona un Area";
                textBoxUsuario.Text = "";
                textBoxContraseña.Text = "";
            }
        }

        private int Cint(string p)
        {
            throw new NotImplementedException();
        }

        private void textBoxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNombre.BackColor = Color.White;
            textBoxNombre.Text = "";
            textBoxNombre.ForeColor = Color.Black;
        }

       /*private void maskedTextBoxEdad_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxEdad.BackColor = Color.White;
            maskedTextBoxEdad.Text = "";
            maskedTextBoxEdad.ForeColor = Color.Black;
        }*/

        private void radioButtonMasculino_Click(object sender, EventArgs e)
        {
            radioButtonMasculino.BackColor = Color.White;
            radioButtonFemenino.BackColor = Color.White;
        }

        private void radioButtonFemenino_Click(object sender, EventArgs e)
        {
            radioButtonMasculino.BackColor = Color.White;
            radioButtonFemenino.BackColor = Color.White;
        }

        private void comboBoxPerfil_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxPerfil.BackColor = Color.White;
            comboBoxPerfil.ForeColor = Color.Black;
        }

        private void comboBoxArea_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxArea.BackColor = Color.White;
            comboBoxArea.ForeColor = Color.Black;
        }

        private void textBoxContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxContraseña.BackColor = Color.White;
        }

        private void comboBoxEdad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdad_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxEdad.BackColor = Color.White;
            comboBoxEdad.ForeColor = Color.Black;
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                textBoxNombre.Text = "Ejemplo: Jose Luis Rendon Avila";
                
            }
            else {
                textBoxNombre.ForeColor = Color.Black;
                textBoxNombre.BackColor = Color.White;
            }
        }

        private void comboBoxEdad_Leave(object sender, EventArgs e)
        {
            if (comboBoxEdad.Text == "") {
                comboBoxEdad.Text = "Selecciona edad";
                
            }
        }

        private void comboBoxPerfil_Leave(object sender, EventArgs e)
        {
            if (comboBoxPerfil.Text == "") {
                comboBoxPerfil.Text = "Selecciona un Perfil";
                
            }
        }

        private void comboBoxArea_Leave(object sender, EventArgs e)
        {
            if (comboBoxArea.Text == "") {
                comboBoxArea.Text = "Selecciona un Area";
                
            }
        }

        private void textBoxUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxUsuario.ForeColor = Color.Black;
            textBoxUsuario.BackColor = Color.White;
        }

        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {

        }

        private void comboBoxEdad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Ejemplo: Jose Luis Rendon Avila" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "Selecciona un Perfil" || comboBoxArea.Text == "Selecciona un Area" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
            {
                bandera = 0;
            }
            else
            {
                if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                {
                    bandera = 0;
                }
                else
                {
                    bandera = 1;
                }
            }
            comboBoxEdad.ForeColor = Color.Black;
            comboBoxEdad.BackColor = Color.White;
        }

        private void comboBoxArea_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Ejemplo: Jose Luis Rendon Avila" || comboBoxEdad.Text == "" | comboBoxPerfil.Text == "Selecciona un Perfil" || comboBoxArea.Text == "Selecciona un Area" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "")
            {
                bandera = 0;
            }
            else
            {
                if (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false)
                {
                    bandera = 0;
                }
                else
                {
                    bandera = 1;
                }
            }
            comboBoxArea.ForeColor = Color.Black;
            comboBoxArea.BackColor = Color.White;
        }

        private void comboBoxEdad_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        /*private void textBoxNombre_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "") {
                textBoxNombre.Text = "Jose Luis Rendo Avila";
                textBoxNombre.ForeColor = Color.Gray;
            }
        }*/
    }
}
//maskedTextBoxEdad