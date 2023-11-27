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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCompra nuevo = new NuevaCompra();
            nuevo.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCompras nuevo = new ConsultarCompras();
            nuevo.Show();
        }
    }
}
