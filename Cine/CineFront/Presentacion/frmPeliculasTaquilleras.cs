using Microsoft.Reporting.WinForms;
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
    public partial class frmPeliculasTaquilleras : Form
    {
        public frmPeliculasTaquilleras()
        {
            InitializeComponent();
        }

        private void frmPeliculasTaquilleras_Load(object sender, EventArgs e)
        {

            if (rptPelis == null)
            {
                rptPelis = new ReportViewer();
            }

            DSAfueraTableAdapters.ObtenerTop10PeliculasTaquillerasTableAdapter tbladap = new DSAfueraTableAdapters.ObtenerTop10PeliculasTaquillerasTableAdapter();
            DSAfuera.ObtenerTop10PeliculasTaquillerasDataTable dataT = tbladap.GetData();
            ReportDataSource dataSurs2InglesFachero = new ReportDataSource("DataSet1", (IEnumerable)dataT);

            //DSAfuPelisTaqui. teiblAdapter = new DataSet1TableAdapters.ObtenerTop10PeliculasTaquillerasTableAdapterAf();

            //DataSet1.ObtenerTop10PeliculasTaquillerasAfDataTable dataAf = teiblAdapter.GetData();

            //ReportDataSource dataSurs2InglesFachero = new ReportDataSource("DataSet1", (IEnumerable)dataAf);

            rptPelis.LocalReport.DataSources.Clear();
            rptPelis.LocalReport.DataSources.Add(dataSurs2InglesFachero);   


            rptPelis.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.rptPelisTaquilleras.rdlc";
            rptPelis.RefreshReport();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
