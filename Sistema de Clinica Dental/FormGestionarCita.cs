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

namespace Sistema_de_Clinica_Dental
{
    public partial class FormGestionarCita : Form
    {
        public FormGestionarCita()
        {
            InitializeComponent();
        }

        public string Usuario { get; set; }
        Cita citaSeleccionada { set; get; }
        public int id { get; set; }

        private void FromGestionarCita_Load(object sender, EventArgs e)
        {

            //La fecha minima es el dia de hoy
            //dateTimePickerFecha2.MinDate = DateTime.Today;

            //Se llenan el comboBox de acuerdo a los dentista en la BD
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
                    comboBoxDentista1.Items.Add(dtabE.Rows[xE][1]);
                    comboBoxDentista2.Items.Add(dtabE.Rows[xE][1]);
                    xE = xE + 1;
                }
            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            //Se valida si se esta modificando
            if (BtnModificar.Enabled == true)
            {
                //Se pregunta si se desea salir
                DialogResult resultado = MessageBox.Show("¿Estas seguro(a) que deseas salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    FormMenuCita frm = new FormMenuCita();
                    frm.id = id;
                    frm.Usuario = Usuario;
                    frm.Show();
                }
            }
            else
            {
                //Si no se esta modificando se cierra la ventana
                this.Hide();
                FormMenuCita frm = new FormMenuCita();
                frm.id = id;
                frm.Usuario = Usuario;
                frm.Show();
            }
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            //Se llena la tabla con todos los registros.
            dataGridView1.DataSource = GestionCita.buscartodo(); 

