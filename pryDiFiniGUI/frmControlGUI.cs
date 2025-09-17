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
            frmbotonera ventanaBotonera = new frmbotonera();
            ventanaBotonera.vecNombres[0] = "Hola"; 
            ventanaBotonera.Show();

            int IndiceVectorNombres = 0;
           
        }
    }
}
