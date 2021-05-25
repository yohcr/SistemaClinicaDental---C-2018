using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sistema_de_Clinica_Dental;

namespace WindowsFormsApplication1
{
    class InventarioOperaciones
    {
        public static int Agregar(Inventario inventario)
        {
             int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            String sql = "Insert into material (Nombre,Categoria,idProveedor,Descripcion,Cantidad) values (?nombre, ?categoria, (SELECT idProveedor FROM proveedor WHERE Nombre_empresa = ?empresa), ?desc,?cant)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("?nombre",inventario.Nombre_producto);
            comando.Parameters.AddWithValue("?categoria", inventario.Categoria);
            comando.Parameters.AddWithValue("?empresa", inventario.Proveedor);
            comando.Parameters.AddWithValue("?desc", inventario.Descripcion);
            comando.Parameters.AddWithValue("?cant", inventario.Cantidad);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public Inventario Actualizacion { get; set; }

        public static List<Inventario> Buscar(int inventarioidMaterial, string inventarioNombre_producto, string inventarioCategoria)
        {
            List<Inventario> lista = new List<Inventario>();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(String.Format(
           "SELECT idMaterial, Nombre, Categoria, proveedor.Nombre_empresa, Descripcion, Cantidad FROM material INNER JOIN proveedor ON material.idProveedor = proveedor.idProveedor WHERE idMaterial ='{0}'  or Categoria ='{1}' or Nombre LIKE CONCAT('%',?nombre,'%')", inventarioidMaterial, inventarioCategoria), conexion);
            comando.Parameters.AddWithValue("?nombre", inventarioNombre_producto);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Inventario inventario = new Inventario();
                    inventario.idMaterial = reader.GetInt32(0);
                    inventario.Nombre_producto = reader.GetString(1);
                    inventario.Categoria = reader.GetString(2);
                    inventario.Proveedor = reader.GetString(3);
                    inventario.Descripcion = reader.GetString(4);
                    inventario.Cantidad = reader.GetInt32(5);


                    lista.Add(inventario);


                }
                return lista;
        }
        public static List<Inventario> Mostrar()
        {
            List<Inventario> registros = new List<Inventario>();

            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idMaterial, Nombre, Categoria, proveedor.Nombre_empresa, Descripcion, Cantidad FROM material INNER JOIN proveedor ON material.idProveedor = proveedor.idProveedor"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Inventario inventario = new Inventario();

                inventario.idMaterial = reader.GetInt32(0);
                inventario.Nombre_producto = reader.GetString(1);
                inventario.Categoria = reader.GetString(2);
                inventario.Proveedor = reader.GetString(3);
                inventario.Descripcion = reader.GetString(4);
                inventario.Cantidad = reader.GetInt32(5);

                registros.Add(inventario);
            }

            return registros;
        }

        public static Inventario ObtenerInventario(int inventarioidMaterial)
        {
            MySqlConnection conectar = ConexionALaBD.conectar();
            conectar.Open();
            Inventario inventario = new Inventario();
            //MySqlConnection conexion = ConexionALaBD.conectar();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idMaterial, Nombre, Categoria, proveedor.Nombre_empresa, Descripcion, Cantidad FROM material INNER JOIN proveedor ON material.idProveedor = proveedor.idProveedor where idMaterial={0}", inventarioidMaterial), conectar);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                inventario.idMaterial = reader.GetInt32(0);
                inventario.Nombre_producto = reader.GetString(1);
                inventario.Categoria = reader.GetString(2);
                inventario.Proveedor = reader.GetString(3);
                inventario.Descripcion = reader.GetString(4);
                inventario.Cantidad = reader.GetInt32(5);

            }

            //conexion.Close();
            return inventario;

        }
        public static int Actualizar(Inventario inventario)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(string.Format("Update material set Nombre='{0}',Categoria ='{1}', idProveedor=(SELECT idProveedor FROM proveedor WHERE Nombre_empresa ='{2}' ), Descripcion='{3}', Cantidad='{4}' where idMaterial='{5}'",
               inventario.Nombre_producto, inventario.Categoria, inventario.Proveedor, inventario.Descripcion, inventario.Cantidad, inventario.idMaterial), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        public static int Eliminar(int InventarioidMaterial)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From material where idMaterial={0}", InventarioidMaterial), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }

        public static int ultimoRegistro()
        {
            int? id = null;

            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT MAX(idMaterial) FROM material"), conexion);
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
