using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableroPuntos_CheckMatArg
{

    public partial class FormTablero : Form
    {
        FormControlPublicidad formControlPublicidad = new FormControlPublicidad();
        internal Boolean cerradoTablero = false;
        public FormTablero()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            mostrarImagenesPubliTablero();

        }

        internal void mostrarImagenesPubliTablero()
        {
            //Actualiza la publicidad del tablero
            if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
            {
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                {
                    this.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;
                }
                if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                {
                    this.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
                }
            }
            else this.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;
        }

        private void labelNombre1_T_Click(object sender, EventArgs e)
        {

        }

        private void FormTablero_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerradoTablero = true;
        }

        
    }
}
