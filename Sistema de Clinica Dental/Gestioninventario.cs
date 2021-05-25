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
    public partial class gestióndeinventario : Form
    {
        public gestióndeinventario()
        {
            InitializeComponent();
        }
        public string Usuario { get; set; }
  
        //MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database= mydb; uid=root; pwd=;Port=3307");
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        
        private void gestióndeinventario_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);

            MySqlConnection conexionE = ConexionALaBD.conectar();
            conexionE.Open();
            string sqlE = "SELECT Nombre_empresa FROM proveedor ";
            MySqlCommand cmdE = new MySqlCommand(sqlE, conexionE);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmdE);
            DataTable dtabE = new DataTable();
            sda.Fill(dtabE);
            int resultados = dtabE.Rows.Count;
            int xE = 0;

            if (dtabE.Rows.Count > 0)
            {
                while (xE < resultados)
                {
                    comboBox3.Items.Add(dtabE.Rows[xE][0]);
                    xE = xE + 1;
                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text =="" && textBox7.Text == "Ingrese nombre del producto" && comboBox1.Text == "Seleccione categoría" )
            {
                MessageBox.Show("Ingresa un dato para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String nombre,categoria;
                int id;
                if (maskedTextBox1.Text == "")
                {
                    id = 0;
                }
                else
                {
                    id = Convert.ToInt32(maskedTextBox1.Text);
                }

                if (textBox7.Text == "Ingrese nombre del producto")
                {
                    nombre = null;
                }
                else
                {
                    nombre = textBox7.Text.Trim();
                }

                if (comboBox1.Text == "Seleccione categoría")
                {
                    categoria = null;
                }
                else
                {
                    categoria = comboBox1.Text;
                }

                dataGridView1.DataSource = InventarioOperaciones.Buscar(id, nombre, categoria);

                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Usuario != "Dentista")
                    {
                        Seleccionar.Enabled = true;
                        Eliminar.Enabled = true;
                    }
                }

                maskedTextBox1.Clear();
                textBox7.Text = "Ingrese nombre del producto";
                comboBox1.Text = "Seleccione categoría";

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InventarioOperaciones.Mostrar();
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Usuario != "Dentista")
                {
                   Seleccionar.Enabled = true;
                   Eliminar.Enabled = true;
                }
            }
        }
        public Inventario Seleccion { get; set; }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Seleccion = InventarioOperaciones.ObtenerInventario(id);

                if (Seleccion != null)
                {
                    numericUpDown2.Minimum = 0;
                    //Mandar datos a campos
                    textBox2.Text = Convert.ToString(Seleccion.idMaterial);
                    textBox3.Text = Seleccion.Nombre_producto;
                    comboBox4.Text = Seleccion.Categoria;
                    comboBox3.Text = Convert.ToString(Seleccion.Proveedor);
                    textBox6.Text = Seleccion.Descripcion;
                    numericUpDown1.Text = Convert.ToString(Seleccion.Cantidad);
                    numericUpDown2.Text = Convert.ToString( 0);
                    //textBox2.Enabled = true;
                    //Habilitar campos
                    textBox3.Enabled = true;
                    comboBox4.Enabled = true;
                    comboBox3.Enabled = true;
                    textBox6.Enabled = true;
                    numericUpDown2.Enabled = true;
                    button3.Enabled = true;
                    Actualizar.Enabled = true;
             
                }
            }
            else
                MessageBox.Show("Debe de seleccionar un registro");        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {

            if (textBox3.Text != String.Empty && comboBox4.Text != String.Empty && comboBox3.Text != String.Empty && textBox6.Text != String.Empty && numericUpDown2.Text != String.Empty)
            {

                int cant;
                cant = Convert.ToInt32(numericUpDown1.Text) + Convert.ToInt32(numericUpDown2.Text);
                Inventario inventario = new Inventario();
                inventario.idMaterial = Seleccion.idMaterial;
                inventario.Nombre_producto = textBox3.Text.Trim();
                inventario.Categoria = comboBox4.Text.Trim();
                inventario.Proveedor = comboBox3.Text;
                inventario.Descripcion = textBox6.Text.Trim();
                inventario.Cantidad = cant;
                inventario.idMaterial = Seleccion.idMaterial;
                if (InventarioOperaciones.Actualizar(inventario) > 0)
                {
                    MessageBox.Show("Los datos del producto han sido actualizados.", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible la actualización de datos.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                //limpiar campos
                textBox2.Clear();
                textBox3.Clear();
                textBox6.Clear();
                comboBox4.Text = "";
                comboBox3.Text = "";
                numericUpDown1.Text = "";
                numericUpDown2.Text = "";
                //Deshabilitar
                numericUpDown1.Text = null;
                textBox6.Text = null;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox3.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                textBox6.Enabled = false;

                button3.Enabled = false;
                Actualizar.Enabled = false;

                dataGridView1.DataSource = InventarioOperaciones.Buscar(inventario.idMaterial, null, null);
            }
            else {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         
          

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    Seleccion = InventarioOperaciones.ObtenerInventario(id);
                    
                        MessageBox.Show("Registro eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = InventarioOperaciones.Mostrar();
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
               
                }

            }
            else
                MessageBox.Show("Debe de seleccionar un registro");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Actualizar.Enabled == true)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir de esta ventana?", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    moduloinventario cambio = new moduloinventario();
                    cambio.Usuario = Usuario;
                    cambio.Show();
                }
            }
            else
            {
                this.Hide();
                moduloinventario cambio = new moduloinventario();
                cambio.Usuario = Usuario;
                cambio.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la modificacion del paciente?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {

                textBox2.Clear();
                textBox3.Clear();
                comboBox4.Text = "Seleccionar ";
                comboBox3.Text = "Seleccionar ";
                numericUpDown1.Text = null;
                textBox6.Text = null;

                textBox2.Enabled = false;
                textBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox3.Enabled = false;
                numericUpDown1.Enabled = false;
                textBox6.Enabled = false;

                button3.Enabled = false;
                Actualizar.Enabled = false;
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "Ingrese nombre del producto")
                textBox7.Clear();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
                textBox7.Text = "Ingrese nombre del producto";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
