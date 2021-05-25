using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_Clinica_Dental
{
    class GestionCita
    {
        public static int Add(Cita cita) {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            string sql = "INSERT INTO `cita` (`idPaciente`, `Fecha`, `Hora`, `idEmpleado`, `Consultorio`) VALUES ((SELECT idPaciente FROM paciente WHERE Nombre=?nom), ?fecha, ?hora, (SELECT idEmpleado FROM empleado WHERE Nombre=?nomE), ?consultorio)";
            MySqlCommand query = new MySqlCommand(sql, conexion);                                                             
            query.Parameters.AddWithValue("?nom", cita.Paciente);
            query.Parameters.AddWithValue("?fecha", cita.Fecha);
            query.Parameters.AddWithValue("?hora", cita.Hora);
            query.Parameters.AddWithValue("?nomE", cita.Dentista);
            query.Parameters.AddWithValue("?consultorio", cita.Consultorio);
          
            retorno = query.ExecuteNonQuery();
            return retorno;
        }

        public static List<Cita> buscartodo()
        {
            List<Cita> _listaCita = new List<Cita>();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "SELECT No_Cita, paciente.Nombre, Fecha, Hora, empleado.Nombre, Consultorio  FROM cita INNER JOIN paciente ON cita.idPaciente=paciente.idPaciente INNER JOIN empleado ON cita.idEmpleado=empleado.idEmpleado";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                Cita cita = new Cita(); 
                cita.ID = obtener.GetInt32(0);
                cita.Paciente = obtener.GetString(1);
                cita.Fecha = obtener.GetDateTime(2);
                cita.Hora = obtener.GetString(3);
                cita.Dentista = obtener.GetString(4);
                cita.Consultorio = obtener.GetInt32(5);
                _listaCita.Add(cita);
            }
            //conexion.Close();
            return _listaCita;
        }

        public static List<Cita> buscar(int id, String nombre, String fecha, String Dentista)
        {
            List<Cita> _listaCita = new List<Cita>();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();

            //String sql = "SELECT No_Cita, paciente.Nombre, Fecha, Hora, empleado.Nombre, Consultorio FROM cita INNER JOIN paciente ON cita.idPaciente=paciente.idPaciente INNER JOIN empleado ON cita.idEmpleado=empleado.idEmpleado WHERE No_Cita= ?idC OR cita.idEmpleado=(SELECT empleado.idEmpleado from empleado WHERE empleado.Nombre = ?nomE) OR cita.idPaciente=(SELECT paciente.idPaciente FROM paciente WHERE paciente.Nombre = ?nom)";
            //String sql = "SELECT No_Cita, paciente.Nombre, Fecha, Hora, empleado.Nombre, Consultorio FROM cita INNER JOIN paciente ON cita.idPaciente=paciente.idPaciente INNER JOIN empleado ON cita.idEmpleado=empleado.idEmpleado WHERE No_Cita = ?idC OR Fecha=?fecha OR cita.idEmpleado=(SELECT empleado.idEmpleado from empleado WHERE empleado.Nombre=?nomE) OR cita.idPaciente=(SELECT paciente.idPaciente FROM paciente WHERE paciente.Nombre LIKE CONCAT('%',?nom, '%') )";
            String sql = "SELECT No_Cita, paciente.Nombre, Fecha, Hora, empleado.Nombre, Consultorio FROM cita INNER JOIN paciente ON cita.idPaciente=paciente.idPaciente INNER JOIN empleado ON cita.idEmpleado=empleado.idEmpleado WHERE No_Cita = ?idC OR Fecha=?fecha OR cita.idEmpleado=(SELECT empleado.idEmpleado from empleado WHERE empleado.Nombre=?nomE) OR  paciente.Nombre LIKE CONCAT('%',?nom, '%') ";

            MySqlCommand query = new MySqlCommand(sql, conexion);

            query.Parameters.AddWithValue("?idC", id);
            query.Parameters.AddWithValue("?nom", nombre);
            query.Parameters.AddWithValue("?fecha", fecha);
            query.Parameters.AddWithValue("?nomE", Dentista);

            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                Cita cita = new Cita();
                cita.ID = obtener.GetInt32(0);
                cita.Paciente = obtener.GetString(1);
                cita.Fecha = obtener.GetDateTime(2);
                cita.Hora = obtener.GetString(3);
                cita.Dentista = obtener.GetString(4);
                cita.Consultorio = obtener.GetInt32(5);
                _listaCita.Add(cita);
            }
            //conexion.Close();
            return _listaCita;
        }

        public static List<Cita> buscarFecha(String fecha, int id)
        {
            List<Cita> _listaCita = new List<Cita>();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "SELECT No_Cita, paciente.Nombre, Fecha, Hora, empleado.Nombre, Consultorio FROM cita INNER JOIN paciente ON cita.idPaciente=paciente.idPaciente INNER JOIN empleado ON cita.idEmpleado=empleado.idEmpleado WHERE Fecha = ?fecha AND cita.idEmpleado = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?fecha", fecha);
            query.Parameters.AddWithValue("?id", id);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                Cita cita = new Cita();
                cita.ID = obtener.GetInt32(0);
                cita.Paciente = obtener.GetString(1);
                cita.Fecha = obtener.GetDateTime(2);
                cita.Hora = obtener.GetString(3);
                cita.Dentista = obtener.GetString(4);
                cita.Consultorio = obtener.GetInt32(5);
                _listaCita.Add(cita);
            }
            //conexion.Close();
            return _listaCita;
        }

        public static int Actualizar(Cita cita)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "UPDATE cita SET idPaciente = (SELECT idPaciente FROM paciente WHERE Nombre=?Paciente), Fecha = ?fecha, Hora = ?Hora, idEmpleado = (SELECT idEmpleado FROM empleado WHERE Nombre = ?Dentista), Consultorio = ?consultorio WHERE No_Cita = ?idP";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?idP", cita.ID);
            query.Parameters.AddWithValue("?Paciente", cita.Paciente);
            query.Parameters.AddWithValue("?fecha", cita.Fecha);
            query.Parameters.AddWithValue("?Hora", cita.Hora);
            query.Parameters.AddWithValue("?Dentista", cita.Dentista);
            query.Parameters.AddWithValue("?consultorio", cita.Consultorio);
            retorno = query.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "DELETE FROM cita WHERE  No_Cita = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);

            try
            {
                retorno = query.ExecuteNonQuery();
            }
            catch (Exception) {
                retorno = -1;
            }
            
            conexion.Close();
            return retorno;
        }

        public static Cita ObtenerCita(int id)
        {
            Cita cita = new Cita();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "SELECT No_Cita, paciente.Nombre, Fecha, Hora, empleado.Nombre, Consultorio  FROM cita INNER JOIN paciente ON cita.idPaciente=paciente.idPaciente INNER JOIN empleado ON cita.idEmpleado=empleado.idEmpleado WHERE No_Cita = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);
            MySqlDataReader _reader = query.ExecuteReader();
            while (_reader.Read())
            {

                cita.ID = _reader.GetInt32(0);
                cita.Paciente = _reader.GetString(1);
                cita.Fecha = _reader.GetDateTime(2);
                cita.Hora = _reader.GetString(3);
                cita.Dentista = _reader.GetString(4);
                cita.Consultorio = _reader.GetInt32(5);

            }

            conexion.Close();
            return cita;

        }

        public static int ultimoRegistro()
        {
            int? id = null;

            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT MAX(No_Cita) FROM cita"), conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {

                if (id == lector.GetInt32(0))
                {
                    id = 1;
                }
                else
                {
                    id = lector.GetInt32(0);
                }
            }
            return Convert.ToInt32(id);
        }
    }
}
