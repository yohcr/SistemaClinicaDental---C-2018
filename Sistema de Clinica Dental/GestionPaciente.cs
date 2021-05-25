using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsFormsApplication2
{
    class GestionPaciente
    {
        public static int Agregar(Paciente paciente)
        {

            int retorno = 0;
            MySqlConnection conexion = Bd.ObtenerConexion();
            conexion.Open();
            String sql = "INSERT INTO paciente(Nombre, Edad, Sexo, Telefono, Servicio, Fecha_registro) VALUES (?nom, ?edad, ?sexo, ?tel, ?serv,?fecha)";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?nom", paciente.Nombre);
            query.Parameters.AddWithValue("?edad", paciente.Edad);
            query.Parameters.AddWithValue("?sexo", paciente.Sexo);
            query.Parameters.AddWithValue("?tel", paciente.Telefono);
            query.Parameters.AddWithValue("?serv", paciente.Especialidad);
            query.Parameters.AddWithValue("?fecha", paciente.Fecha_registro);
            retorno = query.ExecuteNonQuery();
            return retorno;
        }

        public static List<Paciente> Buscar(int Id, String Nombre, String Sexo, String Especialidad )
        {
            
            List<Paciente> listaPaciente = new List<Paciente>(); //Lista de la clase
            MySqlConnection conexion = Bd.ObtenerConexion();
            conexion.Open();
            String sql = "SELECT * FROM paciente WHERE idPaciente = ?id  OR Sexo = ?sexo  OR Servicio = ?esp OR Nombre LIKE CONCAT('%',?nom,'%')";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", Id);
            query.Parameters.AddWithValue("?nom", Nombre);
            query.Parameters.AddWithValue("?sexo", Sexo);
            query.Parameters.AddWithValue("?esp", Especialidad);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                Paciente paciente = new Paciente();
                paciente.Id = obtener.GetInt32(0);
                paciente.Nombre = obtener.GetString(1);
                paciente.Edad = obtener.GetInt32(2);
                paciente.Sexo = obtener.GetString(3);
                paciente.Telefono = obtener.GetString(4);
                paciente.Especialidad = obtener.GetString(5);
                paciente.Fecha_registro = obtener.GetDateTime(6);

                listaPaciente.Add(paciente);
            }

            return listaPaciente;
        }

        public static List<Paciente> BuscarTodos()
        {

            List<Paciente> listaPaciente = new List<Paciente>(); //Lista de la clase
            MySqlConnection conexion = Bd.ObtenerConexion();
            conexion.Open();
            String sql = "SELECT * FROM paciente";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                Paciente paciente = new Paciente();
                paciente.Id = obtener.GetInt32(0);
                paciente.Nombre = obtener.GetString(1);
                paciente.Edad = obtener.GetInt32(2);
                paciente.Sexo = obtener.GetString(3);
                paciente.Telefono = obtener.GetString(4);
                paciente.Especialidad = obtener.GetString(5);
                paciente.Fecha_registro = obtener.GetDateTime(6);

                listaPaciente.Add(paciente);
            }

            return listaPaciente;
        }

        public static Paciente ObtenerPaciente(int id)
        {
            Paciente paciente = new Paciente();
            MySqlConnection conexion = Bd.ObtenerConexion();
            conexion.Open();
            String sql = "SELECT * FROM paciente where IdPaciente = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);
            MySqlDataReader _reader = query.ExecuteReader();
            while (_reader.Read())
            {
                
                paciente.Id = _reader.GetInt32(0);
                paciente.Nombre = _reader.GetString(1);
                paciente.Edad = _reader.GetInt32(2);
                paciente.Sexo = _reader.GetString(3);
                paciente.Telefono = _reader.GetString(4);
                paciente.Especialidad = _reader.GetString(5);
                paciente.Fecha_registro = _reader.GetDateTime(6);

            }

            conexion.Close();
            return paciente;

        }

        public static int Actualizar(Paciente paciente)
        {
            int retorno = 0;
            MySqlConnection conexion = Bd.ObtenerConexion();
            conexion.Open();
            String sql = "UPDATE paciente set Nombre = ?nom, Edad = ?edad, Sexo = ?sexo, Telefono = ?tel, Servicio = ?esp WHERE idPaciente =?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?nom", paciente.Nombre);
            query.Parameters.AddWithValue("?edad", paciente.Edad);
            query.Parameters.AddWithValue("?sexo", paciente.Sexo);
            query.Parameters.AddWithValue("?tel", paciente.Telefono);
            query.Parameters.AddWithValue("?esp", paciente.Especialidad);
            query.Parameters.AddWithValue("?id", paciente.Id);
            retorno = query.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Eliminar(Paciente paciente)
        {
            int retorno = 0;
            MySqlConnection conexion = Bd.ObtenerConexion();
            conexion.Open();
            String sql = "DELETE FROM paciente WHERE idPaciente =?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", paciente.Id);
            try
            {
                retorno = query.ExecuteNonQuery();
            }catch(Exception ){
                retorno = -1;
            }

            conexion.Close();

            return retorno;

        }

        public static int ultimoRegistro()
        {
            int? id = null;

            MySqlConnection conexion = Bd.ObtenerConexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT MAX(idPaciente) FROM paciente"), conexion);
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
