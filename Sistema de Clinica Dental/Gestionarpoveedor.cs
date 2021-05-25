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
using Sistema_de_Clinica_Dental;

namespace WindowsFormsApplication1
{
    public partial class gestionproveedor : Form
    {

        public string Usuario { get; set; }
        public Proveedor Actualizacion { get; set; }

        public gestionproveedor()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

            if ((maskedTextBoxID.Text == ""  && textBox7.Text == String.Empty && textBox1.Text == "Ingrese nombre de empresa"))
            {
                Vacio.SetError(buscar, "Debe llenar minimo un campo");
                maskedTextBoxID.Focus();

            }
            else
            {
                Vacio.Clear();
                int id;
                String nombre;

                if (maskedTextBoxID.Text == "")
                {
                    id = 0;
                }
                else {
                    id = Convert.ToInt32(maskedTextBoxID.Text.Trim());
                }

                if (textBox1.Text == "")
                {
                    nombre = null;
                }
                else
                {
                    nombre = textBox1.Text.Trim();
                }
                
                MessageBox.Show(id + nombre);
                dataGridView1.DataSource = ProveedorOperaciones.Buscar(id,nombre);
           
                comboBox1.Text = "Seleccionar ";
                maskedTextBoxID.Text = null;
                textBox7.Text = String.Empty;
                textBox1.Text = "Ingrese nombre de empresa";

                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    button3.Enabled = true;
                    buttonModificar.Enabled = true;
                }

            }
        }

        private void gestionproveedor_Load(object sender, EventArgs e)
        {
          
           try
           {
               MySqlConnection conectar = ConexionALaBD.conectar();
               conectar.Open();
               comboBox1.Text = "Seleccionar ";
               comboBox1.Items.Clear();
               ConexionALaBD.conectar();
              
               MySqlCommand seleccion = new MySqlCommand("Select idProveedor from proveedor ", conectar);
               MySqlDataReader almacenar = seleccion.ExecuteReader();
               while (almacenar.Read())
               {
                   comboBox1.Refresh();
                   comboBox1.Items.Add(almacenar.GetValue(0).ToString());
               }
               conectar.Close();
           }
           catch (MySqlException r)
           {
               MessageBox.Show(r.Message);
           }
          
           
        }

        

        private void button1_Click(object sender, EventArgs e) //Mostrar todo
        {
           
            dataGridView1.DataSource = ProveedorOperaciones.Mostrar();
            //dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                button3.Enabled = true;
                buttonModificar.Enabled = true;
            }
        }
        
        
        public Proveedor Seleccion { get; set; }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Vacio.Clear();
               
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Seleccion = ProveedorOperaciones.ObtenerProveedor(id);

                //Se llenan los campos
                textBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxNombreEmp.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                maskedTextBoxTel.Text = Seleccion.Telefono;
                textBoxCalle.Text = Seleccion.Calle;
                maskedTextBoxNumero.Text = Convert.ToString(Seleccion.Numero);
                textBoxColonia.Text = Seleccion.Colonia;
                textBoxEstado.Text = Seleccion.Estado;
                textBoxMunicipio.Text = Seleccion.Municipio;
                maskedTextBoxCP.Text = Seleccion.CP;

               //Se habilitan los campos
                textBoxNombreEmp.Enabled = true;
                maskedTextBoxTel.Enabled = true;
                textBoxCalle.Enabled = true;
                maskedTextBoxNumero.Enabled = true;
                textBoxColonia.Enabled = true;
                textBoxEstado.Enabled = true;
                textBoxMunicipio.Enabled = true;
                maskedTextBoxCP.Enabled = true;
                //Se habilitan los botones
                BotonActualizar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            else
            {

                Vacio.SetError(dataGridView1, "No se ha seleccionado un registro");
                dataGridView1.Focus();
            }
                                     
    
        }
    
        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (error == 0)
            {
                if ( textBoxNombreEmp.Text != String.Empty && maskedTextBoxTel.MaskFull == true && textBoxCalle.Text != String.Empty && maskedTextBoxNumero.Text != "" && textBoxColonia.Text != String.Empty && textBoxEstado.Text != String.Empty && textBoxMunicipio.Text != String.Empty && maskedTextBoxCP.MaskFull == true)
                {
                    Proveedor Proveedor = new Proveedor();

                    Proveedor.Nombre_empresa = textBoxNombreEmp.Text.Trim();
                    Proveedor.Telefono = maskedTextBoxTel.Text;
                    Proveedor.Calle = textBoxCalle.Text.Trim();
                    Proveedor.Numero = Convert.ToInt32(maskedTextBoxNumero.Text.Trim());
                    Proveedor.Colonia = textBoxColonia.Text.Trim();
                    Proveedor.Estado = textBoxEstado.Text.Trim();
                    Proveedor.Municipio = textBoxMunicipio.Text.Trim();
                    Proveedor.CP = maskedTextBoxCP.Text.Trim();
                    Proveedor.idProveedor = Seleccion.idProveedor;


                    if (ProveedorOperaciones.Actualizar(Proveedor) > 0)
                    {
                        MessageBox.Show("Actualización correcta", "Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Mostrar el dato actualizado
                        dataGridView1.DataSource = ProveedorOperaciones.Buscar(Proveedor.idProveedor, null);
                       
                        //Limpiar los campos del formulario
                        textBox2.Text = null;
                        textBoxNombreEmp.Text = null;
                        maskedTextBoxTel.Text = null;
                        textBoxCalle.Text = null;
                        maskedTextBoxNumero.Text = null;
                        textBoxCalle.Text = null;
                        textBoxColonia.Text = null;
                        textBoxEstado.Text = null;
                        textBoxMunicipio.Text = null;
                        maskedTextBoxCP.Text = null;

                        //Deshabilitar los campos del formulario
                        textBox2.Enabled = false;
                        textBoxNombreEmp.Enabled = false;
                        textBoxCalle.Enabled = false;
                        maskedTextBoxNumero.Enabled = false;
                        textBoxCalle.Enabled = false;
                        textBoxColonia.Enabled = false;
                        textBoxEstado.Enabled = false;
                        textBoxMunicipio.Enabled = false;
                        maskedTextBoxCP.Enabled = false;
                        maskedTextBoxTel.Enabled = false;
                        //Deshabilitar boton de actualizar
                        BotonActualizar.Enabled = false;
                    

                    }
                    else
                    {
                        MessageBox.Show("Se ha generado un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
                else
                {

                    MessageBox.Show("Campos vacios", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Faltan modificar campos", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 1)
            {
                Vacio.Clear();

                if (MessageBox.Show("¿Deseas eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ProveedorOperaciones.Eliminar(Seleccion.idProveedor) > 0)
                    {
                        MessageBox.Show("Se eliminó Correctamente!", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = ProveedorOperaciones.Mostrar();

                        /*
                        try
                        {
                            MySqlConnection conectar = ConexionALaBD.conectar();
                            conectar.Open();
                           
                            comboBox1.Text = "Seleccionar ";
                            comboBox1.Items.Clear();
                            ConexionALaBD.conectar();

                            MySqlCommand seleccion = new MySqlCommand("Select idProveedor from proveedor ", conectar);
                            MySqlDataReader almacenar = seleccion.ExecuteReader();
                            while (almacenar.Read())
                            {
                                comboBox1.Refresh();
                                comboBox1.Items.Add(almacenar.GetValue(0).ToString());
                            }
                            conectar.Close();
                        }
                        catch (MySqlException r)
                        {
                            MessageBox.Show(r.Message);
                        }
                        */
                    }
                
                }
            }
            else
            {
               
                button3.Focus();
                Vacio.SetError(buttonModificar, "No se ha seleccionado un registro");
            }

        }


        int error = 0;
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            /*int numero;
            if ((!int.TryParse(textBoxCalle.Text, out numero)) || textBoxCalle.TextLength < 10)
            {
                textBoxCalle.Focus();
                if (!int.TryParse(textBoxCalle.Text, out numero))
                {
                    Vacio.SetError(textBoxCalle, "Deben ser datos numericos");

                }
                else
                {
                    Vacio.SetError(textBoxCalle, "Deben ser 10 digitos");
                }
                error = 1;
            }
            else
            {
                Vacio.Clear();
                error = 0;
            }*/
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (BotonActualizar.Enabled == true)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir de esta ventana?", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    moduloproveedor cambio = new moduloproveedor();
                    cambio.Usuario = Usuario;
                    cambio.Show();
                }
            }
            else
            {

                this.Hide();
                moduloproveedor cambio = new moduloproveedor();
                cambio.Usuario = Usuario;
                cambio.Show();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ingrese nombre de empresa") {
                textBox1.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Ingrese nombre de empresa";
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la modificacion del empleado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //Se limpian los campos
                
                textBox2.Clear();
                textBoxNombreEmp.Clear();
                maskedTextBoxTel.Text = "";
                textBoxCalle.Clear();
                maskedTextBoxNumero.Text = "";
                textBoxColonia.Clear();
                textBoxEstado.Clear();
                textBoxMunicipio.Clear();
                maskedTextBoxCP.Text = "";

                //Deshabilitar campos
                BotonActualizar.Enabled = false;
                textBoxNombreEmp.Enabled = false;
                maskedTextBoxTel.Enabled = false;
                textBoxCalle.Enabled = false;
                maskedTextBoxNumero.Enabled = false;
                textBoxColonia.Enabled = false;
                textBoxEstado.Enabled = false;
                textBoxMunicipio.Enabled = false;
                maskedTextBoxCP.Enabled = false;


                buttonCancelar.Enabled = false;
                BotonActualizar.Enabled = false;
            }
        }

        

        
    }
}
