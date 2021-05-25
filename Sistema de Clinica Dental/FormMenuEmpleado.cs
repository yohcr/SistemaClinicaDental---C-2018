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
    public partial class FormMenuEmpleado : Form
    {
        public FormMenuEmpleado()
        {
            InitializeComponent();
        }
        public String Usuario { set; get; }
        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNuevoEmpleado frm = new FormNuevoEmpleado();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdm frm = new FormMenuAdm();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void BtnGestionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionarEmpleado frm = new FormGestionarEmpleado();
            frm.Usuario = Usuario;
            frm.Show();
        }

        private void FormMenuEmpleado_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }
    }
}
