using _02_CapaNegocios;
using _02_CapaNegocios._02_CapaNegocios;
using _03_CapaDatos.BaseDeDatos;

namespace _01_CapaPresentacion
{
    public partial class MenuInicio : Form
    {
        ClaseDeNegociosTEST claseDeNegociosTEST = new ClaseDeNegociosTEST();
        CLienteCAPANEGOCIO cn_Cliente = new CLienteCAPANEGOCIO();
        private int indice;
        public MenuInicio()
        {
            InitializeComponent();

        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {

        }


        private void PoblarDGV()
        {
            datagvmostrar.DataSource = cn_Cliente.MostrarPersona();
        }
        private void LimpiarDGV()
        {
            datagvmostrar.DataSource = null;
            datagvmostrar.Columns.Clear();
        }

        private void actualizarDatos()
        {
            MenuInicio menuInicio = Owner as MenuInicio;
            menuInicio.PoblarDGV();
            AddOwnedForm(menuInicio);
            menuInicio.Show();
        }

        private void mostrarDatosCLienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoblarDGV();
        }

        private void limpiarDGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarDGV();
        }

        private void agregarUnaNuevaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form formulario = new DVGinsertarclientes();
            formulario.ShowDialog();
        }

        private void modificarDatosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrarDatosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datagvmostrar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            indice = datagvmostrar.CurrentRow.Index;
            //var DVGinsertarclientes= new DVGinsertarclientes();
            //DVGinsertarclientes.ShowDialog();
            label1.Text=indice.ToString();

        }
    }
}