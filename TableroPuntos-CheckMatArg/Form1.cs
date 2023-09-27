using System.Windows.Forms;

namespace TableroPuntos_CheckMatArg
{
    public partial class Form1 : Form
    {
        private FormTablero formTablero = new();
        private FormPublicidad formPublicidad = new();
        private FormPresentacion formPresentacion = new();
        private FormControlPublicidad formControlPublicidad = new();




        private int contadorVerde1 = 0, contadorVerde2 = 0, contadorAmarillo1 = 0,
            contadorAmarillo2 = 0, contadorRojo1 = 0, contadorRojo2 = 0,
            segundos = 0, minutos = 0, currentIndex = 0;





        public Form1()
        {
            InitializeComponent();

            timer2.Start();

            formPresentacion.ShowDialog();
            formPresentacion.Close();
            formPresentacion.Dispose();

            formControlPublicidad.Close();
            formControlPublicidad.Dispose();

            formTablero.Close();
            formTablero.Dispose();

            formPublicidad.Close();
            formPublicidad.Dispose();
        }


        private void buttonA1_Vmas_Click(object sender, EventArgs e)
        {
            contadorVerde1++;
            if (contadorVerde1 < 100 && contadorVerde1 >= 0)
            {
                labelResultadoVerde1.Text = $"{contadorVerde1}"; //mostrar en Controlador
                formTablero.labelVerde1_T.Text = $"{contadorVerde1}"; //mostrar en Tablero
            }
            else
            {
                contadorVerde1 = 0;
                labelResultadoVerde1.Text = $"{contadorVerde1}";
                formTablero.labelVerde1_T.Text = $"{contadorVerde1}";
            }
        }

        private void buttonA1_Vmenos_Click(object sender, EventArgs e)
        {
            contadorVerde1--;
            if (contadorVerde1 < 100 && contadorVerde1 >= 0)
            {
                labelResultadoVerde1.Text = $"{contadorVerde1}";
                formTablero.labelVerde1_T.Text = $"{contadorVerde1}";
            }
            else
            {
                contadorVerde1 = 0;
                labelResultadoVerde1.Text = $"{contadorVerde1}";
                formTablero.labelVerde1_T.Text = $"{contadorVerde1}";
            }
        }

        private void buttonA2_Vmas_Click(object sender, EventArgs e)
        {
            contadorVerde2++;
            if (contadorVerde2 < 100 && contadorVerde2 >= 0)
            {
                labelResultadoVerde2.Text = $"{contadorVerde2}";
                formTablero.labelVerde2_T.Text = $"{contadorVerde2}";
            }
            else
            {
                contadorVerde2 = 0;
                labelResultadoVerde2.Text = $"{contadorVerde2}";
                formTablero.labelVerde2_T.Text = $"{contadorVerde2}";
            }
        }

        private void buttonA2_Vmenos_Click(object sender, EventArgs e)
        {
            contadorVerde2--;
            if (contadorVerde2 < 100 && contadorVerde2 >= 0)
            {
                labelResultadoVerde2.Text = $"{contadorVerde2}";
                formTablero.labelVerde2_T.Text = $"{contadorVerde2}";
            }
            else
            {
                contadorVerde2 = 0;
                labelResultadoVerde2.Text = $"{contadorVerde2}";
                formTablero.labelVerde2_T.Text = $"{contadorVerde2}";
            }
        }

        private void buttonA1_Amas_Click(object sender, EventArgs e)
        {
            contadorAmarillo1++;
            if (contadorAmarillo1 < 100 && contadorAmarillo1 >= 0)
            {
                labelResultadoAmarillo1.Text = $"{contadorAmarillo1}";
                formTablero.labelAmarillo1_T.Text = $"{contadorAmarillo1}";
            }
            else
            {
                contadorAmarillo1 = 0;
                labelResultadoAmarillo1.Text = $"{contadorAmarillo1}";
                formTablero.labelAmarillo1_T.Text = $"{contadorAmarillo1}";
            }
        }

