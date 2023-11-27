using Cine_Back.Datos;
using Cine_Back.Servicios.Implementacion;
using Cine_Back.Servicios.Interfaz;

using System;
using System.Collections;
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
    public partial class frmCompraDetalles : Form
    {
        IServicio servicio;
        private int codCompra;
        List<Parametro> lista;
        public frmCompraDetalles(int CodCompra)
        {

            InitializeComponent();
            this.codCompra = CodCompra;
            servicio = new Servicio();
        }

        private void frmCompraDetalles_Load(object sender, EventArgs e)
        {
            MostrarDatosEnDataGridView();
        }
        private void MostrarDatosEnDataGridView()
        {



            // Crear una lista de parámetros si tu stored procedure los requiere
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nroCompra", codCompra));

            //  DataTable dt = new HelperDao().Consultar("SP_BUSCAR_COMPRAS_DETALLES", parametros);
            DataTable dt = servicio.BuscarCompraDetalle(parametros);
            dgvCompraDetalle.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                dgvCompraDetalle.Rows.Add(new object[]
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
    }
}
