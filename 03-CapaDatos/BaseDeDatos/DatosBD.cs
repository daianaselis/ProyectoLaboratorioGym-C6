

namespace _03_CapaDatos.BaseDeDatos
{
    
    public class DatosBD
    {
        private const string Servidor = "DESKTOP-M5CAJPN";
        private const string BaseDeDatos = "Proyecto_laboratorio_gym";

        public static string Conexion_alaBaseDeDatos_SinSA =$"Server={Servidor};Initial Catalog={BaseDeDatos};Trusted_Connection=True;";
    }
}
