namespace pryDiFiniGUI
{
    public partial class frmControles : Form
    {
        public frmControles()
        {
            InitializeComponent();
        }

        private void btnBotonera_Click(object sender, EventArgs e)
        {
            // Crear la ventana
            frmbotonera ventanaBotonera = new frmbotonera();

            // Agregar "Hola" a la primera posición vacía del vector
            for (int i = 0; i < ventanaBotonera.vecNombres.Length; i++)
            {
                if (string.IsNullOrEmpty(ventanaBotonera.vecNombres[i]))
                {
                    ventanaBotonera.vecNombres[i] = "Hola";
                    break;
                }
            }

            // Agregar "Hola" al ListBox lstResultados en este formulario
            lstResultados.Items.Add("Hola");

            // Mostrar el formulario frmbotonera
            ventanaBotonera.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
