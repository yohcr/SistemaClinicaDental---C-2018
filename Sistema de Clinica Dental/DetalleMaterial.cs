using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Clinica_Dental
{
    public class DetalleMaterial
    {
        public int NoCita { set; get; }
        public string Material { set; get; }
        public int cantidad { set; get; }

        public DetalleMaterial() { }
        
        public DetalleMaterial(int NoCita, string idMaterial, int cantidad) {
            this.NoCita = NoCita;
            this.Material = idMaterial;
            this.cantidad = cantidad;
        }
    }
}