        private void buttonA1_Amenos_Click(object sender, EventArgs e)
        {
            contadorAmarillo1--;
            if (contadorAmarillo1 < 100 && contadorAmarillo1 >= 0)
            {
                labelResultadoAmarillo1.Text = $"{contadorAmarillo1}";
                formTablero.labelAmarillo1_T.Text = $"{contadorAmarillo1}";
            }
            else
            {
                contadorAmarillo1 = 0;
                labelResultadoAmarillo1.Text = $"{contadorAmarillo1}";
                formTablero.labelAmarillo1_T.Text = $"{contadorAmarillo1}";
            }
        }

        private void buttonA2_Amas_Click(object sender, EventArgs e)
        {
            contadorAmarillo2++;
            if (contadorAmarillo2 < 100 && contadorAmarillo2 >= 0)
            {
                labelResultadoAmarillo2.Text = $"{contadorAmarillo2}";
                formTablero.labelAmarillo2_T.Text = $"{contadorAmarillo2}";
            }
            else
            {
                contadorAmarillo2 = 0;
                labelResultadoAmarillo2.Text = $"{contadorAmarillo2}";
                formTablero.labelAmarillo2_T.Text = $"{contadorAmarillo2}";
            }
        }

        private void buttonA2_Amenos_Click(object sender, EventArgs e)
        {
            contadorAmarillo2--;
            if (contadorAmarillo2 < 100 && contadorAmarillo2 >= 0)
            {
                labelResultadoAmarillo2.Text = $"{contadorAmarillo2}";
                formTablero.labelAmarillo2_T.Text = $"{contadorAmarillo2}";
            }
            else
            {
                contadorAmarillo2 = 0;
                labelResultadoAmarillo2.Text = $"{contadorAmarillo2}";
                formTablero.labelAmarillo2_T.Text = $"{contadorAmarillo2}";
            }
        }

        private void buttonA1_Rmas_Click(object sender, EventArgs e)
        {
            contadorRojo1++;
            if (contadorRojo1 < 100 && contadorRojo1 >= 0)
            {
                labelResultadoRojo1.Text = $"{contadorRojo1}";
                formTablero.labelRojo1_T.Text = $"{contadorRojo1}";
            }
            else
            {
                contadorRojo1 = 0;
                labelResultadoRojo1.Text = $"{contadorRojo1}";
                formTablero.labelRojo1_T.Text = $"{contadorRojo1}";
            }
        }

        private void buttonA1_Rmenos_Click(object sender, EventArgs e)
        {
            contadorRojo1--;
            if (contadorRojo1 < 100 && contadorRojo1 >= 0)
            {
                labelResultadoRojo1.Text = $"{contadorRojo1}";
                formTablero.labelRojo1_T.Text = $"{contadorRojo1}";
            }
            else
            {
                contadorRojo1 = 0;
                labelResultadoRojo1.Text = $"{contadorRojo1}";
                formTablero.labelRojo1_T.Text = $"{contadorRojo1}";
            }
        }

        private void buttonA2_Rmas_Click(object sender, EventArgs e)
        {
            contadorRojo2++;
            if (contadorRojo2 < 100 && contadorRojo2 >= 0)
            {
                labelResultadoRojo2.Text = $"{contadorRojo2}";
                formTablero.labelRojo2_T.Text = $"{contadorRojo2}";
            }
            else
            {
                contadorRojo2 = 0;
                labelResultadoRojo2.Text = $"{contadorRojo2}";
                formTablero.labelRojo2_T.Text = $"{contadorRojo2}";
            }
        }

        private void buttonA2_Rmenos_Click(object sender, EventArgs e)
        {
            contadorRojo2--;
            if (contadorRojo2 < 100 && contadorRojo2 >= 0)
            {
                labelResultadoRojo2.Text = $"{contadorRojo2}";
                formTablero.labelRojo2_T.Text = $"{contadorRojo2}";
            }
            else
            {
                contadorRojo2 = 0;
                labelResultadoRojo2.Text = $"{contadorRojo2}";
                formTablero.labelRojo2_T.Text = $"{contadorRojo2}";
            }
        }

