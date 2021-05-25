using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using MySql.Data.MySqlClient;


namespace Sistema_de_Clinica_Dental
{
    public partial class FormAgregarMaterial : Form
    {
        public FormAgregarMaterial()
        {
            InitializeComponent();
        }

        public string Usuario { get; set; }
        public int id { get; set; }
        public Inventario Seleccion { get; set; }


        private void FormAgregarMaterial_Load(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            String fecha = Fecha.ToString("yyyy-MM-dd");
            dataGridCitas.DataSource = GestionCita.buscarFecha(fecha,id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridCitas.SelectedRows.Count == 1)
            {
                textBoxNcita.Text = Convert.ToString (dataGridCitas.CurrentRow.Cells[0].Value);
                llenarCombo();
                comboBoxMaterial.Enabled = true;
                numericUpDown1.Enabled = true;
                buttonAgregar.Enabled = true;
                buttonFinalizar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonEliminar.Enabled = true;
            }
            else
                MessageBox.Show("Debe de seleccionar un registro");
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            if (buttonAgregar.Enabled == true)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro(a) que deseas salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    FormMenuDentista frm = new FormMenuDentista();
                    frm.id = id;
                    frm.Usuario = Usuario;
                    frm.Show();
                }
            }
            else
            {

                this.Hide();
                FormMenuDentista frm = new FormMenuDentista();
                frm.id = id;
                frm.Usuario = Usuario;
                frm.Show();
            }
        }

        public void llenarCombo() {
            MySqlConnection conexionP = ConexionALaBD.conectar();
            string sqlP = "SELECT * FROM Material ORDER BY Nombre ASC";
            MySqlCommand cmdP = new MySqlCommand(sqlP, conexionP);

            MySqlDataAdapter sdaP = new MySqlDataAdapter(cmdP);
            DataTable dtabP = new DataTable();
            sdaP.Fill(dtabP);
            int resultadosP = dtabP.Rows.Count;
            int xP = 0;

            if (dtabP.Rows.Count > 0)
            {
                while (xP < resultadosP)
                {
                    comboBoxMaterial.Items.Add(dtabP.Rows[xP][1]);
                    xP = xP + 1;
                }


            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDown1.Text) > 0 && comboBoxMaterial.Text != String.Empty && comboBoxMaterial.Text != "Selecciona material")
            {
                DetalleMaterial material = new DetalleMaterial();
                material.NoCita = Convert.ToInt32(textBoxNcita.Text.Trim());
                material.Material = comboBoxMaterial.Text;
                material.cantidad = Convert.ToInt32(numericUpDown1.Text);

                int retorno = DetalleMaterialGestion.AgregarMaterialCita(material);
                //Se comprueba si se agrego correctamente
                if (retorno > 0) {
                   
                    //Se obtiene los datos del material que se agrego
                    Seleccion = DetalleMaterialGestion.ObtenerCantidad(material.Material);
                    int desc = DetalleMaterialGestion.Descontar((Seleccion.Cantidad-material.cantidad), Seleccion.idMaterial);
                    if (desc > 0) {
                        dataGridViewMat.DataSource = DetalleMaterialGestion.Mostrar(material.NoCita);
                        comboBoxMaterial.Text = "Seleccione material";
                        numericUpDown1.Text = "0";

                    }
                }
            }
            else {
                MessageBox.Show("Faltan datos", "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridCitas.RowCount > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    int retorno = DetalleMaterialGestion.Eliminar(Convert.ToInt32(textBoxNcita.Text));
                    if (retorno > 0)
                    {
                        MessageBox.Show("Se ha eliminado todo material de la cita seleccionada");
                    }
                    this.Hide();
                    FormMenuDentista frm = new FormMenuDentista();
                    frm.id = id;
                    frm.Usuario = Usuario;
                    frm.Show();
                }
            }
            else {
                this.Hide();
                FormMenuDentista frm = new FormMenuDentista();
                frm.id = id;
                frm.Usuario = Usuario;
                frm.Show();
                
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCitas.RowCount == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar este material de la cita? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes) {
                    int retorno = DetalleMaterialGestion.EliminarEsp(Convert.ToInt32(textBoxNcita), comboBoxMaterial.Text.Trim(), Convert.ToInt32(numericUpDown1.Text));
                    if (retorno > 0)
                    {
                        MessageBox.Show("Se ha quitado el material de la lista");
                    }
                    else {
                        MessageBox.Show("No fue posible quitar el material de la lista");
                    }
                }
            }
            else {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (dataGridCitas.RowCount > 0)
                MessageBox.Show("Se han agregado los materiales satisfactoriamente");
            this.Hide();
            FormMenuDentista frm = new FormMenuDentista();
            frm.id = id;
            frm.Usuario = Usuario;
            frm.Show();
        }
    }
}
