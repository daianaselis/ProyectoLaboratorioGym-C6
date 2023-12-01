using _03_CapaDatos.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CapaNegocios
{
   public class ClasesgymCN
    {
        SqlCommand comandoSql = new SqlCommand();
        ConexionBaseDeDatos conexionBD = new ConexionBaseDeDatos();
        ClienteBD ClienteBD = new ClienteBD();


        public DataTable ObtenerCliente()
        {
            var table = new DataTable();
            comandoSql.Connection = conexionBD.AbrirConexion();
            comandoSql.CommandText = "SELECT*FROM TABLA_CLASES";
            SqlDataReader LEER = comandoSql.ExecuteReader();
            table.Load(LEER);
            conexionBD.CerrarConexion();
            return table;
        }
        public DataTable MostrarPersona()
        {
            DataTable tabladedatos = new DataTable();
            tabladedatos = ClienteBD.ObtenerCliente();
            return tabladedatos;
        }
    }
}
