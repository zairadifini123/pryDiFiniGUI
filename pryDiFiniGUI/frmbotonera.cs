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
            if (vecNombres.Length > indice)
            {
                lblDatos.Text = vecNombres[indice];
                if ((indice + 1) == vecNombres.Length)
                {
                    btnDerecha.Enabled = false;
                }

                if (indice > 0)
                {
                    btnIzquierda.Enabled = true;
                }
            }

        }

        private void frmbotonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Martin";
            vecNombres[1] = "Juan";
            vecNombres[2] = "Jose";

            lblDatos.Text = vecNombres[0];

            int IndiceCombo = 0;

            while (IndiceCombo < vecNombres.Length) 
            {
                cmbNombres.Items.Add(vecNombres[IndiceCombo]);
                IndiceCombo++;
            } 
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {

            if (indice > 0)
            {
                indice--;
                lblDatos.Text = vecNombres[indice];
                btnDerecha.Enabled = true;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            indice = 0;
            lblDatos.Text = vecNombres[0];
            btnDerecha.Enabled = true;
            btnIzquierda.Enabled = false;
            //indice++;
           

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            indice = 2;
            lblDatos.Text = vecNombres[vecNombres.Length - 1];
            btnDerecha.Enabled = false;
            btnIzquierda.Enabled = true;

            
        }
    }
}
