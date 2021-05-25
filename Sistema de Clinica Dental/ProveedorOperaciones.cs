using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sistema_de_Clinica_Dental;

namespace WindowsFormsApplication1
{
    class ProveedorOperaciones
    {
        public static int Agregar(Proveedor Proveedores)
        {

            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into proveedor (Nombre_empresa,Telefono,Calle, Numero, Colonia, Estado, Municipio, Codigo_Postal) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
               Proveedores.Nombre_empresa,Proveedores.Telefono, Proveedores.Calle, Proveedores.Numero, Proveedores.Colonia, Proveedores.Estado, Proveedores.Municipio, Proveedores.CP), conexion );
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public Proveedor Actualizacion { get; set; }

        public static List<Proveedor> Buscar(int idProveedor,String ProveedoresNombre_empresa)
        {
            List<Proveedor> _lista = new List<Proveedor>();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM proveedor WHERE idProveedor ='{0}' OR Nombre_empresa LIKE CONCAT ('%',?nom,'%')", idProveedor), conexion);
            _comando.Parameters.AddWithValue("?nom", ProveedoresNombre_empresa);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Proveedor Proveedores  = new Proveedor();
                Proveedores.idProveedor= _reader.GetInt32(0);
                Proveedores.Nombre_empresa = _reader.GetString(1);
                Proveedores.Telefono = _reader.GetString(2);
                Proveedores.Calle = _reader.GetString(3);
                Proveedores.Numero = _reader.GetInt16(4);
                Proveedores.Colonia = _reader.GetString(5);
                Proveedores.Estado = _reader.GetString(6);
                Proveedores.Municipio = _reader.GetString(7);
                Proveedores.CP = _reader.GetString(8);
                //Proveedores.Material = _reader.GetString(4);


                _lista.Add(Proveedores);
            }

            return _lista;
        }
        public static List<Proveedor> Mostrar()
        {
            List<Proveedor> registros= new List<Proveedor>();
            MySqlConnection conectar = ConexionALaBD.conectar();
            conectar.Open();
            MySqlCommand comando = new MySqlCommand(String.Format( "SELECT * FROM proveedor "), conectar);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Proveedor Proveedores = new Proveedor();
                Proveedores.idProveedor = reader.GetInt32(0);
                Proveedores.Nombre_empresa = reader.GetString(1);
                Proveedores.Telefono = reader.GetString(2);
                Proveedores.Calle = reader.GetString(3);
                Proveedores.Numero = reader.GetInt16(4);
                Proveedores.Colonia = reader.GetString(5);
                Proveedores.Estado = reader.GetString(6);
                Proveedores.Municipio = reader.GetString(7);
                Proveedores.CP = reader.GetString(8);
               // Proveedores.Material = reader.GetString(4);
                registros.Add(Proveedores);
            }

            return registros;
        }
        public static Proveedor ObtenerProveedor(int ProveedoresidProveedor)
        {
            Proveedor Proveedores = new Proveedor();
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM proveedor where idProveedor={0}", ProveedoresidProveedor), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Proveedores.idProveedor = _reader.GetInt32(0);
                Proveedores.Nombre_empresa = _reader.GetString(1);
                Proveedores.Telefono = _reader.GetString(2);
                Proveedores.Calle = _reader.GetString(3);
                Proveedores.Numero = _reader.GetInt16(4);
                Proveedores.Colonia = _reader.GetString(5);
                Proveedores.Estado = _reader.GetString(6);
                Proveedores.Municipio = _reader.GetString(7);
                Proveedores.CP = _reader.GetString(8);
              // Proveedores.Material = _reader.GetString(4);

            }

            conexion.Close();
            return Proveedores;

        }
        public static int Actualizar(Proveedor Proveedores)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(string.Format("Update proveedor set Nombre_empresa='{0}',Telefono ='{1}', Calle='{2}', Numero='{3}', Colonia='{4}', Estado='{5}', Municipio='{6}', Codigo_Postal='{7}'   where idProveedor='{8}'",
                Proveedores.Nombre_empresa, Proveedores.Telefono, Proveedores.Calle, Proveedores.Numero, Proveedores.Colonia, Proveedores.Estado, Proveedores.Municipio, Proveedores.CP,Proveedores.idProveedor), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }
        public static int Eliminar(int ProveedoridProveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = ConexionALaBD.conectar();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(string.Format("Delete from proveedor where idProveedor={0}", ProveedoridProveedor), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }

    }
}
