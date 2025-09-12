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
            button1 = new Button();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(197, 77);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(64, 15);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "label datos";
            // 
            // btnIzquierda
            // 
            btnIzquierda.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzquierda.Location = new Point(135, 141);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(84, 72);
            btnIzquierda.TabIndex = 1;
            btnIzquierda.Text = " ←";
            btnIzquierda.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(225, 141);
            button1.Name = "button1";
            button1.Size = new Size(84, 72);
            button1.TabIndex = 2;
            button1.Text = " →";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmbotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(button1);
            Controls.Add(btnIzquierda);
            Controls.Add(lblDatos);
            Name = "frmbotonera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmbotonera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Button btnIzquierda;
        private Button button1;
    }
}