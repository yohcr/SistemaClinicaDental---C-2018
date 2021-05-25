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

namespace Sistema_de_Clinica_Dental
{
    public partial class FormMenuDentista : Form
    {

        public string Usuario { get; set; }
        public int id { get; set; }

        public FormMenuDentista()
        {
            InitializeComponent();
            
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuCita frm = new FormMenuCita();
            frm.id = id;
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAgregarMaterial frm = new FormAgregarMaterial();
            frm.Usuario = Usuario;
            frm.id = id;
            frm.Show();
        } 

        private void FormMenuDentista_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPaciente frm = new FormPaciente();
            frm.id = id;
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicioSesion frm = new FormInicioSesion();
            frm.Show();
        }
    }
}
