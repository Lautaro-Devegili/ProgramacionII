using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class CustomMessageBox : Form
    {

        private Label label;
        private System.Windows.Forms.Timer timer;
        public CustomMessageBox(string message, int durationSeconds)
        {
            InitializeComponent(message, durationSeconds);
        }

        private void InitializeComponent(string message, int durationSeconds)
        {
            this.label = new Label();
            this.timer = new System.Windows.Forms.Timer();

            // Configuración del label
            this.label.Text = message;
            this.label.Dock = DockStyle.Fill;
            this.label.TextAlign = ContentAlignment.MiddleCenter;

            // Configuración del formulario
            this.Text = "Mensaje";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new System.Drawing.Size(300, 100);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.label);

            // Configuración del temporizador
            this.timer.Interval = durationSeconds * 1000;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario cuando el temporizador alcanza su límite
        }

        public static void Show(string message, int durationSeconds)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, durationSeconds);
            customMessageBox.ShowDialog();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
