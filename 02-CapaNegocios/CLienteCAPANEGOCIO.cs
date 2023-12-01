
using _03_CapaDatos.BaseDeDatos;
using System.Data;
using System.Data.SqlClient;

namespace _02_CapaNegocios
{
    namespace _02_CapaNegocios
    {
        public class CLienteCAPANEGOCIO
        {
            ClienteBD ClienteBD = new ClienteBD();
            ConexionBaseDeDatos conexionBD = new ConexionBaseDeDatos();
            SqlCommand comandoSql = new SqlCommand();

            public CLienteCAPANEGOCIO()
            {
                // Inicialización del comando SQL 
                comandoSql.Connection = conexionBD.AbrirConexion();
                comandoSql.CommandText = "INSERT INTO TABLA_CLIENTE VALUES(@Nombres, @Apellidos, @Membresia, @DNI, @FechaNacimiento, @FechaInicio, @FechaVencimiento)";
                // Asignación de parámetros al comando SQL
                comandoSql.Parameters.Add("@Apellidos", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@Nombres", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@Membresia", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@DNI", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@FechaNacimiento", SqlDbType.Date);
                comandoSql.Parameters.Add("@FechaInicio", SqlDbType.Date);
                comandoSql.Parameters.Add("@FechaVencimiento", SqlDbType.Date);
            }

            public DataTable MostrarPersona()
            {
                DataTable tabladedatos = new DataTable();
                tabladedatos = ClienteBD.ObtenerCliente();
                return tabladedatos;
            }

            public void NuevoCliente(string Nombre, string Apellido, string Membresia, string Dni, DateTime FechadeNac, DateTime fechainicio, DateTime fechavencimiento)
            {
                comandoSql.Parameters["@Apellidos"].Value = Apellido;
                comandoSql.Parameters["@Nombres"].Value = Nombre;
                comandoSql.Parameters["@Membresia"].Value = Membresia;
                comandoSql.Parameters["@DNI"].Value = Dni;
                comandoSql.Parameters["@FechaNacimiento"].Value = FechadeNac;
                comandoSql.Parameters["@FechaInicio"].Value = fechainicio;
                comandoSql.Parameters["@FechaVencimiento"].Value = fechavencimiento;

                comandoSql.ExecuteNonQuery();
            }

            
            }
        }
    }
   