        //Botones Control Tablero, enviar Nombres y academias al tablero
        private void buttonEnviarNombre1_Click(object sender, EventArgs e)
        {
            formTablero.labelNombre1_T.Text = textBoxNombre1.Text;
            labelNombre1.Text = textBoxNombre1.Text;
            textBoxNombre1.Text = string.Empty;
        }

        private void buttonEnviarAcademia1_Click(object sender, EventArgs e)
        {
            formTablero.labelAcademia1_T.Text = textBoxAcademia1.Text;
            labelAcademia1.Text = textBoxAcademia1.Text;
            textBoxAcademia1.Text = string.Empty;
        }

        private void buttonEnviarNombre2_Click(object sender, EventArgs e)
        {
            formTablero.labelNombre2_T.Text = textBoxNombre2.Text;
            labelNombre2.Text = textBoxNombre2.Text;
            textBoxNombre2.Text = string.Empty;
        }

        private void buttonEnviarAcademia2_Click(object sender, EventArgs e)
        {
            formTablero.labelAcademia2_T.Text = textBoxAcademia2.Text;
            labelAcademia2.Text = textBoxAcademia2.Text;
            textBoxAcademia2.Text = string.Empty;
        }

        //Limpiar Controlador atleta 1 y 2
        private void button1_Click(object sender, EventArgs e)
        {
            contadorVerde1 = 0;
            contadorAmarillo1 = 0;
            contadorRojo1 = 0;
            //cambios en Tablero
            formTablero.labelVerde1_T.Text = $"{contadorVerde1}";
            formTablero.labelAmarillo1_T.Text = $"{contadorAmarillo1}";
            formTablero.labelRojo1_T.Text = $"{contadorRojo1}";

            formTablero.labelNombre1_T.Text = "";
            formTablero.labelAcademia1_T.Text = "";
            //Cambios en Controlador
            labelResultadoVerde1.Text = $"{contadorVerde1}";
            labelResultadoAmarillo1.Text = $"{contadorAmarillo1}";
            labelResultadoRojo1.Text = $"{contadorRojo1}";
            textBoxNombre1.Text = "";
            textBoxAcademia1.Text = "";
            labelNombre1.Text = "Nome e Sobrenome do Atleta 1:";
            labelAcademia1.Text = "Academia 1:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorVerde2 = 0;
            contadorAmarillo2 = 0;
            contadorRojo2 = 0;
            //cambios en Tablero
            formTablero.labelVerde2_T.Text = $"{contadorVerde2}";
            formTablero.labelAmarillo2_T.Text = $"{contadorAmarillo2}";
            formTablero.labelRojo2_T.Text = $"{contadorRojo2}";

            formTablero.labelNombre2_T.Text = "";
            formTablero.labelAcademia2_T.Text = "";
            //Cambios en Controlador
            labelResultadoVerde2.Text = $"{contadorVerde2}";
            labelResultadoAmarillo2.Text = $"{contadorAmarillo2}";
            labelResultadoRojo2.Text = $"{contadorRojo2}";
            textBoxNombre2.Text = "";
            textBoxAcademia2.Text = "";
            labelNombre2.Text = "Nome e Sobrenome do Atleta 2:";
            labelAcademia2.Text = "Academia 2:";
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;

            if (segundos < 0)
            {
                segundos = 59;
                minutos--;
            }

            if (minutos < 0)
            {
                minutos = 0;
                segundos = 0;
            }

            if (segundos == 0 && minutos == 0)
            {
                formTablero.labelCronometro_T.BackColor = Color.Red;
                formTablero.labelCronometro_T.ForeColor = Color.White;
                labelCronometro.BackColor = Color.DarkRed;
                labelCronometro.ForeColor = Color.Black;

                timerTiempoFinal.Start();

                formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.tempo;
            }
            string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");
            labelCronometro.Text = tiempoFormateado;
            formTablero.labelCronometro_T.Text = tiempoFormateado;
        }

