using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Clinica_Dental;

namespace WindowsFormsApplication1
{
    public partial class moduloproveedor : Form
    {
        public string Usuario { get; set; }
        public moduloproveedor()
        {
            InitializeComponent();
        }

        private void moduloproveedor_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           nuevoproveedor cambio = new nuevoproveedor();
           cambio.Usuario = Usuario;
            cambio.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionproveedor cambio = new gestionproveedor();
            cambio.Usuario = Usuario;
            cambio.Show();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdm frm = new FormMenuAdm();
            frm.Usuario = Usuario;
            frm.Show();
        }
    }
}
