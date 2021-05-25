using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Paciente
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public int Edad{ get; set; }
       public string Sexo { get; set; }
       public string Telefono{ get; set; }
       public string Especialidad { get; set; }
       public DateTime Fecha_registro { get; set; }

       public Paciente() { }

       public Paciente( int Id,string Nombre, int Edad, string Sexo, string Telefono, string Especialidad, DateTime Fecha)

       {

           this.Id = Id;
           this.Nombre = Nombre;
           this.Edad = Edad;
           this.Sexo = Sexo;
           this.Especialidad = Especialidad;
           this.Fecha_registro = Fecha;
       }


    }
}
