using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Clinica_Dental
{
    public class Empleado
    {
        public int ID {get ; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha {get; set;}
        public string Perfil { get; set; }
        public string Area { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Empleado() { }

        public Empleado(int id, string nombre, int edad, string sexo, DateTime fecha, string perfil, string area, string usuario, string contrasenya) {
            this.ID = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Fecha = fecha;
            this.Perfil = perfil;
            this.Area = area;
            this.Usuario = usuario;
            this.Contraseña = contrasenya;
        }

    }
}
