using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    
        public class Inventario
        {
            public int idMaterial { get; set; }
            public string Nombre_producto { get; set; }
            public string Categoria { get; set; }
            public string Proveedor { get; set; }
            public string Descripcion { get; set; }
            public int Cantidad { get; set; }
            public Inventario() { }

            public Inventario(int inventarioidMaterial, string inventarioNombre_producto, string inventarioCategoria, string idProveedor, string inventarioDescripcion,int inventarioCantidad)
            {
                this.idMaterial = inventarioidMaterial;
                this.Nombre_producto = inventarioNombre_producto;
                this.Categoria = inventarioCategoria;
                this.Proveedor = idProveedor;
                this.Descripcion = inventarioDescripcion;
                this.Cantidad = inventarioCantidad;
            }

        }
    
}
