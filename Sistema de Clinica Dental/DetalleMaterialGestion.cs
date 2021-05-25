using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1;

namespace Sistema_de_Clinica_Dental
{
    class DetalleMaterialGestion
    {
        public static int AgregarMaterialCita( DetalleMaterial material) { 
        
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            string sql = "INSERT INTO `detallematerial` (`No_cita`, `idMaterial`, `Cantidad`) VALUES (?idCita, (SELECT idMaterial FROM material WHERE Nombre=?nomE), ?cant)";
            MySqlCommand query = new MySqlCommand(sql, conexion);                                                             
            query.Parameters.AddWithValue("?idCita", material.NoCita);
            query.Parameters.AddWithValue("?nomE", material.Material);
            query.Parameters.AddWithValue("?cant", material.cantidad);
           
            retorno = query.ExecuteNonQuery();
            return retorno;
        
        }

        public static Inventario ObtenerCantidad(String idMaterial) {
            Inventario material = new Inventario();
            //Obtener la cantidad
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            string sql = "SELECT * FROM material WHERE Nombre=?nomE";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?nomE", idMaterial);
            
            MySqlDataReader reader = query.ExecuteReader();
            
            while (reader.Read()) {
                //Inventario material = new Inventario();
                material.idMaterial = reader.GetInt32(0);
                material.Nombre_producto = reader.GetString(1);
                material.Categoria = reader.GetString(2);
                material.Proveedor = reader.GetString(3);
                material.Descripcion = reader.GetString(4);
                material.Cantidad = reader.GetInt32(5);
            }

            return material;
            
        }

        public static int Descontar(int cantidad, int idMaterial) {
            //Disminuir la existencia.
            int retorno = 0;
             MySqlConnection con = ConexionALaBD.conectar();
             con.Open();
             string sql2 = "UPDATE `material` SET `Cantidad`=?cant WHERE idMaterial = ?idMat";
             MySqlCommand query2 = new MySqlCommand(sql2, con);
             query2.Parameters.AddWithValue("?cant", cantidad);
             query2.Parameters.AddWithValue("?idMat", idMaterial);
             retorno = query2.ExecuteNonQuery();
             return retorno;
        
        }

        public static List<DetalleMaterial> Mostrar(int id)
        {
            List<DetalleMaterial> registros = new List<DetalleMaterial>();
            MySqlConnection conectar = ConexionALaBD.conectar();
            conectar.Open();
            String sql = "SELECT tba.No_Cita, tbb.Nombre, tba.Cantidad FROM detallematerial tba, material tbb  WHERE tba.idMaterial = tbb.idMaterial AND No_Cita = ?idCita ";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("?idCita", id);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                DetalleMaterial registro = new DetalleMaterial();
                registro.NoCita = reader.GetInt32(0);
                registro.Material = reader.GetString(1);
                registro.cantidad = reader.GetInt32(2);
                registros.Add(registro);
            }

            return registros;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "DELETE FROM detallematerial WHERE  No_Cita = ?id";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);

            try
            {
                retorno = query.ExecuteNonQuery();
            }
            catch (Exception)
            {
                retorno = -1;
            }

            conexion.Close();
            return retorno;
        }

        public static int EliminarEsp(int id, String material, int cantidad)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "DELETE FROM detallematerial WHERE  No_Cita = ?id AND idMaterial = (SELECT idMaterial FROM material WHERE Nombre = ?material) AND Cantidad = ?cant";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            query.Parameters.AddWithValue("?id", id);
            query.Parameters.AddWithValue("?material", material);
            query.Parameters.AddWithValue("?cant", cantidad);
            try
            {
                retorno = query.ExecuteNonQuery();
            }
            catch (Exception)
            {
                retorno = -1;
            }

            conexion.Close();
            return retorno;
        }

    }
}
