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

namespace Sistema_de_Clinica_Dental
{
    public partial class FormNuevaCita : Form
    {
        public string Usuario { get; set; }
        public int id { get; set; }


        public FormNuevaCita()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuCita MenuCita = new FormMenuCita();
            MenuCita.id = id;
            MenuCita.Usuario = Usuario;
            MenuCita.Show();
        }

        private void FormNuevaCita_Load(object sender, EventArgs e)
        {
            
            textBoxCita.Text = Convert.ToString(GestionCita.ultimoRegistro()+1);
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerFecha.MinDate = DateTime.Today;

            comboBoxLetras.Items.Insert(0, "Selecciona una letra");
            comboBoxLetras.Items.Insert(1, "A");
            comboBoxLetras.Items.Insert(2, "B");
            comboBoxLetras.Items.Insert(3, "C");
            comboBoxLetras.Items.Insert(4, "D");
            comboBoxLetras.Items.Insert(5, "E");
            comboBoxLetras.Items.Insert(6, "F");
            comboBoxLetras.Items.Insert(7, "G");
            comboBoxLetras.Items.Insert(8, "H");
            comboBoxLetras.Items.Insert(9, "I");
            comboBoxLetras.Items.Insert(10, "J");
            comboBoxLetras.Items.Insert(11, "K");
            comboBoxLetras.Items.Insert(12, "L");
            comboBoxLetras.Items.Insert(13, "M");
            comboBoxLetras.Items.Insert(14, "N");
            comboBoxLetras.Items.Insert(15, "O");
            comboBoxLetras.Items.Insert(16, "P");
            comboBoxLetras.Items.Insert(17, "Q");
            comboBoxLetras.Items.Insert(18, "R");
            comboBoxLetras.Items.Insert(19, "S");
            comboBoxLetras.Items.Insert(20, "T");
            comboBoxLetras.Items.Insert(21, "U");
            comboBoxLetras.Items.Insert(22, "V");
            comboBoxLetras.Items.Insert(23, "W");
            comboBoxLetras.Items.Insert(24, "X");
            comboBoxLetras.Items.Insert(25, "Y");
            comboBoxLetras.Items.Insert(26, "Z");

            //LLENADO DEL COMBOBOX DE PACIENTES
            if (comboBoxLetras.SelectedIndex == -1)
            {
                MySqlConnection conexionP = ConexionALaBD.conectar();
                string sqlP = "SELECT * FROM paciente ORDER BY Nombre ASC";
                MySqlCommand cmdP = new MySqlCommand(sqlP, conexionP);

                MySqlDataAdapter sdaP = new MySqlDataAdapter(cmdP);
                DataTable dtabP = new DataTable();
                sdaP.Fill(dtabP);
                int resultadosP = dtabP.Rows.Count;
                int xP = 0;

                if (dtabP.Rows.Count > 0)
                {
                    while (xP < resultadosP)
                    {
                        comboBoxPaciente.Items.Add(dtabP.Rows[xP][1]);
                        xP = xP + 1;
                    }


                }
                else
                {
                    MessageBox.Show("No hay pacientes registrados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    FormMenuCita frm = new FormMenuCita();
                    frm.Usuario = Usuario;
                    frm.Show();
                }
            }

            //LLENADO DEL COMBOBOX DE DENTISTAS
            MySqlConnection conexionE = ConexionALaBD.conectar();
            string sqlE = "SELECT * FROM empleado  WHERE Perfil = ?perfil";
            MySqlCommand cmdE = new MySqlCommand(sqlE, conexionE);
            cmdE.Parameters.AddWithValue("?perfil", "Dentista");
            MySqlDataAdapter sda = new MySqlDataAdapter(cmdE);
            DataTable dtabE = new DataTable();
            sda.Fill(dtabE);
            int resultados = dtabE.Rows.Count;
            int xE = 0;

            if (dtabE.Rows.Count > 0)
            {
                while (xE < resultados)
                {
                    comboBoxDentista.Items.Add(dtabE.Rows[xE][1]);
                    xE = xE + 1;
                }


            }
            else
            {
                MessageBox.Show("No hay dentistas registrados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                FormMenuCita frm = new FormMenuCita();
                frm.Show();
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (comboBoxPaciente.Text == "Selecciona un Paciente" || comboBoxDentista.Text == "Selecciona un Dentista" || comboBoxConsultorio.Text == "Selecciona un Consultorio")
            {
                MessageBox.Show("faltan campos por llenar","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (comboBoxConsultorio.Text == "Selecciona un Consultorio")
                {
                    comboBoxConsultorio.BackColor = Color.LightGray;
                    comboBoxConsultorio.Focus();
                }
                if (comboBoxDentista.Text == "Selecciona un Dentista")
                {
                    comboBoxDentista.BackColor = Color.LightGray;
                    comboBoxDentista.Focus();
                }
                if (maskedTextBoxHora.MaskFull == false)
                {
                    maskedTextBoxHora.BackColor = Color.LightGray;
                    maskedTextBoxHora.Focus();
                }
                if (comboBoxPaciente.Text == "Selecciona un Paciente")
                {
                    comboBoxPaciente.BackColor = Color.LightGray;
                    comboBoxPaciente.Focus();
                }
            }
            else {
                
                DateTime Fecha = Convert.ToDateTime(dateTimePickerFecha.Text);
                String fecha = Fecha.ToString("yyyy-MM-dd");
                DateTime hora = Convert.ToDateTime(dateTimePickerHora.Text);

                Cita cita = new Cita();
                cita.Paciente = (comboBoxPaciente.Text);
                cita.Fecha = Convert.ToDateTime(dateTimePickerFecha.Text);
                cita.Hora = hora.ToString("hh:mm");
                cita.Dentista = (comboBoxDentista.Text);
                cita.Consultorio = Convert.ToInt32(comboBoxConsultorio.Text.Trim());

                int retorno = GestionCita.Add(cita);

                if (retorno > 0)
                {
                    MessageBox.Show("Cita agendada correctamente", "Agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("No se puede guardar la cita", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //MessageBox.Show("Cita agendada corretamente");
                //PON AQUI LAS COSAS DE LA BASE DE DATOS
                

                comboBoxConsultorio.Text="Selecciona un Consultorio";
                comboBoxDentista.Text ="Selecciona un Dentista";
                maskedTextBoxHora.Text="";
                comboBoxPaciente.Text="Selecciona un Paciente";
                
            }
        }

        private void Registrar_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBoxPaciente_TextChanged(object sender, EventArgs e)
        {
            comboBoxPaciente.ForeColor = Color.Black;
            comboBoxPaciente.BackColor = Color.White;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBoxHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void comboBoxDentista_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDentista.BackColor = Color.White;
            comboBoxDentista.ForeColor = Color.Black;
        }

        private void comboBoxConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxConsultorio.BackColor = Color.White;
            comboBoxConsultorio.ForeColor = Color.Black;
        }

        private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPaciente.ForeColor = Color.Black;
            comboBoxPaciente.BackColor = Color.White;
            
        }

        private void comboBoxPaciente_Leave(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBoxHora_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxHora.ForeColor = Color.Black;
            maskedTextBoxHora.BackColor = Color.White;
        }

        private void comboBoxDentista_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxHora_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxHora.ForeColor = Color.Black;
            maskedTextBoxHora.BackColor = Color.White;
        }

        private void maskedTextBoxHora_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxHora.MaskFull == false)
            {
                maskedTextBoxHora.ForeColor = Color.Gray;
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLetras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLetras.SelectedIndex != 0) {
                
                String letra = comboBoxLetras.Text;
               
                MySqlConnection conexionP = ConexionALaBD.conectar();
                string sqlP = "SELECT * FROM paciente WHERE Nombre LIKE CONCAT(?nom,'%') ORDER BY Nombre ASC";
                MySqlCommand cmdP = new MySqlCommand(sqlP, conexionP);
                cmdP.Parameters.AddWithValue("?nom", letra);
                MySqlDataAdapter sdaP = new MySqlDataAdapter(cmdP);
                DataTable dtabP = new DataTable();
                sdaP.Fill(dtabP);
                int resultadosP = dtabP.Rows.Count;
                int xP = 0;

                if (dtabP.Rows.Count > 0)
                {
                   
                    comboBoxPaciente.Items.Clear();
                    while (xP < resultadosP)
                    {
                        comboBoxPaciente.Items.Add(dtabP.Rows[xP][1]);
                        xP = xP + 1;
                    }

                }
                else 
                {
                    MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxLetras.SelectedIndex = 0;
                    
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hora = Convert.ToDateTime(dateTimePickerHora.Text);
            String hora2 = hora.ToString("hh:mm:ss tt");
            MessageBox.Show(hora2);
        }

        private void comboBoxPaciente_Click(object sender, EventArgs e)
        {
            if (comboBoxLetras.SelectedIndex == 0)
            {
                comboBoxPaciente.Items.Clear();
                MySqlConnection conexion = ConexionALaBD.conectar();
                string sql = "SELECT * FROM paciente ORDER BY Nombre ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dtab = new DataTable();
                sda.Fill(dtab);
                int resultados = dtab.Rows.Count;
                int i = 0;
                if (dtab.Rows.Count > 0)
                {
                    while (i < resultados)
                    {
                        comboBoxPaciente.Items.Add(dtab.Rows[i][1]);
                        i = i + 1;
                    }
                }
            }
        }
    }
}
