using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMCCarpinteria_Krlitos.Datos;

namespace ABMCCarpinteria_Krlitos.Entidades
{
    public partial class FrmConsultarPresupuestos : Form
    {
        public FrmConsultarPresupuestos()
        {
            InitializeComponent();
            dgvPresupuestos.DataBindings.Add(nameof(dgvPresupuestos.BackgroundColor),
                                this,
                                nameof(gpbFiltros.BackColor));


        }

        private void FrmConsultarPresupuestos_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            dtpHasta.Value = DateTime.Now;
        }

        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //I want to open a new form when I click on a cell in a column
            if (e.ColumnIndex == 4)
            {
                int nro = Convert.ToInt32(dgvPresupuestos.CurrentRow.Cells["ColNro"].Value);
                FrmDetallePresupuesto detalle = new FrmDetallePresupuesto(nro);
                detalle.ShowDialog();

            }
            /*if (dgvPresupuestos.CurrentCell.ColumnIndex==4)
            {
                int nro = Convert.ToInt32(dgvPresupuestos.CurrentRow.Cells["ColNro"].Value);
                FrmDetallePresupuesto detalle = new FrmDetallePresupuesto(nro);
                detalle.ShowDialog();
                
            }*/
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Validar datos de entrada
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@fecha_desde", dtpDesde.Value.ToString("yyyy-MM-dd")));
            lista.Add(new Parametro("@fecha_hasta", dtpHasta.Value.ToString("yyyy-MM-dd")));
            lista.Add(new Parametro("@cliente", txtCliente.Text.ToString()));

            DataTable tabla = new DBHelper().Consultar("SP_CONSULTAR_PRESUPUESTOS", lista);
            dgvPresupuestos.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvPresupuestos.Rows.Add(new object[] { fila["presupuesto_nro"].ToString(),
                                                        ((DateTime)fila["fecha"]).ToShortDateString(),
                                                        fila["cliente"].ToString(),
                                                        fila["total"].ToString()});
            }
        }
    }
}
