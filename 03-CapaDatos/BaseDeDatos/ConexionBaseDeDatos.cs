using System.Data.SqlClient;
using System.Windows.Forms;

namespace _03_CapaDatos.BaseDeDatos
{
    public class ConexionBaseDeDatos
    {
        public SqlConnection ConexionBaseDtos = new SqlConnection(DatosBD.Conexion_alaBaseDeDatos_SinSA);
        public SqlConnection AbrirConexion()
        {
            try {
                ConexionBaseDtos.Open();
                return ConexionBaseDtos;
            }
            catch (Exception Excepcion) {
                MessageBox.Show($"Error al abrir la conexion: {Excepcion.Message}");
                return null;
            }
        }
        public SqlConnection CerrarConexion()
        {
            try
            {
                if (ConexionBaseDtos.State == System.Data.ConnectionState.Open) ConexionBaseDtos.Close();
                return ConexionBaseDtos;

            }
            catch (Exception Excepcion)
            {
                MessageBox.Show($"Error al cerrar conexion:{Excepcion.Message}");
                return null;
            }
        }
        public SqlConnection EstadoDelaconexion()
        {
            MessageBox.Show($"Conexion Exitosa: El estado de la conexion es: {ConexionBaseDtos.State}");
            return ConexionBaseDtos;
        }
    }

}
