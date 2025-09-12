using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniGUI
{
    public partial class frmbotonera : Form
    {
        public frmbotonera()
        {
            InitializeComponent();
        }

        string[] vecNombres = new string[3];
        int indice = 0;
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            indice++;
            lblDatos.Text = vecNombres[indice];
        }

        private void frmbotonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Martin";
            vecNombres[1] = "Juan";
            vecNombres[2] = "Jose";

            lblDatos.Text = vecNombres[0];
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            indice=indice-1;
            lblDatos.Text = vecNombres[indice];
        }
    }
}
