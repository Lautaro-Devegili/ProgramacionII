using CineFront.Properties;
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
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes nuevo = new Clientes();
            nuevo.Show();
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funciones nuevo = new Funciones();
            nuevo.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras nuevo = new Compras();
            nuevo.Show();
        }

        private void taquilleríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeliculasTaquilleras nuevo = new frmPeliculasTaquilleras();
            nuevo.Show();
        }

        private void Cine_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Resources.cines_mar_del_plata;
        }
    }
}
