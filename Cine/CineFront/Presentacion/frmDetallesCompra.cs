using Cine_Back.Datos;
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
    public partial class frmDetallesCompra : Form
    {
        private int codCliente;
        public frmDetallesCompra(int CodCliente)
        {
            InitializeComponent();
            this.codCliente = CodCliente;
        }

        private void frmDetallesCompra_Load(object sender, EventArgs e)
        {
            MostrarDatosEnDataGridView();
        }

        private void MostrarDatosEnDataGridView()
        {

            // Crear una lista de parámetros si tu stored procedure los requiere
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@codCliente", codCliente));

            DataTable dt = new HelperDao().Consultar("SP_BUSCAR_CLIENTES_COMPRAS", parametros);
            dgvDetalleCompra.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                dgvDetalleCompra.Rows.Add(new object[]
                {
                    dr["NroCompra"].ToString(),
                    ((DateTime)dr["Fecha"]).ToShortDateString(),
                    dr["CantidadEntradas"].ToString(),
                    dr["NomPeli"].ToString(),
                    dr["Sala"].ToString(),
                    dr["TipoFuncion"].ToString()
                });
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
