namespace pryDiFiniGUI
{
    partial class frmControles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBotonera = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnBotonera
            // 
            btnBotonera.Location = new Point(31, 31);
            btnBotonera.Name = "btnBotonera";
            btnBotonera.Size = new Size(105, 23);
            btnBotonera.TabIndex = 0;
            btnBotonera.Text = "Abrir botonera";
            btnBotonera.UseVisualStyleBackColor = true;
            btnBotonera.Click += btnBotonera_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(31, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(346, 184);
            listBox1.TabIndex = 1;
            // 
            // frmControles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(listBox1);
            Controls.Add(btnBotonera);
            Name = "frmControles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de interfaz grafica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBotonera;
        private ListBox listBox1;
    }
}
