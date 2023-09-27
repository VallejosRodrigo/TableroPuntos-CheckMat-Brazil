using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TableroPuntos_CheckMatArg
{
    public partial class FormControlPublicidad : Form
    {
        internal Boolean cerradoControladorPubli = false;

        internal int n;

        internal string carpetaImagenesPubliTablero, rutaArchivoPubliTablero, rutaDestinoPubliTablero;
        internal string carpetaImagenesPubliPanel, rutaArchivoPubliPanel, rutaDestinoPubliPanel;
        internal string[] archivosPubliPanel;

        public FormControlPublicidad()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;


            CrearDirectorioPubliTablero();
            EjecutarArchivoImagenPubliTablero();

            CrearDirectorioPubliPanel();
            EjecutarArchivoImagenPubliPanel();


        }


        internal void CrearDirectorioPubliPanel()
        {
            string carpetaProyectoPubliPanel = AppDomain.CurrentDomain.BaseDirectory;
            carpetaImagenesPubliPanel = Path.Combine(carpetaProyectoPubliPanel, "AnunciosEnPanel_Publicitario");

            // Verifica si la carpeta de Imágenes existe, y si no, créala
            if (!Directory.Exists(carpetaImagenesPubliPanel))
            {
                Directory.CreateDirectory(carpetaImagenesPubliPanel);
            }
        }

        internal void EjecutarArchivoImagenPubliPanel()
        {
            archivosPubliPanel = Directory.GetFiles(carpetaImagenesPubliPanel);

            if (archivosPubliPanel.Length >= 0)
            {
                try
                {
                    foreach (string archivo in archivosPubliPanel)
                    {
                        string nombreArchivoPubliPanel = Path.GetFileName(archivo);

                        //cargar inmagen                         
                        rutaArchivoPubliPanel = Path.Combine(carpetaImagenesPubliPanel, nombreArchivoPubliPanel);
                        dataGridView1.Rows.Add(nombreArchivoPubliPanel);
                    }
                    if (File.Exists(archivosPubliPanel[0]))
                        pictureBox1.ImageLocation = archivosPubliPanel[0];

                    else if (File.Exists(rutaArchivoPubliPanel))
                        pictureBox1.ImageLocation = rutaArchivoPubliPanel;
                }
                catch { }
            }
        }

        internal void CrearDirectorioPubliTablero()
        {
            string carpetaProyectoPubliTablero = AppDomain.CurrentDomain.BaseDirectory;
            carpetaImagenesPubliTablero = Path.Combine(carpetaProyectoPubliTablero, "Anuncios");

            // Verifica si la carpeta de Imágenes existe, y si no, créala
            if (!Directory.Exists(carpetaImagenesPubliTablero))
                Directory.CreateDirectory(carpetaImagenesPubliTablero);
        }

        internal void EjecutarArchivoImagenPubliTablero()
        {

            string[] archivos = Directory.GetFiles(carpetaImagenesPubliTablero);


            if (archivos.Length >= 0)
            {
                try
                {
                    foreach (string archivo in archivos)
                    {
                        string nombreArchivoPubliTablero = Path.GetFileName(archivo);

                        //cargar inmagen                         
                        rutaArchivoPubliTablero = Path.Combine(carpetaImagenesPubliTablero, nombreArchivoPubliTablero);
                    }
                    if (File.Exists(rutaArchivoPubliTablero))
                        pictureBox2.ImageLocation = rutaArchivoPubliTablero;
                }
                catch { }
            }
            pictureBox2.Image ??= Properties.Resources.checkFrente;


        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos de imagem|*.jpg;*.png;*.bmp;*.jpeg";
            openFileDialog1.Title = "Escolha uma imagem para o painel de anúncios";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string filePath in openFileDialog1.FileNames)
                    {
                        // Obtener el nombre del archivo
                        string nombreArchivoImagenPubliPanel = Path.GetFileName(filePath);
                        rutaDestinoPubliPanel = Path.Combine(carpetaImagenesPubliPanel, nombreArchivoImagenPubliPanel);

                        //Guarda archivo nuevo
                        File.Copy(filePath, rutaDestinoPubliPanel);

                        // Cargar la imagen desde el archivo
                        pictureBox1.ImageLocation = filePath;
                    }

                    //limpiar lista
                    dataGridView1.Rows.Clear();

                    archivosPubliPanel = Directory.GetFiles(carpetaImagenesPubliPanel);


                    if (archivosPubliPanel.Length >= 0)
                    {
                        try
                        {
                            foreach (string archivo in archivosPubliPanel)
                            {
                                string nombreArchivoPubliPanel = Path.GetFileName(archivo);

                                //cargar dataGridView1                        
                                rutaArchivoPubliPanel = Path.Combine(carpetaImagenesPubliPanel, nombreArchivoPubliPanel);
                                dataGridView1.Rows.Add(nombreArchivoPubliPanel);
                            }
                        }
                        catch { }
                    }
                }
                catch
                {
                    MessageBox.Show("A Imagem já existe");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
                pictureBox1.ImageLocation = archivosPubliPanel[n];
        }

        private void buttonEliminarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(archivosPubliPanel[n]))
                {
                    dataGridView1.Rows.RemoveAt(n);
                    File.Delete(archivosPubliPanel[n]);

                    dataGridView1.Rows.Clear();
                    EjecutarArchivoImagenPubliPanel();

                    pictureBox1.Image = null;
                }
            }
            catch { }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("À esquerda, você encontrará a seção para carregar os anúncios no painel publicitário." +
                "\r\nClicando em \"Examinar...\", você poderá carregar suas imagens publicitárias.\nResolução recomendada: 1386;788\n\r\n\nVocê pode preencher " +
                "a lista com anúncios, que serão exibidos a cada 15 segundos se você pressionar o botão \"Sequência " +
                "Inicial\" localizado no controlador principal.\r\n\n\nTambém é possível remover as imagens desejadas ao " +
                "pressionar o botão \"Remover\".\r\n\r\nÀ direita, você encontrará a seção para alterar a imagem do " +
                "marcador de pontos. Basta clicar em \"Altere a imagem do marcador de Pontos\".\nResolução recomendada: 836;219\n\r\r\nQuando estiver " +
                "satisfeito com suas seleções, basta sair do Controlador de Anúncios pressionando a tecla \"Sair\" e " +
                "tudo será salvo automaticamente.");
        }

        internal void button3_Click_1(object sender, EventArgs e)
        {

            //borrar todos los archivos de la carpeta
            string[] archivos = Directory.GetFiles(carpetaImagenesPubliTablero);
            if (archivos.Length >= 0)
            {
                try
                {
                    foreach (string archivo in archivos)
                        File.Delete(archivo);
                }
                catch { }
            }
            else
                MessageBox.Show("A imagem não foi encontrada");


            //Abre Imagen:
            openFileDialog1.Filter = "Arquivos de imagem|*.jpg;*.png;*.bmp;*.jpeg";
            openFileDialog1.Title = "Escolha uma imagem para o Marcador de pontos";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string filePath in openFileDialog1.FileNames)
                    {
                        // Cargar la imagen desde el archivo
                        pictureBox2.ImageLocation = filePath;

                        // Obtener el nombre del archivo
                        string nombreArchivoImagenTablerox = Path.GetFileName(filePath);
                        rutaDestinoPubliTablero = Path.Combine(carpetaImagenesPubliTablero, nombreArchivoImagenTablerox);

                        //Guarda archivo nuevo
                        File.Copy(filePath, rutaDestinoPubliTablero);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você deve inserir um arquivo de imagem\n\n\nError: " + ex.Message);
                }
            }
            else    //Si no hay imagen, pone una por defecto
            {
                if (rutaArchivoPubliTablero != null)
                    this.pictureBox2.Image = Properties.Resources.checkFrente;

                if (rutaDestinoPubliTablero != null)
                    this.pictureBox2.Image = Properties.Resources.checkFrente;

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormControlPublicidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerradoControladorPubli = true;
        }
    }
}