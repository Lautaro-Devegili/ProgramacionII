using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class Login : Form
    {
        private string compareUsu = "KrlitosKrlote";
        private string comparePass = "93681719";
        private string compareBot = "Botta";
        private string compareBota = "attoB";
        private int intentosRestantes = 3;
        private int contador = 4;
        public Login()
        {
            InitializeComponent();
        }

        public void Checkeo()
        {
            if (txtUsu.Text == compareUsu && txtPass.Text == comparePass)
            {
                MessageBox.Show("Bienvenido Krlitos");
                this.Hide();
                Cine menu = new Cine();
                menu.Show();
            }
            else if (txtUsu.Text == compareBot && txtPass.Text == compareBota)
            {
                MessageBox.Show("Bienvenido Botta");
                this.Hide();
                Cine menu = new Cine();
                menu.Show();
            }
            else
            {
                intentosRestantes--;

                if (intentosRestantes > 0)
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos, le quedan {intentosRestantes} intentos.");
                }
                else
                {
                    MessageBox.Show("Se acabaron los intentos, vuelva a intentarlo más tarde.");

                    // Comenzar la cuenta regresiva
                    timer1.Start();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkeo();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Actualizar el mensaje en el MessageBox

            if (contador > 0)
            {
                contador--;
                if (contador == 0)
                {
                    timer1.Stop();
                    AbrirVideo();

                }
                else
                {
                    CustomMessageBox.Show($"Explotando en {contador} segundos", 1);
                }

            }
        }

        private void AbrirVideo()
        {
            try
            {
                // Reemplaza "ruta_del_video.mp4" con la ruta completa de tu archivo de video
                string nombreDelVideo = "videao.mp4";
                string rutaVideo = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", nombreDelVideo));

                // Inicia el reproductor de video predeterminado asociado con el tipo de archivo
                /*Process.Start(new ProcessStartInfo
                {
                    FileName = rutaVideo,
                    UseShellExecute = true
                });*/

                Process proceso = new Process();
                proceso.StartInfo.FileName = rutaVideo;
                proceso.StartInfo.UseShellExecute = true;

                // Agrega un controlador para el evento Exited del proceso
                proceso.EnableRaisingEvents = true;
                proceso.Exited += (sender, e) =>
                {
                    // Cierra la aplicación cuando el video termina
                    Application.Exit();
                };

                // Inicia el proceso
                proceso.Start();

                System.Windows.Forms.Timer temporizador = new System.Windows.Forms.Timer();
                temporizador.Interval = 5000;  // Intervalo de 1 segundo
                temporizador.Tick += (sender, e) =>
                {
                    // Verifica si el proceso aún está en ejecución
                    temporizador.Stop();
                    proceso?.CloseMainWindow();
                    proceso?.WaitForExit();
                    Application.Exit();
                };
                temporizador.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el video: {ex.Message}");

            }
        }
    }
}
