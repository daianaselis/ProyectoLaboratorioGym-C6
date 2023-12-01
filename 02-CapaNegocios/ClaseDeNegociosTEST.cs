
using _03_CapaDatos.BaseDeDatos;

namespace _02_CapaNegocios
{
    public class ClaseDeNegociosTEST
    {
        ConexionBaseDeDatos _ConexionBaseDeDatos = new ConexionBaseDeDatos();
        public void TestDeBaseDeDatos()
        {
            _ConexionBaseDeDatos.EstadoDelaconexion();
        }
    }
}
