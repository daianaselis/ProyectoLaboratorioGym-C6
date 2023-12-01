using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CapaDatos.BaseDeDatos
{
    public class ClienteBD
    {
        ConexionBaseDeDatos conexionBD = new ConexionBaseDeDatos();
        SqlCommand comandoSql = new SqlCommand();

        public DataTable ObtenerCliente()
        {
            var table = new DataTable();
            comandoSql.Connection = conexionBD.AbrirConexion();
            comandoSql.CommandText = "SELECT*FROM TABLA_CLIENTES";
            SqlDataReader LEER = comandoSql.ExecuteReader();
            table.Load(LEER);
            conexionBD.CerrarConexion();
            return table;
        }

      
    }
}
