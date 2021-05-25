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
    public partial class FormGestionarEmpleado : Form
    {
        public String Usuario { set; get; }
        Empleado empleadoSeleccionado { set; get; }

        public FormGestionarEmpleado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            //Se valida si se esta modificando
            if (BtnActualizar.Enabled == true) { //Se pregunta si desea salir
                DialogResult resultado = MessageBox.Show("¿Estas seguro(a) que deseas salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    FormMenuEmpleado frm = new FormMenuEmpleado();
                    frm.Usuario = Usuario;
                    frm.Show();
                }
            
            } else
             {  //Se cierra la venta si no se esta modificando
                 this.Hide();
                 FormMenuEmpleado frm = new FormMenuEmpleado();
                 frm.Usuario = Usuario;
                 frm.Show();
             }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxID1.Text == "" && textBoxNombre1.Text == "Ingrese nombre de empleado" && comboBoxArea1.Text == "Seleccione area")
            {
                MessageBox.Show("Por favor ingresa al menos un campo para iniciar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //dataGridView1.DataSource = GestionEmpleado.buscartodo();
            }
            else {
                int id;

                if (maskedTextBoxID1.Text == "")
                {
                    id = 0;
                    
                }
                else {
                    id = Convert.ToInt32(maskedTextBoxID1.Text);
                    
                }

                dataGridView1.DataSource = GestionEmpleado.buscar(id, textBoxNombre1.Text.Trim(), comboBoxArea1.Text);
                maskedTextBoxID1.Clear();
                textBoxNombre1.Text = "Ingrese nombre de empleado";
                comboBoxArea1.Text = "Seleccione area";

                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    BtnSelect.Enabled = true;
                    BtnEliminar.Enabled = true;
                }
                
            }
            
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GestionEmpleado.buscartodo();
            BtnSelect.Enabled = true;
            BtnEliminar.Enabled = true;
            maskedTextBoxID1.Clear();
            textBoxNombre1.Text = "Ingrese nombre de empleado";
            comboBoxArea1.Text = "Seleccione area";
        }
        Empleado Seleccion { get; set; }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dateTimePickerFecha.Enabled = false;

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Seleccion = GestionEmpleado.ObtenerEmpleado(id);

                if (Seleccion != null)
                {
                    textBoxNombre2.Text = Seleccion.Nombre;
                    maskedTextBoxEdad.Text = Convert.ToString(Seleccion.Edad);
                    if (Seleccion.Sexo == "Masculino")
                    {
                        radioButtonMasculino.Checked = true;
                    }
                    else
                    {
                        radioButtonFemenino.Checked = true;
                    }

                    //Mandar datos a campos
                    textBox1.Text = Convert.ToString(Seleccion.ID);
                    dateTimePickerFecha.Value = Seleccion.Fecha;
                    comboBoxPerfil.Text = Seleccion.Perfil;
                    comboBoxArea2.Text = Seleccion.Area;
                    textBoxUsuario.Text = Seleccion.Usuario;
                    textBoxContraseña.Text = Seleccion.Contraseña;
                    //Habilitar campos
                    textBoxNombre2.Enabled = true;
                    radioButtonMasculino.Enabled = true;
                    radioButtonFemenino.Enabled = true;
                    maskedTextBoxEdad.Enabled = true;
                    comboBoxPerfil.Enabled = true;
                    comboBoxArea2.Enabled = true;
                    textBoxUsuario.Enabled = true;
                    textBoxContraseña.Enabled = true;
                    //Habilitar botones
                    BtnActualizar.Enabled = true;
                    buttonCancelar.Enabled = true;
                }
            }
            else {
                MessageBox.Show("Debes seleccionar todo el registro para modificarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre2.Text == string.Empty || maskedTextBoxEdad.Text == "" || (radioButtonFemenino.Checked == false && radioButtonMasculino.Checked == false) || comboBoxPerfil.Text == String.Empty || comboBoxArea2.Text == String.Empty || textBoxUsuario.Text == String.Empty || textBoxContraseña.Text == String.Empty)
            {
                MessageBox.Show("Hacen falta datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Empleado empleado = new Empleado();
                empleado.Nombre = textBoxNombre2.Text.Trim();
                empleado.Edad = Convert.ToInt32(maskedTextBoxEdad.Text);
                if (radioButtonFemenino.Checked == true)
                {
                    empleado.Sexo = "Femenino";
                }
                else
                {
                    empleado.Sexo = "Masculino";
                }

                empleado.Fecha = Seleccion.Fecha;
                empleado.Perfil = comboBoxPerfil.Text;
                empleado.Area = comboBoxArea2.Text;
                empleado.Usuario = textBoxUsuario.Text;
                empleado.Contraseña = textBoxContraseña.Text;
                empleado.ID = Seleccion.ID;
                if (GestionEmpleado.Actualizar(empleado) > 0)
                {
                    MessageBox.Show("Los datos del empleado han sido actualizados", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos del empleado No se actualizaron", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                textBoxNombre2.Clear();
                maskedTextBoxEdad.Clear();
                textBox1.Clear();
                radioButtonFemenino.Checked = false;
                radioButtonMasculino.Checked = false;
                comboBoxPerfil.Text = "";
                comboBoxArea2.Text = "";
                textBoxUsuario.Clear();
                textBoxContraseña.Clear();
                textBoxNombre2.Enabled = false;
                radioButtonMasculino.Enabled = false;
                radioButtonFemenino.Enabled = false;
                maskedTextBoxEdad.Enabled = false;
                dateTimePickerFecha.Enabled = false;
                comboBoxPerfil.Enabled = false;
                comboBoxArea2.Enabled = false;
                textBoxUsuario.Enabled = false;
                textBoxContraseña.Enabled = false;
                BtnActualizar.Enabled = false;
                dataGridView1.DataSource = GestionEmpleado.buscar(empleado.ID, null, null);
                //dataGridView1.DataSource = GestionEmpleado.buscar((Convert.ToInt32(maskedTextBoxID1.Text)), textBoxNombre1.Text, comboBoxArea1.Text);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult resp = MessageBox.Show("¿Seguro que quiere eliminar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    int eliminacion = 0;
                    eliminacion = GestionEmpleado.Eliminar(id);
                    if (eliminacion > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridView1.DataSource = GestionEmpleado.buscartodo();
                        //dataGridView1.DataSource = GestionEmpleado.buscartodo();

                    }
                    else if(eliminacion == -1)
                    {
                        MessageBox.Show("El dentista tiene cita(s) registradas. ", "Problemas para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridView1.DataSource = GestionEmpleado.buscartodo();
                    }
                }
                else {
                    dataGridView1.DataSource = GestionEmpleado.buscartodo();
                }
                
                maskedTextBoxID1.Text = "";
                textBoxNombre1.Text = "";
                comboBoxArea1.Text = "";

                textBoxNombre2.Text = "";
                comboBoxEdad.Text = "";
                radioButtonFemenino.Checked = false;
                radioButtonMasculino.Checked = false;
                comboBoxPerfil.Text = "";
                comboBoxArea2.Text = "";
                textBoxUsuario.Text = "";
                textBoxContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Debes seleccionar todo el registro para Eliminarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FormGestionarEmpleado_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNombre1.Clear();
        }

        private void textBoxNombre1_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre1.Text == "") {
                textBoxNombre1.Text = "Ingrese nombre de empleado";
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la modificacion del empleado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //Se limpian los campos
                textBoxNombre2.Clear();
                maskedTextBoxEdad.Clear();
                textBox1.Clear();  
                comboBoxPerfil.Text = "";
                comboBoxArea2.Text = "";
                textBoxUsuario.Clear();
                textBoxContraseña.Clear();

                //Deshabilitar campos
                textBoxNombre2.Enabled = false;
                radioButtonMasculino.Enabled = false;
                radioButtonFemenino.Enabled = false;
                maskedTextBoxEdad.Enabled = false;
                comboBoxPerfil.Enabled = false;
                comboBoxArea2.Enabled = false;
                textBoxUsuario.Enabled = false;
                textBoxContraseña.Enabled = false;
                buttonCancelar.Enabled = false;
                BtnActualizar.Enabled = false;
            }
        }
    }
}
