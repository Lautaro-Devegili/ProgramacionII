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
    public partial class FrmDetallePresupuesto : Form
    {
        public FrmDetallePresupuesto(int presupuestoNro)
        {
            InitializeComponent();
            this.Text += presupuestoNro;
        }

        private void FrmDetallePresupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
