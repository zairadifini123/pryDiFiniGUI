namespace pryDiFiniGUI
{
    partial class frmbotonera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDatos = new Label();
            btnIzquierda = new Button();
            btnDerecha = new Button();
            cmbNombres = new ComboBox();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(189, 92);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(64, 15);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "label datos";
            // 
            // btnIzquierda
            // 
            btnIzquierda.BackColor = SystemColors.ActiveCaption;
            btnIzquierda.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzquierda.Location = new Point(135, 141);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(84, 72);
            btnIzquierda.TabIndex = 1;
            btnIzquierda.Text = " ←";
            btnIzquierda.UseVisualStyleBackColor = false;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // btnDerecha
            // 
            btnDerecha.BackColor = SystemColors.ActiveCaption;
            btnDerecha.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDerecha.ForeColor = SystemColors.ActiveCaptionText;
            btnDerecha.Location = new Point(225, 141);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(84, 72);
            btnDerecha.TabIndex = 2;
            btnDerecha.Text = " →";
            btnDerecha.UseVisualStyleBackColor = false;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // cmbNombres
            // 
            cmbNombres.FormattingEnabled = true;
            cmbNombres.Location = new Point(158, 229);
            cmbNombres.Name = "cmbNombres";
            cmbNombres.Size = new Size(121, 23);
            cmbNombres.TabIndex = 3;
            cmbNombres.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmbotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(cmbNombres);
            Controls.Add(btnDerecha);
            Controls.Add(btnIzquierda);
            Controls.Add(lblDatos);
            Name = "frmbotonera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmbotonera";
            Load += frmbotonera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Button btnIzquierda;
        private Button btnDerecha;
        private ComboBox cmbNombres;
    }
}