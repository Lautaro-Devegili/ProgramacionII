using practicaParcial.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaParcial
{
    public partial class frmMenu : Form
    {
        FabricaServicioImp f;
        public frmMenu(FabricaServicioImp fa)
        {
            InitializeComponent();
            this.f = fa;
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarOrden nuevo = new frmRegistrarOrden(f);
            nuevo.Show();
        }
    }
}
