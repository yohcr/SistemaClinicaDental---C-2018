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
using Sistema_de_Clinica_Dental;

namespace WindowsFormsApplication2
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnEntrar.BackColor = Color.SteelBlue;
            this.BtnEntrar.ForeColor = Color.White;
        }

        private void BtnEntrar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnEntrar.BackColor = Color.Gainsboro;
            this.BtnEntrar.ForeColor = Color.Black;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
          
            if (txtboxUsuario.Text == "" || txtboxContraseña.Text == "")
            {
                MessageBox.Show("Ingrese los datos necesarios");
          
            } else {
               try
                {
                   MySqlConnection conexion = Bd.ObtenerConexion();
                   conexion.Open();
                   String sql = "SELECT * FROM empleado WHERE Usuario= ?usuario AND Pass=?pass";
                   MySqlCommand query = new MySqlCommand(sql, conexion);
                   query.Parameters.AddWithValue("?usuario", txtboxUsuario.Text);
                   query.Parameters.AddWithValue("?pass", txtboxContraseña.Text);

                   MySqlDataAdapter sda = new MySqlDataAdapter(query);
                   DataTable tabladatos = new DataTable();
                   sda.Fill(tabladatos);

                    if (tabladatos.Rows.Count == 1)
                    {
                        this.Hide();
                        String usuario = tabladatos.Rows[0][5].ToString();
                        int id = Convert.ToInt32(tabladatos.Rows[0][0]);
                        if (usuario == "Administrador"||usuario =="Recepcionista")
                        {
                            FormMenuAdm Menu = new FormMenuAdm();
                            Menu.Usuario = usuario;
                            Menu.Show();

                        }
                        else {
                            FormMenuDentista Menu = new FormMenuDentista();
                            Menu.Usuario = usuario;
                            Menu.id = id;
                            Menu.Show();
                        }  
                        
                    }else{
                        MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtboxUsuario.Clear(); //Limpia el textBox
                        txtboxContraseña.Clear(); //Limpia el textBox
                    }
                    conexion.Close();
                } catch (Exception error) {
                    MessageBox.Show("Error: " + error.Message);
                } 
            }
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
