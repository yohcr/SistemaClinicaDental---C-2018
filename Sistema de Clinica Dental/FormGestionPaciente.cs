using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormGestionPaciente : Form
    {
        public FormGestionPaciente()
        {
            InitializeComponent();
        }
        public string Usuario { get; set; }
        public int id { get; set; }


        Paciente pacienteSeleccionado { set; get ;}

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(maskedTextBoxID.Text == "" && textBoxNombre.Text == "Ingrese nombre del paciente" && comboBoxSexo1.Text == "Seleccione sexo" && comboBoxEspecialidad.Text == "Seleccione especialidad")
            {
                MessageBox.Show("Ingresa un dato para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                String nombre, sexo, esp;
                int id;
                if (maskedTextBoxID.Text == "")
                {
                    id = 0;
                }
                else
                {
                    id = Convert.ToInt32(maskedTextBoxID.Text);
                }

                if (textBoxNombre.Text == "Ingrese nombre del paciente")
                {
                    nombre = null;
                }
                else {
                    nombre = textBoxNombre.Text.Trim();
                }

                if (comboBoxEspecialidad.Text == "Seleccione especialidad") {
                    esp = null;
                }
                else
                {
                    esp = comboBoxEspecialidad.Text;
                }

                if (comboBoxSexo1.Text == "Seleccione sexo")
                {
                    sexo = null;
                }
                else {
                    sexo = comboBoxSexo1.Text;
                }
                
                dataGridViewPaciente.DataSource = GestionPaciente.Buscar(id, nombre, sexo, esp);

                if (dataGridViewPaciente.RowCount == 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    if (Usuario != "Dentista")
                    {
                        BtnSeleccionar.Enabled = true;
                        BtnEliminar.Enabled = true;
                    }
                }

                maskedTextBoxID.Clear();
                //textBoxID.Text = "#";
                textBoxNombre.Text = "Ingrese nombre del paciente";
                comboBoxSexo1.Text="Seleccione sexo";
                comboBoxEspecialidad.Text="Seleccione especialidad";
                
            }
            
        }

        private void FormGestionPaciente_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if ( dataGridViewPaciente.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridViewPaciente.CurrentRow.Cells[0].Value);
                pacienteSeleccionado = GestionPaciente.ObtenerPaciente(id);

                if (pacienteSeleccionado != null) {
                    textBoxID.Text = Convert.ToString(pacienteSeleccionado.Id);
                    textBoxNombre2.Text = pacienteSeleccionado.Nombre;
                    maskedTextBoxEdad.Text = Convert.ToString(pacienteSeleccionado.Edad);
                    maskedTextBoxTelefono.Text = pacienteSeleccionado.Telefono;
                    comboBoxEspecialidad2.Text = pacienteSeleccionado.Especialidad;

                    textBoxNombre2.Enabled = true;
                    maskedTextBoxEdad.Enabled = true;
                    if (pacienteSeleccionado.Sexo == "Masculino")
                    {
                        radioButtonMasculino.Checked = true;
                    }
                    else
                    {
                        radioButtonFemenino.Checked = true;
                    }

                    radioButtonFemenino.Enabled = true;
                    radioButtonMasculino.Enabled = true;
                    maskedTextBoxTelefono.Enabled = true;
                    comboBoxEspecialidad2.Enabled = true;
                    BtnGuardar.Enabled = true;
                    BtnCancelar.Enabled = true;
                }
            }
            else
                MessageBox.Show("Debe de seleccionar un registro");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre2.Text == String.Empty || maskedTextBoxEdad.Text == "" || maskedTextBoxTelefono.MaskFull == false || comboBoxEspecialidad2.Text == String.Empty)
            {
                MessageBox.Show("Hacen falta datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Paciente paciente = new Paciente();
                paciente.Id = pacienteSeleccionado.Id;
                paciente.Nombre = textBoxNombre2.Text.Trim();
                paciente.Edad = Convert.ToInt32(maskedTextBoxEdad.Text);
                if (radioButtonMasculino.Checked == true)
                {
                    paciente.Sexo = "Masculino";
                }
                else
                {
                    paciente.Sexo = "Femenino";
                }
                
                paciente.Telefono = maskedTextBoxTelefono.Text;//textboxTelefono.Text;
                paciente.Especialidad = comboBoxEspecialidad2.Text;

                if (GestionPaciente.Actualizar(paciente) > 0)
                {
                    MessageBox.Show("Los datos del paciente han sido actualizados.", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible la actualización de datos.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                //Se limpian campos
                textBoxNombre2.Clear();
                maskedTextBoxEdad.Clear();
                comboBoxSexo.Text = "";
                maskedTextBoxTelefono.Clear();
                comboBoxEspecialidad2.Text = "";
                //Se muestra el registro actualizado
                dataGridViewPaciente.DataSource = GestionPaciente.Buscar(paciente.Id, null, null, null);
                //Se bloquean botones y campos
                radioButtonFemenino.Enabled = true;
                radioButtonMasculino.Enabled = true;
                textBoxNombre2.Enabled = false;
                maskedTextBoxEdad.Enabled = false;
                comboBoxSexo.Enabled = false;
                maskedTextBoxTelefono.Enabled = false;
                comboBoxEspecialidad2.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnGuardar.Enabled = false;
                textBoxID.Clear();

            }
        }

        private void BtnBuscarTodos_Click(object sender, EventArgs e)
        {
            dataGridViewPaciente.DataSource = GestionPaciente.BuscarTodos();
            if (dataGridViewPaciente.RowCount == 0)
            {
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Usuario != "Dentista")
                {
                    BtnSeleccionar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Se valida si se esta modificando
            if (BtnGuardar.Enabled == true)
            {   //Se pregunta si desea salir
                DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    FormPaciente menuPaciente = new FormPaciente();
                    menuPaciente.id = id;
                    menuPaciente.Usuario = Usuario;
                    menuPaciente.Show();
                }
            }
            else
            {
                //Cierra la ventana si no esta modificando
                this.Hide();
                FormPaciente menuPaciente = new FormPaciente();
                menuPaciente.id = id;
                menuPaciente.Usuario = Usuario;
                menuPaciente.Show();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la modificacion del paciente?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                textBoxID.Clear();
                textBoxNombre2.Clear();
                maskedTextBoxEdad.Clear();
                comboBoxSexo.Text = "";
                maskedTextBoxTelefono.Clear();
                comboBoxEspecialidad2.Text = "";

                textBoxNombre2.Enabled = false;
                maskedTextBoxEdad.Enabled = false;
                comboBoxSexo.Enabled = false;
                maskedTextBoxTelefono.Enabled = false;
                comboBoxEspecialidad2.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnGuardar.Enabled = false;
                
            }
        }

        private void maskedTextBoxID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBoxID_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBoxID_Leave(object sender, EventArgs e)
        {
            

        }

        private void comboBoxSexo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPaciente.SelectedRows.Count == 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el registro?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewPaciente.CurrentRow.Cells[0].Value);
                    pacienteSeleccionado = GestionPaciente.ObtenerPaciente(id);
                    int eliminado = GestionPaciente.Eliminar(pacienteSeleccionado);
                    if (eliminado > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewPaciente.DataSource = GestionPaciente.BuscarTodos();
                        if (dataGridViewPaciente.RowCount == 0)
                        {
                            MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if(eliminado == -1){
                        MessageBox.Show("El paciente tiene cita(s) registrada(s)", "Problemas para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewPaciente.DataSource = GestionPaciente.BuscarTodos();
                        
                    }
                }
                                
            }
            else
                MessageBox.Show("Debe de seleccionar un registro");
        }

        
        private void textBoxNombre_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
                textBoxNombre.Text = "Ingrese nombre del paciente";
        }
    }
}
