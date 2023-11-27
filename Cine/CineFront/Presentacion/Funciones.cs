using CineFront.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void nuevaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevaFuncion nueva = new NuevaFuncion();
            nueva.Show();
        }

        private void Funciones_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ConsultarFunciones nueva = new ConsultarFunciones();
            nueva.Show();
        }
    }
}
