using Cine_Back.Datos;
using Cine_Back.Entidades.Funciones;
using Cine_Back.Servicios.Interfaz;
using Cine_Back.Servicios.Implementacion;
using CineFront.Servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine_Back.Entidades.Compras;

namespace CineFront.Presentacion
{
    public partial class ConsultarCompras : Form
    {
        IServicio servicio;
        Parametro codClienteParam;
        Parametro fechaParam;
        List<Parametro> lista;
        DateTime fechaInicio = new DateTime();
        public ConsultarCompras()
        {
            InitializeComponent();
            servicio = new Servicio();
            dtpCompra.Format = DateTimePickerFormat.Custom;
            dtpCompra.CustomFormat = "yyyy-MM-dd HH:mm";
            fechaInicio = DateTime.Now.Date;
            dtpCompra.Value = fechaInicio;
            codClienteParam = new Parametro();
            fechaParam = new Parametro();
            lista = new List<Parametro>();
            Load += ConsultarCompras_LoadAsync;
        }

        private async void ConsultarCompras_LoadAsync(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            if (!string.IsNullOrEmpty(txtIdCliente.Text))
            {
                codClienteParam.Nombre = "@codCliente"; //lista.Add(new Parametro("@codCliente", txtIdCliente.Text));
                codClienteParam.Valor = int.Parse(txtIdCliente.Text);
                lista.Add(codClienteParam);

            }

            if (dtpCompra.Value == fechaInicio)
            {
                fechaParam.Nombre = "@fechaCompra"; //lista.Add(new Parametro("@fechaCompra", dtpCompra.Value.Date));
                fechaParam.Valor = null;
                lista.Add(fechaParam);
            }
            else if(!dtpCompra.Value.Equals(null))
            {
                fechaParam.Nombre = "@fechaCompra"; //lista.Add(new Parametro("@fechaCompra", dtpCompra.Value.Date));
                fechaParam.Valor = dtpCompra.Value.Date;
                lista.Add(fechaParam);
            }
            LlenarGrilla();
        }

        public void LlenarGrilla()
        {
            //DataTable dt = HelperDao.OI().Consultar("SP_BUSCAR_COMPRAS", lista);
            DataTable dt = servicio.BuscarCompra(lista);
            dgvConsultarCompra.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                dgvConsultarCompra.Rows.Add(new object[]
                {
                    dr["nroCompra"].ToString(),
                    dr["FormaPago"].ToString(),
                    dr["codCliente"].ToString(),
                    dr["Cliente"].ToString(),
                    ((DateTime)dr["fecha"]).ToShortDateString(),
                    dr["Estado"].ToString(),
                    "Cambiar Estado",
                    "Ver Detalle"
                });
            }
        }


        private async Task<bool> Actualizar(Compra comp)
        {
            if (await ActualizarCompraAsync(comp))
            {
                MessageBox.Show("Se modificó con éxito la compra... 😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                btnConsultar_Click(this, EventArgs.Empty);
                return true;
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar la compra... 😔"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                return false;
            }

        }

        private async Task<bool> ActualizarCompraAsync(Compra comp)
        {
            string url = "https://localhost:7114/PutCompra";
            /*string queryString = $"?idCliente={cli.IdCliente}&apellido={cli.Apellido}&nombre={cli.Nombre}&documento={cli.Documento}&telefono={cli.Telefono}&idSexo={cli.IdSexo}&tipoDoc={cli.TipoDoc}";
            string urlWithQueryString = url + queryString;*/
            string bodyContent = JsonConvert.SerializeObject(comp);
            var dataJson = await ClienteSingleton.getI().PutAsync(url, bodyContent);
            if (dataJson.Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private async Task CargarComboSalaAsync(ComboBox cbo)
        {
            try
            {
                string url = "https://localhost:7114/Salas";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Sala> lfunc = JsonConvert.DeserializeObject<List<Sala>>(dataJson);
                cbo.DataSource = lfunc;
                cbo.ValueMember = "NroSala";
                cbo.DisplayMember = "TipoSala";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboSalaAsync: {ex.Message}");
            }
        }

        private void dgvConsultarCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                List<Parametro> SP = new List<Parametro>();
                SP.Add(new Parametro("@estado", dgvConsultarCompra.CurrentRow.Cells[5].Value.ToString));
                SP.Add(new Parametro("@codCompra", dgvConsultarCompra.CurrentRow.Cells[0].Value));
                int nroCompra = Convert.ToInt32(dgvConsultarCompra.CurrentRow.Cells[0].Value);
                //if (servicio.UpdateEstadoCompra(nroCompra))
                Compra comp = new Compra();
                comp.NroCompra = nroCompra;
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar esta compra?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Actualizar(comp);
                } else
                {
                    return;
                }
                
            }
            if (e.RowIndex>= 0 && e.ColumnIndex == 7)
            {
                DataGridViewRow filaSeleccionada = dgvConsultarCompra.Rows[e.RowIndex];
                int codCompra = int.Parse( filaSeleccionada.Cells[0].Value.ToString());
                // int codCompra = Convert.ToInt32(dgvConsultarCompra.SelectedRows[0].Cells[0].Value);
                frmCompraDetalles formularioDetalles = new frmCompraDetalles(codCompra);
                formularioDetalles.ShowDialog();
            }
        }
    }
}
