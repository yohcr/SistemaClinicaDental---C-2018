using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_Clinica_Dental
{
    class GestionEmpleado
    {
        public static int Add(Empleado empleado) {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "Insert into empleado (Nombre, Edad, Sexo, Fecha_ingreso, Perfil, Area, Usuario, Pass) values (?nom, ?edad, ?sexo, ?fecha, ?perfil, ?area, ?usuario, ?contrasenya)"; //empleado.nombre, empleado.edad, empleado.sexo, empleado.fecha, empleado.perfil, empleado.area, empleado.usuario, empleado.contrasenya), 
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?nom", empleado.Nombre);
            query.Parameters.AddWithValue("?edad", empleado.Edad);
            query.Parameters.AddWithValue("?sexo", empleado.Sexo);
            query.Parameters.AddWithValue("?fecha", empleado.Fecha);
            query.Parameters.AddWithValue("?perfil", empleado.Perfil);
            query.Parameters.AddWithValue("?area", empleado.Area);
            query.Parameters.AddWithValue("?usuario", empleado.Usuario);
            query.Parameters.AddWithValue("?contrasenya", empleado.Contraseña);
            retorno = query.ExecuteNonQuery();
            return retorno;
        }

        public static List<Empleado> buscar(int id, String nombre, String area) { 
            List<Empleado>_listaEmpleado = new List<Empleado>();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "SELECT * FROM empleado WHERE idEmpleado = ?id OR Nombre LIKE CONCAT('%',?nom, '%') OR Area = ?area";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);
            query.Parameters.AddWithValue("?nom", nombre);
            query.Parameters.AddWithValue("?area", area);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read()) {
                Empleado empleado = new Empleado();
                empleado.ID = obtener.GetInt32(0);
                empleado.Nombre = obtener.GetString(1);
                empleado.Edad = obtener.GetInt32(2);
                empleado.Sexo = obtener.GetString(3);
                empleado.Fecha = obtener.GetDateTime(4);
                empleado.Perfil = obtener.GetString(5);
                empleado.Area = obtener.GetString(6);
                empleado.Usuario = obtener.GetString(7);
                empleado.Contraseña = obtener.GetString(8);
                _listaEmpleado.Add(empleado);
            }
            //conexion.Close();
            return _listaEmpleado;
        }


        public static Empleado ObtenerEmpleado(int id)
        {
            Empleado empleado = new Empleado();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "SELECT * FROM empleado WHERE idEmpleado = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                empleado.ID = obtener.GetInt32(0);
                empleado.Nombre = obtener.GetString(1);
                empleado.Edad = obtener.GetInt32(2);
                empleado.Sexo = obtener.GetString(3);
                empleado.Fecha = obtener.GetDateTime(4);
                empleado.Perfil = obtener.GetString(5);
                empleado.Area = obtener.GetString(6);
                empleado.Usuario = obtener.GetString(7);
                empleado.Contraseña = obtener.GetString(8);

            }

            conexion.Close();
            return empleado;

        }

        public static List<Empleado> buscartodo()
        {
            List<Empleado> _listaEmpleado = new List<Empleado>();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "SELECT * FROM empleado ";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                Empleado empleado = new Empleado();
                empleado.ID = obtener.GetInt32(0);
                empleado.Nombre = obtener.GetString(1);
                empleado.Edad = obtener.GetInt32(2);
                empleado.Sexo = obtener.GetString(3);
                empleado.Fecha = obtener.GetDateTime(4);
                empleado.Perfil = obtener.GetString(5);
                empleado.Area = obtener.GetString(6);
                empleado.Usuario = obtener.GetString(7);
                empleado.Contraseña = obtener.GetString(8);
                _listaEmpleado.Add(empleado);
            }
            //conexion.Close();
            return _listaEmpleado;
        }

        public static Empleado buscarArea(String area)
        {
            Empleado empleado = new Empleado();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "SELECT * FROM empleado WHERE Area = ?area";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?area", area);
            MySqlDataReader obtener = query.ExecuteReader();
            while (obtener.Read())
            {
                empleado.ID = obtener.GetInt32(0);
                empleado.Nombre = obtener.GetString(1);
                empleado.Edad = obtener.GetInt32(2);
                empleado.Sexo = obtener.GetString(3);
                empleado.Fecha = obtener.GetDateTime(4);
                empleado.Perfil = obtener.GetString(5);
                empleado.Area = obtener.GetString(6);
                empleado.Usuario = obtener.GetString(7);
                empleado.Contraseña = obtener.GetString(8);

            }

            conexion.Close();
            return empleado;

        }

        public static int Actualizar(Empleado empleado)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "UPDATE empleado set Nombre = ?nom,  Edad = ?edad, Sexo = ?sexo, Fecha_ingreso = ?fecha, Perfil = ?perfil, Area = ?area, Usuario = ?usuario, Pass = ?cont WHERE idEmpleado = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", empleado.ID);
            query.Parameters.AddWithValue("?nom", empleado.Nombre);
            query.Parameters.AddWithValue("?edad", empleado.Edad);
            query.Parameters.AddWithValue("?sexo", empleado.Sexo);
            query.Parameters.AddWithValue("?fecha", empleado.Fecha);
            query.Parameters.AddWithValue("?perfil", empleado.Perfil);
            query.Parameters.AddWithValue("?area", empleado.Area);
            query.Parameters.AddWithValue("?usuario", empleado.Usuario);
            query.Parameters.AddWithValue("?cont", empleado.Contraseña);
            retorno = query.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }

        public static int Eliminar(int id) {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "DELETE FROM empleado WHERE  idEmpleado = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);
            retorno = query.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int ultimoRegistro()
        {
            int? id = null;

            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT MAX(idEmpleado) FROM empleado"), conexion);
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
