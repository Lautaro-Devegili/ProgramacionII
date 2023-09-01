using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCCarpinteria_Krlitos.Entidades
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoPresupuesto nuevo = new frmNuevoPresupuesto();
            nuevo.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPresupuestos nuevo = new FrmConsultarPresupuestos();
            nuevo.ShowDialog();
        }
    }
}
