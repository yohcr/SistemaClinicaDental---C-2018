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
using WindowsFormsApplication1;
using Sistema_de_Clinica_Dental;

namespace Sistema_de_Clinica_Dental
{
    public partial class FormMenuAdm : Form
    {
        public string Usuario { get; set; }

        public FormMenuAdm()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
            if (Usuario == "Recepcionista")
            {
                BtnEmpleado.Enabled = false;
                BtnProveedor.Enabled = false;
                BtnInventario.Enabled = false;
                button1.Enabled = false;
            }

        }

        private void BtnCitas_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnCita.BackColor = Color.FromArgb(27, 55, 98);
        }

        private void BtnCitas_MouseLeave(object sender, EventArgs e)
        {
            this.BtnCita.BackColor = Color.FromArgb(72, 105, 148);
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {

        }

        private void btnPaciente_MouseLeave(object sender, EventArgs e)
        {
            this.btnPaciente.BackColor = Color.FromArgb(166, 77, 121);
        }

        private void btnPaciente_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnPaciente.BackColor = Color.FromArgb(116, 27, 71);
        }

        private void BtnCitas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuCita frm = new FormMenuCita();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuEmpleado frm = new FormMenuEmpleado();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
            FormInicioSesion frm = new FormInicioSesion();
            frm.Show();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            moduloinventario frm = new moduloinventario();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPaciente frm = new FormPaciente();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            moduloproveedor frm = new moduloproveedor();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnProveedor_MouseHover(object sender, EventArgs e)
        {
            /*if (BtnProveedor.Enabled == false) {
                BtnProveedor.Cursor = Cursors.No; 

            }*/
        }

        private void BtnProveedor_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (BtnProveedor.Enabled == false)
            {
                BtnProveedor.Cursor = Cursors.No; 
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormReporte frm = new FormReporte();
            frm.Usuario = Usuario;
            frm.Show();
        }


    }
}
