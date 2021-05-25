using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Proveedor
    {
        
            public int idProveedor { get; set; }
            public string Nombre_empresa { get; set; }
            public string Telefono{ get; set; }
            public string Calle { get; set; }
            public int Numero { get; set; }
            public string Colonia { get; set; }
            public string Estado { get; set; }
            public string Municipio { get; set; }
            public string CP { get; set; }
            //public string Material { get; set; }

            public Proveedor() { }

            public Proveedor( int ProveedoresidProveedor,string ProveedoresNombre_empresa, string ProveedoresTelefono, string ProveedoresCalle, int ProveedoresNumero, string ProveedoresColonia, string ProveedoresEstado, string ProveedoresMunicipio, string ProveedoresCP)
            {
                this.idProveedor = ProveedoresidProveedor;
                this.Nombre_empresa = ProveedoresNombre_empresa;
                this.Telefono = ProveedoresTelefono;
                this.Calle = ProveedoresCalle;
                this.Numero = ProveedoresNumero;
                this.Colonia = ProveedoresColonia;
                this.Estado = ProveedoresEstado;
                this.Municipio = ProveedoresMunicipio;
                this.CP = ProveedoresCP;
                //this.Material = ProveedoresMaterial;
            }
    }
}
