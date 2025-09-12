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
            ventanaBotonera.Show(); 
        }
    }
}