            //Validar que no se haya encontrado ningun registro
            if (dataGridView1.RowCount == 0)
            {
                //Mensaje de ningun registro encontrado
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                //Se valida el tipo de usuario que utiliza el sistema
                if (Usuario != "Dentista")
                {
                    Eliminar.Enabled = true;
                    Seleccionar.Enabled = true;
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String fecha;
            int id;
            //Se validan los campos para realizar la búsqueda
            if (maskedTextBoxID.Text == "" && textBoxPaciente1.Text == "Escribe el nombre del paciente" && comboBoxDentista1.Text == "Selecciona un dentista" && maskedTextBoxFecha1.MaskFull==false)
            {
                MessageBox.Show("Por favor ingresa al menos un campo para iniciar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                
                if (maskedTextBoxFecha1.MaskFull == true) //Se valida el campo de fecha
                {
                    //Se le da formato a la fecha
                    DateTime Fecha = Convert.ToDateTime(maskedTextBoxFecha1.Text);
                    fecha = Fecha.ToString("yyyy-MM-dd");
                }
                else {
                    fecha = "0000-00-00";
                }


                if (maskedTextBoxID.Text == "")
                    id = 0;
                else
                    id = Convert.ToInt32(maskedTextBoxID.Text);

                //Se buscan los registros segun el campo.
                dataGridView1.DataSource = GestionCita.buscar(id, textBoxPaciente1.Text, fecha, comboBoxDentista1.Text);

                if (dataGridView1.RowCount == 0) //Se valida si hay registros
                {
                    MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Se valida el tipo de usuario del sistema para habilitar botones.
                    if (Usuario != "Dentista") 
                    {
                        Eliminar.Enabled = true;
                        Seleccionar.Enabled = true;
                    }
                    
                }

            }
            maskedTextBoxID.Clear();
            textBoxPaciente1.Text = "Escribe el nombre del paciente";
            comboBoxDentista1.Text = "Selecciona un dentista";
            maskedTextBoxFecha1.Clear();
        }

        private void dateTimePickerFecha1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxID_Click(object sender, EventArgs e)
        {
            maskedTextBoxID.Clear();
        }

        private void maskedTextBoxID_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxID.Text == "") {
                maskedTextBoxID.Clear();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            DateTime hora = Convert.ToDateTime(dateTimePickerHora.Text);
            
            Cita cita = new Cita();
            cita.ID = citaSeleccionada.ID;
            cita.Paciente = citaSeleccionada.Paciente;
            cita.Fecha = Convert.ToDateTime(dateTimePickerFecha2.Text);
            cita.Hora = hora.ToString("hh:mm");
            cita.Consultorio = Convert.ToInt32(comboBoxConsultorio.Text);
            cita.Dentista = comboBoxDentista2.Text;

            if (GestionCita.Actualizar(cita) > 0)
            {
                MessageBox.Show("Los datos de la cita han sido actualizados.", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible la actualización de datos.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dataGridView1.DataSource = GestionCita.buscar(cita.ID, Convert.ToString(0), "z", Convert.ToString(0));
            
            //Limpiar los campos
            textBox1.Clear();
            maskedTextBoxHora.Clear();
            textBoxPaciente2.Clear();
            comboBoxDentista2.Text = "";
            comboBoxConsultorio.Text = "";
            maskedTextBoxHora.Clear();

            //Deshabilitan los campos
            textBox1.Enabled = false;
            maskedTextBoxHora.Enabled = false;
            textBoxPaciente2.Enabled = false;
            comboBoxDentista2.Enabled = false;
            comboBoxConsultorio.Enabled = false;
            dateTimePickerFecha2.Enabled = false;

            //Se habilita el boton
            BtnModificar.Enabled = false;
           
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
               
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    citaSeleccionada = GestionCita.ObtenerCita(id);
                    if (citaSeleccionada.Fecha < DateTime.Today)
                    {
                        MessageBox.Show("La cita no puede ser eliminada. Ya fue atendida");
                    }
                    else
                    {

                        int eliminado = GestionCita.Eliminar(citaSeleccionada.ID);
                        if (eliminado > 0)
                        {
                            MessageBox.Show("Registro eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = GestionCita.buscartodo();
                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (eliminado == -1)
                        {
                            MessageBox.Show("No es posible eliminar la cita", "Problemas para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = GestionCita.buscartodo();
                        }
                    }
                }

            }
            else
                MessageBox.Show("Debe de seleccionar un registro");
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                citaSeleccionada = GestionCita.ObtenerCita(id);

                if (citaSeleccionada.Fecha < DateTime.Today)
                {
                    MessageBox.Show("La cita no puede modificada. Ya fue atendida", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (citaSeleccionada != null)
                    {
                        //Se mandan los datos a los campos
                        textBox1.Text = Convert.ToString(citaSeleccionada.ID);
                        textBoxPaciente2.Text = citaSeleccionada.Paciente;
                        dateTimePickerFecha2.Text = Convert.ToString(citaSeleccionada.Fecha);
                        dateTimePickerHora.Text = Convert.ToString(citaSeleccionada.Hora);
                        comboBoxDentista2.Text = citaSeleccionada.Dentista;
                        comboBoxConsultorio.Text = Convert.ToString(citaSeleccionada.Consultorio);
                        dateTimePickerHora.ShowUpDown = true;

                        //Se habilitan los campos
                        comboBoxDentista2.Enabled = true;
                        comboBoxConsultorio.Enabled = true;
                        dateTimePickerFecha2.Enabled = true;
                        dateTimePickerHora.Enabled = true;

                        //Se habilitan los botones
                        BtnModificar.Enabled = true;
                        buttonCancelar.Enabled = true;
                    }
                }
            }
            else
                MessageBox.Show("Debe de seleccionar un registro");
        }

        private void textBoxPaciente1_Click(object sender, EventArgs e)
        {
            textBoxPaciente1.Clear();
        }

        private void textBoxPaciente1_Leave(object sender, EventArgs e)
        {
            if (textBoxPaciente1.Text == "") {
                textBoxPaciente1.Text = "Escribe el nombre del paciente";
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la modificacion de la cita?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) { 
                //limpiar los campos
                textBox1.Clear();
                textBoxPaciente2.Clear();
                comboBoxDentista2.Text ="";
                comboBoxConsultorio.Text = "";

                //bloquear los campos
                textBox1.Enabled = false;
                textBoxPaciente2.Enabled = false;
                dateTimePickerFecha2.Enabled = false;
                dateTimePickerHora.Enabled = false;
                comboBoxDentista2.Enabled = false;
                comboBoxConsultorio.Enabled = false;

                //bloquear botones de cancelar y actualizar
                buttonCancelar.Enabled = false;
                BtnModificar.Enabled = false;

            }
        }


    }
}
