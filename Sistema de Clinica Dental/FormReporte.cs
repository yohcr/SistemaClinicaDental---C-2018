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
using Microsoft.Reporting.WinForms;


namespace Sistema_de_Clinica_Dental
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }
        public string Usuario { set; get; }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetInventario.material' Puede moverla o quitarla según sea necesario.
            this.materialTableAdapter.Fill(this.DataSetInventario.material);
            DateTime fecha = DateTime.Today;
            ReportParameter ReportParameterFecha = new ReportParameter("ReportParameterFecha", fecha.ToString("dd-MM-yyyy"));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
            

        }
    }
}
