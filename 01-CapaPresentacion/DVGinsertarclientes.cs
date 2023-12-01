using _02_CapaNegocios;
using _03_CapaDatos.BaseDeDatos;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class DVGinsertarclientes : Form
    {
        public string Nombre;
        private string Apellido;
        private string Membresia;
        private string Dni;
        private DateTime fechainicio;
        private DateTime fechavencimiento;
        private DateTime fechaNacimiento;
        public DVGinsertarclientes()
        {
            InitializeComponent();
        }

        public class CLienteCAPANEGOCIO
        {
            ClienteBD ClienteBD = new ClienteBD();
            ConexionBaseDeDatos conexionBD = new ConexionBaseDeDatos();
            SqlCommand comandoSql = new SqlCommand();


            public CLienteCAPANEGOCIO()
            {
                // Inicialización del comando SQL aquí si es necesario
                comandoSql.Connection = conexionBD.AbrirConexion();
                comandoSql.CommandText = "INSERT INTO TABLA_CLIENTES VALUES(@Nombres, @Apellidos, @Membresia, @DNI, @FechaNacimiento, @FechaInicio, @FechaVencimiento)";
                // Asignación de parámetros al comando SQL
                comandoSql.Parameters.Add("@Apellidos", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@Nombres", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@Membresia", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@DNI", SqlDbType.VarChar);
                comandoSql.Parameters.Add("@FechaNacimiento", SqlDbType.Date);
                comandoSql.Parameters.Add("@FechaInicio", SqlDbType.DateTime);
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
                comandoSql.Connection = conexionBD.CerrarConexion();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CLienteCAPANEGOCIO CN_clientenuevo = new CLienteCAPANEGOCIO();
            Nombre = textBox1.Text;
            Apellido = textBox2.Text;
            Membresia = textBox3.Text;
            Dni = txt_dni.Text;
            fechaNacimiento = dtp_fechanacimiento.Value;
            fechainicio = dtp_fechainicio.Value;
            fechavencimiento = dtp_fechavencimiento.Value;
            CN_clientenuevo.NuevoCliente(Nombre, Apellido, Membresia, Dni, fechainicio, fechaNacimiento, fechavencimiento);
        }

        private void membresia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DVGinsertarclientes_Load(object sender, EventArgs e)
        {

        }
    }
}
