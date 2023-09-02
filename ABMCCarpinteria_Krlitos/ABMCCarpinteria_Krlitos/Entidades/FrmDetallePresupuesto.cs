using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMCCarpinteria_Krlitos.Datos;

namespace ABMCCarpinteria_Krlitos.Entidades
{
    public partial class FrmDetallePresupuesto : Form
    {
        private DBHelper g = new DBHelper();
        int nro;
        public FrmDetallePresupuesto(int presupuestoNro)
        {
            InitializeComponent();
            this.Text += presupuestoNro;
            nro = presupuestoNro;
        }

        private void FrmDetallePresupuesto_Load(object sender, EventArgs e)
        {
            Parametro p = new Parametro("@nro_pres", nro);
            List<Parametro> lp = new List<Parametro>();
            lp.Add(p);
            dgvDetallePresupuesto.AutoGenerateColumns = false;
            dgvDetallePresupuesto.Columns[0].DataPropertyName = "detalle_nro";
            dgvDetallePresupuesto.Columns[1].DataPropertyName = "id_producto";
            dgvDetallePresupuesto.Columns[2].DataPropertyName = "nomProducto";
            dgvDetallePresupuesto.Columns[3].DataPropertyName = "precioProducto";
            dgvDetallePresupuesto.Columns[4].DataPropertyName = "cantProducto";
            dgvDetallePresupuesto.Columns[5].DataPropertyName = "subTotalProducto";

            dgvDetallePresupuesto.DataSource = g.Consultar("SP_CONSULTAR_DETALLES", lp);
            //The method "Consultar" returns a datatable with 4 columns: "Nro", "Producto", "Cantidad" and "Precio", I want them
            //to be displayed in the datagridview
            //
            //dgvDetallePresupuesto.DataSource = t;
            //Pre num 0; Detalle Nro 1; Producto 2; Cantidad 3;
            //Detalle Nro 0; Producto 1; Precio 2; Cantidad 3; Subtotal 4;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
