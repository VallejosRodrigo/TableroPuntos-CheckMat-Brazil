using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TableroPuntos_CheckMatArg
{
    public partial class FormPublicidad : Form
    {
        FormControlPublicidad formControlPublicidad = new FormControlPublicidad();
        internal Boolean cerradoPubliPanel = false;
        public FormPublicidad()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            mostrarImagenesPubliTablero();

        }

        internal void mostrarImagenesPubliTablero()
        {
            if (formControlPublicidad.archivosPubliPanel.Length >= 0)
            {
                try
                {
                    this.pictureBox1.ImageLocation = formControlPublicidad.archivosPubliPanel[0];
                }
                catch
                {
                    this.pictureBox1.Image = null;
                }
            }
            else
                this.pictureBox1.Image = null;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormPublicidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerradoPubliPanel = true;
        }
    }
}