        //iniciar, detener y reiniciar timer -> temporizador
        private void buttonTimerIniciar_Click(object sender, EventArgs e)
        {
            if (segundos == 0 && minutos == 0)
            {

            }
            else timer1.Start();
        }

        //parar temporizador
        private void buttonTimerParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }
        //reiniciar temporizador
        private void buttonTimerReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            segundos = 0;
            minutos = 0;

            //Actualiza la publicidad del tablero
            if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
            {
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                {
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;
                }
                if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                {
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
                }
            }
            else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;


            formTablero.labelCronometro_T.BackColor = Color.Black;
            formTablero.labelCronometro_T.ForeColor = Color.Lime;

            labelCronometro.BackColor = Color.Black;
            labelCronometro.ForeColor = Color.Lime;

            string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");
            labelCronometro.Text = tiempoFormateado;
            formTablero.labelCronometro_T.Text = tiempoFormateado;
        }

        //Abrir, cerrar y maximizar tablero desde Controlador
        private void buttonAbrirTablero_Click(object sender, EventArgs e)
        {
            if (formTablero == null || formTablero.IsDisposed)
            {
                formTablero = new FormTablero();
                formTablero.Show();

                //actualiza puntos
                formTablero.labelVerde1_T.Text = labelResultadoVerde1.Text;
                formTablero.labelAmarillo1_T.Text = labelResultadoAmarillo1.Text;
                formTablero.labelRojo1_T.Text = labelResultadoRojo1.Text;
                formTablero.labelVerde2_T.Text = labelResultadoVerde2.Text;
                formTablero.labelAmarillo2_T.Text = labelResultadoAmarillo2.Text;
                formTablero.labelRojo2_T.Text = labelResultadoRojo2.Text;
                //actualiza el temporizador en pantalla
                formTablero.labelCronometro_T.Text = labelCronometro.Text;
                //cambia colores en botones
                buttonAbrirTablero.BackColor = Color.Lime;
                buttonAbrirTablero.ForeColor = Color.Black;
                button4.BackColor = Color.Lime;
                button4.ForeColor = Color.Black;

                //actualiza nomnbre y academia atletas
                if (labelNombre1.Text == "Nome e Sobrenome do Atleta 1:")
                    formTablero.labelNombre1_T.Text = "";
                else
                    formTablero.labelNombre1_T.Text = labelNombre1.Text;

                if (labelNombre2.Text == "Nome e Sobrenome do Atleta 2:")
                    formTablero.labelNombre2_T.Text = "";
                else
                    formTablero.labelNombre2_T.Text = labelNombre2.Text;

                if (labelAcademia1.Text == "Academia 1:")
                    formTablero.labelAcademia1_T.Text = "";
                else
                    formTablero.labelAcademia1_T.Text = labelAcademia1.Text;

                if (labelAcademia2.Text == "Academia 2:")
                    formTablero.labelAcademia2_T.Text = "";
                else
                    formTablero.labelAcademia2_T.Text = labelAcademia2.Text;
            }
            else formTablero.Focus();

            if (!formPublicidad.IsDisposed || formPublicidad != null)
            {
                formPublicidad.Close();
                formPublicidad.Dispose();
                timerCambioPubli.Stop();
                timerCambioPubli.Dispose();

                button8.BackColor = Color.DarkGray;
                button8.ForeColor = Color.Black;

                buttonIniciarPubli.BackColor = Color.DarkGray;
                buttonIniciarPubli.ForeColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            formTablero.Close();
            formTablero.Dispose();
            buttonAbrirTablero.BackColor = Color.Black;
            buttonAbrirTablero.ForeColor = Color.Lime;
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.Lime;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (formTablero != null && !formTablero.IsDisposed)
            {
                formTablero.FormBorderStyle = FormBorderStyle.None;//quita marco del forms
                formTablero.WindowState = FormWindowState.Maximized; //agranda al maximo la ventana
                button4.BackColor = Color.Lime;
                button4.ForeColor = Color.Black;
            }
        }

        //minimiza el tablero
        private void button5_Click(object sender, EventArgs e)
        {
            if (formTablero != null && !formTablero.IsDisposed)
            {
                formTablero.WindowState = FormWindowState.Normal;
                formTablero.FormBorderStyle = FormBorderStyle.Sizable;
                button4.BackColor = Color.Black;
                button4.ForeColor = Color.Lime;
            }
        }

        //Envia Texto al tablero desde Control presionando tecla enter.
        private void textBoxNombre1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // Evita que se emita el sonido de "ding" al presionar Enter
                formTablero.labelNombre1_T.Text = textBoxNombre1.Text;  // Asigna el texto del TextBox al Label
                labelNombre1.Text = textBoxNombre1.Text;
                textBoxNombre1.Text = string.Empty;
            }
        }

        private void textBoxAcademia1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                formTablero.labelAcademia1_T.Text = textBoxAcademia1.Text;
                labelAcademia1.Text = textBoxAcademia1.Text;
                textBoxAcademia1.Text = string.Empty;
            }
        }

        private void textBoxNombre2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                formTablero.labelNombre2_T.Text = textBoxNombre2.Text;
                labelNombre2.Text = textBoxNombre2.Text;
                textBoxNombre2.Text = string.Empty;
            }
        }

        private void textBoxAcademia2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                formTablero.labelAcademia2_T.Text = textBoxAcademia2.Text;
                labelAcademia2.Text = textBoxAcademia2.Text;
                textBoxAcademia2.Text = string.Empty;
            }
        }

        //cierra panel de publicidad
        private void buttonFinPubli_Click(object sender, EventArgs e)
        {
            if (!formPublicidad.IsDisposed || formPublicidad != null)
            {
                formPublicidad.Close();
                formPublicidad.Dispose();
                timerCambioPubli.Stop();
                timerCambioPubli.Dispose();

                button8.BackColor = Color.DarkGray;
                button8.ForeColor = Color.Black;

                buttonIniciarPubli.BackColor = Color.DarkGray;
                buttonIniciarPubli.ForeColor = Color.Black;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            if (minutos < 99)
            {
                minutos++;
                segundos = 0;

                //Actualiza la publicidad del tablero
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                {
                    if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                    {
                        formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;
                    }
                    if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                    {
                        formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
                    }
                }
                else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;

                formTablero.labelCronometro_T.BackColor = Color.Black;
                formTablero.labelCronometro_T.ForeColor = Color.Lime;

                labelCronometro.BackColor = Color.Black;
                labelCronometro.ForeColor = Color.Lime;

                string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");
                labelCronometro.Text = tiempoFormateado;
                formTablero.labelCronometro_T.Text = tiempoFormateado;
            }
            else
            {
                minutos = 0; segundos = 0;
                string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");
                labelCronometro.Text = tiempoFormateado;
                formTablero.labelCronometro_T.Text = tiempoFormateado;
            }



        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            if (minutos > 0)
            {
                minutos--;
                segundos = 0;

                //Actualiza la publicidad del tablero
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                {
                    if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                        formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;

                    if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                        formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
                }
                else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;


                formTablero.labelCronometro_T.BackColor = Color.Black;
                formTablero.labelCronometro_T.ForeColor = Color.Lime;

                labelCronometro.BackColor = Color.Black;
                labelCronometro.ForeColor = Color.Lime;

                string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");
                labelCronometro.Text = tiempoFormateado;
                formTablero.labelCronometro_T.Text = tiempoFormateado;
            }
            else
            {
                minutos = 0; segundos = 0;
                string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");
                labelCronometro.Text = tiempoFormateado;
                formTablero.labelCronometro_T.Text = tiempoFormateado;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("** FUNCIONALIDADE: AMPLIAR TELA PARA TELEVISÃO:\r\n\n*ESTE SOFTWARE FOI PROJETADO PARA UMA CONEXÃO COM UMA TELEVISÃO QUE " +
                "PERMITE AMPLIAR A TELA, DESDE QUE TEM UM CONTROLADOR QUE FUNCIONA NO COMPUTADOR E DOIS PAINÉIS QUE FUNCIONAM NA TELEVISÃO (PAINEL " +
                "DE PONTOS E PAINEL DE ANÚNCIOS).\r\n*AMBOS OS PAINÉIS SÃO MANIPULADOS PELO CONTROLADOR." +
                "\n\n** Assim que a tv estiver conectada ao computador e configurada no modo 'expandir tela', o painel de pontos e o painel publicitário" +
                " podem ser iniciados (iniciam automaticamente na tela da televisão) com os botões 'Mostrar O Placar' para o painel de pontos e " +
                "'Mostrar Anúncio' para o painel de anúncios." +
                "\r\n\n** Se você segurar o cursor sobre os componentes por UM SEGUNDO, eles possuem textos de ajuda que podem orientar o uso do software.\n\n" +
                "** A partir deste painel você pode controlar o Painel de Marcadores de Pontos e o Painel de Anúncios com botões simples." +
                "\n\n** No botão 'Edit' você pode modificar, carregar e excluir duas coisas:\r\n1. As imagens do painel de anúncios.\r\n2. A imagem localizada " +
                "no marcador de ponto (canto inferior direito).\r\nDe forma que você possa modificar os anúncios à vontade.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            segundos = 0;
            minutos = 5;

            //Actualiza la publicidad del tablero
            if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
            {
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;

                if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
            }
            else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;


            formTablero.labelCronometro_T.BackColor = Color.Black;
            formTablero.labelCronometro_T.ForeColor = Color.Lime;

            labelCronometro.BackColor = Color.Black;
            labelCronometro.ForeColor = Color.Lime;

            string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");

            labelCronometro.Text = tiempoFormateado;
            formTablero.labelCronometro_T.Text = tiempoFormateado;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            segundos = 0;
            minutos = 7;

            //Actualiza la publicidad del tablero
            if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
            {
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;

                if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
            }
            else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;


            formTablero.labelCronometro_T.BackColor = Color.Black;
            formTablero.labelCronometro_T.ForeColor = Color.Lime;

            labelCronometro.BackColor = Color.Black;
            labelCronometro.ForeColor = Color.Lime;

            string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");

            labelCronometro.Text = tiempoFormateado;
            formTablero.labelCronometro_T.Text = tiempoFormateado;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor != Color.Maroon && button8.ForeColor != Color.Gold)
            {
                if (!formPublicidad.IsDisposed || formPublicidad == null)
                {
                    button8.BackColor = Color.Maroon;
                    button8.ForeColor = Color.Gold;
                    timerCambioPubli.Start();
                }
            }
            else
            {
                timerCambioPubli.Stop();
                timerCambioPubli.Dispose();
                button8.BackColor = Color.DarkGray;
                button8.ForeColor = Color.Black;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Dispose();

            formPresentacion.Close();
            formPresentacion.Dispose();
        }


        private void labelCronometro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The CheckMat team is the best in the world");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            segundos = 0;
            minutos = 10;

            //Actualiza la publicidad del tablero
            if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
            {
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;

                if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
            }
            else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;


            formTablero.labelCronometro_T.BackColor = Color.Black;
            formTablero.labelCronometro_T.ForeColor = Color.Lime;

            labelCronometro.BackColor = Color.Black;
            labelCronometro.ForeColor = Color.Lime;

            string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");

            labelCronometro.Text = tiempoFormateado;
            formTablero.labelCronometro_T.Text = tiempoFormateado;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            segundos = 0;
            minutos = 3;

            //Actualiza la publicidad del tablero
            if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
            {
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;

                if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
            }
            else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;


            formTablero.labelCronometro_T.BackColor = Color.Black;
            formTablero.labelCronometro_T.ForeColor = Color.Lime;

            labelCronometro.BackColor = Color.Black;
            labelCronometro.ForeColor = Color.Lime;

            string tiempoFormateado = minutos.ToString("0") + ":" + segundos.ToString("00");

            labelCronometro.Text = tiempoFormateado;
            formTablero.labelCronometro_T.Text = tiempoFormateado;
        }

        private void textBoxNombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombre1_Click(object sender, EventArgs e)
        {

        }

        private void timerTiempoFinal_Tick(object sender, EventArgs e)
        {
            timerTiempoFinal.Stop();
            timerTiempoFinal.Dispose();
            timer1.Stop();
            timer1.Dispose();

            //Actualiza la publicidad del tablero
            if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero) || File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
            {
                if (File.Exists(formControlPublicidad.rutaArchivoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaArchivoPubliTablero;

                if (File.Exists(formControlPublicidad.rutaDestinoPubliTablero))
                    formTablero.pictureBoxPubllicidad_T.ImageLocation = formControlPublicidad.rutaDestinoPubliTablero;
            }
            else formTablero.pictureBoxPubllicidad_T.Image = Properties.Resources.checkFrente;
        }

        private void buttonIniciarPubli_Click_1(object sender, EventArgs e)
        {
            if (formPublicidad == null || formPublicidad.IsDisposed)
            {
                formPublicidad = new FormPublicidad();
                formPublicidad.Show();
                buttonIniciarPubli.BackColor = Color.Maroon;
                buttonIniciarPubli.ForeColor = Color.Gold;
            }
            else formPublicidad.Focus();

            formTablero.Close();
            formTablero.Dispose();
            buttonAbrirTablero.BackColor = Color.Black;
            buttonAbrirTablero.ForeColor = Color.Lime;
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.Lime;
        }

        private void timerCambioPubli_Tick(object sender, EventArgs e)
        {
            try
            {
                currentIndex++;
                if (currentIndex >= formControlPublicidad.archivosPubliPanel.Length)
                    currentIndex = 0;

                formPublicidad.pictureBox1.ImageLocation = formControlPublicidad.archivosPubliPanel[currentIndex];
            }
            catch
            {
                timerCambioPubli.Stop();
                timerCambioPubli.Dispose();

                button8.BackColor = Color.DarkGray;
                button8.ForeColor = Color.Black;
                MessageBox.Show("No hay imagen para correr");
            }
        }

        public void buttonEditarPubli_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (formControlPublicidad == null || formControlPublicidad.IsDisposed)
            {
                //Cerrar tablero
                formTablero.Close();
                formTablero.Dispose();
                buttonAbrirTablero.BackColor = Color.Black;
                buttonAbrirTablero.ForeColor = Color.Lime;
                button4.BackColor = Color.Black;
                button4.ForeColor = Color.Lime;

                //cerrar Panel Publicitario
                formPublicidad.Close();
                formPublicidad.Dispose();
                timerCambioPubli.Stop();
                timerCambioPubli.Dispose();
                button8.BackColor = Color.DarkGray;
                button8.ForeColor = Color.Black;

                buttonIniciarPubli.BackColor = Color.DarkGray;
                buttonIniciarPubli.ForeColor = Color.Black;


                //abrir ventana Control Publicidades
                formControlPublicidad = new FormControlPublicidad();
                formControlPublicidad.ShowDialog();
            }
            else formControlPublicidad.Focus();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //verifica si cuando se cambió el foco a este form, los demás fueron cerrados

            if (formPublicidad.cerradoPubliPanel == true)
            {
                formPublicidad.Close();
                formPublicidad.Dispose();
                timerCambioPubli.Stop();
                timerCambioPubli.Dispose();

                button8.BackColor = Color.DarkGray;
                button8.ForeColor = Color.Black;

                buttonIniciarPubli.BackColor = Color.DarkGray;
                buttonIniciarPubli.ForeColor = Color.Black;
            }

            if (formTablero.cerradoTablero == true)
            {
                formTablero.Close();
                formTablero.Dispose();
                buttonAbrirTablero.BackColor = Color.Black;
                buttonAbrirTablero.ForeColor = Color.Lime;
                button4.BackColor = Color.Black;
                button4.ForeColor = Color.Lime;
            }

            if (formControlPublicidad.cerradoControladorPubli == true)
            {
                formControlPublicidad.Close();
                formControlPublicidad.Dispose();
            }

        }






    }
}
