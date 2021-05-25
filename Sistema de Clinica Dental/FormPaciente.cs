using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;
using Sistema_de_Clinica_Dental;

namespace WindowsFormsApplication2
{
    public partial class FormPaciente : Form
    {

        public string Usuario { get; set; }
        public int id { get; set; }

        
        public FormPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNuevoPaciente nuevoPaciente = new FormNuevoPaciente();
            nuevoPaciente.Usuario = Usuario;
            nuevoPaciente.Show();
        }

        

        private void BtnVolver_MouseLeave(object sender, EventArgs e)
        {
            this.BtnVolver.BackColor = Color.Gainsboro;
            this.BtnVolver.ForeColor = Color.Black;
        }

        private void BtnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnVolver.BackColor = Color.SteelBlue;
            this.BtnVolver.ForeColor = Color.White;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Usuario == "Administrador"||Usuario=="Recepcionista")
            {
                FormMenuAdm menu = new FormMenuAdm();
                menu.Usuario = Usuario;
                menu.Show();
            }
            else {
                FormMenuDentista Menu = new FormMenuDentista();
                Menu.id = id;
                Menu.Usuario = Usuario;
                Menu.Show();
            }
        }

        private void BtnGestionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionPaciente gestionPaciente = new FormGestionPaciente();
            gestionPaciente.id = id;
            gestionPaciente.Usuario = Usuario;
            gestionPaciente.Show();
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }
    }
}
