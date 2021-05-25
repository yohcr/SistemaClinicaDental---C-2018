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
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class nuevoproducto : Form
    {
        public string Usuario { get; set; }
        public nuevoproducto()
        {
            InitializeComponent();
        }
       // MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database= mydb; uid=root; pwd=;Port=3307");
        
        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
            maskedTextBox1.Text = Convert.ToString(InventarioOperaciones.ultimoRegistro()+1);
            
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
                    comboBox1.Items.Add(dtabE.Rows[xE][0]);
                    xE = xE + 1;
                }

            }
            else
            {
                MessageBox.Show("No hay proveedores registrados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                FormMenuCita frm = new FormMenuCita();
                frm.Show();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Ej. Batelenguas" && comboBox2.Text == "Ej. Seleccione categoría" && comboBox1.Text == "Ej. Seleccione proveedor" && textBox5.Text == "Ej. Material fabricado con madera" && cantidad.Text == "1")
            {
                MessageBox.Show("Hacen falta datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inventario inventario = new Inventario();
                inventario.Nombre_producto = textBox2.Text;
                inventario.Categoria = comboBox2.Text;
                inventario.Proveedor = comboBox1.Text;
                inventario.Descripcion = textBox5.Text;
                inventario.Cantidad = Convert.ToInt32(cantidad.Text);

                int resultado = InventarioOperaciones.Agregar(inventario);
                if (resultado > 0)
                {
                    MessageBox.Show("Registro de producto exitoso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //textBox2.ForeColor = Color.Gray;
                    textBox2.Text = "Ej. Batelenguas";
                    //comboBox2.ForeColor = Color.Gray;
                    comboBox2.Text = "Seleccione categoría";
                    // comboBox1.ForeColor = Color.Gray;
                    comboBox1.Text = "Seleccione ID";
                    // textBox5.ForeColor = Color.Gray;
                    textBox5.Text = "Ej.Material fabricado con madera";
                    //cantidad.ForeColor = Color.Gray;
                   cantidad.Text = "1";
                    
                }
                else
                {
                    MessageBox.Show("No se pudo hacer el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea cancelar el registro del paciente? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                moduloinventario cambio = new moduloinventario();
                cambio.Usuario = Usuario;
                cambio.Show();
            } 
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Ej. Batelenguas" && comboBox2.Text != "Ej. Seleccione categoría" && comboBox1.Text != "Ej. Seleccione ID" && textBox5.Text != "Ej. Material fabricado con madera" && cantidad.Text!="1")
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas volver al menú?", "Advertencia", MessageBoxButtons.YesNo);
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

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Gainsboro;
            this.button3.ForeColor = Color.Black;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            this.button3.BackColor = Color.SteelBlue;
            this.button3.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Gainsboro;
            this.button1.ForeColor = Color.Black;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.BackColor = Color.SteelBlue;
            this.button1.ForeColor = Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.BackColor = Color.SteelBlue;
            this.button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Gainsboro;
            this.button2.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Ej. Batelenguas")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Seleccione categoría")
            {
                comboBox2.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Seleccione proveedor")
            {
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Ej. Material fabricado con madera")
            {
                textBox5.Clear();
                textBox5.ForeColor = Color.Black;
            }
        }

        private void cantidad_Click(object sender, EventArgs e)
        {
            if (cantidad.Text == "1")
            {
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Black;
               textBox2.Text = "Ej. Batelenguas";
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.ForeColor = Color.Black;
                comboBox2.Text = "Seleccione categoría";
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.ForeColor = Color.Black;
                comboBox1.Text = "Seleccione ID";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
               textBox5.ForeColor = Color.Black;
               textBox5.Text = "Ej. Material fabricado con madera";
            }
        }

        private void cantidad_Leave(object sender, EventArgs e)
        {
            if (cantidad.Text == "")
            {
               cantidad.ForeColor = Color.Black;
                cantidad.Text = "1";
            }
        }

}
}