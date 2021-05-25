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
    public partial class moduloinventario : Form
    {
        public string Usuario { get; set; }
        public moduloinventario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Usuario);
        }

   
 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevoproducto cambio = new nuevoproducto();
            cambio.Usuario = Usuario;
            
            cambio.Show();
        }

       

        private void gestionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestióndeinventario cambio = new gestióndeinventario();
            cambio.Usuario = Usuario;
            cambio.Show();
        }

        private void flecha_Click(object sender, EventArgs e)
        {
            this.Hide();
            moduloproveedor cambio = new moduloproveedor();
            cambio.Usuario = Usuario;
            cambio.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
