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
    public partial class FormMenuCita : Form
    {
        public string Usuario { get; set; }
        public int id { get; set; }


        public FormMenuCita()
        {
            InitializeComponent();
        }

        private void FormMenuCita_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }

        private void BtnNueva_MouseHover(object sender, EventArgs e)
        {
            this.BtnNueva.BackColor = Color.FromArgb(27, 55, 98);
        }

        private void BtnNueva_MouseLeave(object sender, EventArgs e)
        {
            this.BtnNueva.BackColor = Color.FromArgb(72, 105, 148);
        }

        private void BtnNueva_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnNueva.BackColor = Color.FromArgb(27, 55, 98);
        }

        private void BtnGestionar_MouseHover(object sender, EventArgs e)
        {
            this.BtnGestionar.BackColor = Color.FromArgb(108, 138, 176);
        }

        private void BtnGestionar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnGestionar.BackColor = Color.FromArgb(158, 188, 226);
        }

        private void BtnGestionar_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnGestionar.BackColor = Color.FromArgb(108, 138, 176);
        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNuevaCita frm = new FormNuevaCita();
            frm.id = id;
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnGestionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionarCita frm = new FormGestionarCita();
            frm.id = id;
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Usuario == "Administrador"||Usuario=="Recepcionista")
            {
                FormMenuAdm frm = new FormMenuAdm();
               
                frm.Usuario = Usuario;
                frm.Show();
            }
            else {
                FormMenuDentista Menu = new FormMenuDentista();
                Menu.id = id;
                Menu.Usuario = Usuario;
                Menu.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
