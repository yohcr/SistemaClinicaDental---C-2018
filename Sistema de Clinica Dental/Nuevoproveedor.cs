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
    public partial class nuevoproveedor : Form
    {
        public string Usuario { get; set; }

        public nuevoproveedor()
        {
            InitializeComponent();
        }
        
        MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database= mydb; uid=root; pwd=;Port=3307");
        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea cancelar el registro del paciente? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                moduloproveedor cambio = new moduloproveedor();
                cambio.Usuario = Usuario;
                cambio.Show();
            }
        }
      
        private void registrar_Click(object sender, EventArgs e)
        {

            if (textBoxEmpresa.Text == "Ej. La sonrisa"  || maskedTextBoxTel.MaskFull == false || maskedTextBoxNumero.Text =="" || maskedTextBoxCP.MaskFull == false || textBoxCalle.Text == "Ej. Av. Morelos" || textBoxColonia.Text == "Ej. Col. Centro" || textBoxEstado.Text == "Ej. Morelos" || textBoxmMunicipio.Text == "Ej. Cuernavaca")
            {
                MessageBox.Show("Hacen falta datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                Proveedor proveedor = new Proveedor();
                proveedor.Nombre_empresa = textBoxEmpresa.Text;
                proveedor.Telefono = maskedTextBoxTel.Text;
                proveedor.Calle = textBoxCalle.Text;
                proveedor.Numero = Convert.ToInt32(maskedTextBoxNumero.Text);
                proveedor.Colonia = textBoxColonia.Text;
                proveedor.Estado = textBoxEstado.Text;
                proveedor.Municipio = textBoxmMunicipio.Text;
                proveedor.CP = maskedTextBoxCP.Text;

                int resultado = ProveedorOperaciones.Agregar(proveedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro de proveedor exitoso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    textBoxEmpresa.Text = "Ej. La sonrisa";
                    maskedTextBoxTel.Clear();
                    textBoxCalle.Text = "Ej. Av. Morelos";
                    maskedTextBoxNumero.Clear();
                    textBoxColonia.Text = "Ej. Col. Centro";
                    textBoxEstado.Text = "Ej. Cuernavaca";
                    textBoxmMunicipio.Text = "Ej. Morelos";
                    maskedTextBoxCP.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmpresa.Text != "Ej. La sonrisa" || maskedTextBoxTel.MaskFull == true || maskedTextBoxNumero.MaskFull == true || maskedTextBoxCP.MaskFull == true || textBoxCalle.Text != "Ej. Av. Morelos" || textBoxColonia.Text != "Ej. Col. Centro" || textBoxEstado.Text != "Ej. Morelos" || textBoxmMunicipio.Text != "Ej. Cuernavaca")
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas volver al menú?", "Advertencia", MessageBoxButtons.YesNo);
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
                cambio.Usuario= Usuario;
                cambio.Show();
            }
       
        }

        private void nuevoproveedor_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            this.button3.BackColor = Color.SteelBlue;
            this.button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Gainsboro;
            this.button3.ForeColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.BackColor = Color.SteelBlue;
            this.button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.SteelBlue;
            this.button2.ForeColor = Color.White;
        }

        private void registrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.registrar.BackColor = Color.SteelBlue;
            this.registrar.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBoxEmpresa.Text == "Ej. La sonrisa")
            {
                textBoxEmpresa.Clear();
                textBoxEmpresa.ForeColor = Color.Black;
            }
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxID.Text == "")
            {
                maskedTextBoxID.Clear();
                maskedTextBoxID.ForeColor = Color.Black;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBoxCalle.Text == "Ej. Av. Morelos")
            {
                textBoxCalle.Clear();
                textBoxCalle.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBoxEmpresa.Text == "")
            {
                textBoxEmpresa.ForeColor = Color.Black;
                textBoxEmpresa.Text = "Ej. La sonrisa";
            }
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxTel.Text == "")
            {
                maskedTextBoxID.ForeColor = Color.Black;
                maskedTextBoxTel.Clear();
                //maskedTextBoxID.Text = "000-000-0000";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBoxCalle.Text == "")
            {
                textBoxCalle.ForeColor = Color.Black;
                textBoxCalle.Text = "Ej. Av. Morelos";
            }
        }

        private void registrar_MouseLeave(object sender, EventArgs e)
        {
            this.registrar.BackColor = Color.Gainsboro;
            this.registrar.ForeColor = Color.Black;
        }

        private void textBoxColonia_Click(object sender, EventArgs e)
        {
            if(textBoxColonia.Text == "Ej. Col. Centro")
                textBoxColonia.Clear();
        }

        private void textBoxColonia_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxColonia.Text == "") {
                textBoxColonia.Text = "Ej. Col. Centro";
            }
        }

        private void textBoxEstado_Click(object sender, EventArgs e)
        {
            if (textBoxEstado.Text == "Ej. Morelos")
                textBoxEstado.Clear();
        }

        

        private void textBoxmMunicipio_Click(object sender, EventArgs e)
        {
            if (textBoxmMunicipio.Text == "Ej. Cuernavaca")
                textBoxmMunicipio.Clear();
        }

        private void textBoxmMunicipio_Leave(object sender, EventArgs e)
        {
            if (textBoxmMunicipio.Text == "")
                textBoxmMunicipio.Text = "Ej. Cuernavaca";
        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEstado_Leave(object sender, EventArgs e)
        {
            if (textBoxEstado.Text == "")
                textBoxEstado.Text = "Ej. Morelos";
        }

       

        
        

        

        


       

    }
}
