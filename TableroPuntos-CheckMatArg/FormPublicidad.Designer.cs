namespace TableroPuntos_CheckMatArg
{
    partial class FormPublicidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPublicidad));
            panelImagenPubli = new Panel();
            pictureBox1 = new PictureBox();
            panelImagenPubli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelImagenPubli
            // 
            panelImagenPubli.AutoSize = true;
            panelImagenPubli.Controls.Add(pictureBox1);
            panelImagenPubli.Dock = DockStyle.Fill;
            panelImagenPubli.Location = new Point(0, 0);
            panelImagenPubli.Margin = new Padding(0);
            panelImagenPubli.Name = "panelImagenPubli";
            panelImagenPubli.Size = new Size(1370, 749);
            panelImagenPubli.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1370, 749);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormPublicidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelImagenPubli);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(1900, 0);
            Name = "FormPublicidad";
            StartPosition = FormStartPosition.Manual;
            Text = "Panel de Anuncios";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormPublicidad_FormClosed;
            panelImagenPubli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelImagenPubli;
        internal PictureBox pictureBox1;
    }
}