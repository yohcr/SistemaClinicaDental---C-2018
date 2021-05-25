using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Clinica_Dental
{
    public class Cita
    {
        public int ID { get; set; }
        public String Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public String Hora { get; set; }
        public String Dentista { get; set; }
        public int Consultorio { get; set; }
        public Cita(){ }

        public Cita(int ID, String paciente, DateTime fecha, String hora, String dentista, int consultorio){
            this.ID = ID;
            this.Paciente = paciente;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Dentista = dentista;
            this.Consultorio = consultorio;

        }
    }
}
