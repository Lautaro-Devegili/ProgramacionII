using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Funciones;
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

namespace CineFront.Presentacion
{
    public partial class frmModificarFunciones : Form
    {
        private int CodFuncion;
        private ConsultarFunciones frm;
        Funcion func;
        string IdPelicula;
        string IdSala;
        string IdFormato;
        public frmModificarFunciones(string codFuncion, string idPelicula, string fechaHora, string idSala, string idFormato, ConsultarFunciones form)
        {
            InitializeComponent();
            this.CodFuncion = int.Parse(codFuncion);
            this.frm = form;
            lblFuncion.Text = "Funcion: " + codFuncion;
            DateTime fechaHoraO;
            if (DateTime.TryParse(fechaHora, out fechaHoraO))
            {
                dtpFechaHora.Value = fechaHoraO;
            }
            func = new Funcion();
            Load += frmModificarFunciones_LoadAsync;
            this.IdPelicula = idPelicula;
            this.IdSala = idSala;
            this.IdFormato = idFormato;
        }

        private async Task CargarComboSalaAsync(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Salas";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Sala> lfunc = JsonConvert.DeserializeObject<List<Sala>>(dataJson);
                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = lfunc;
                    cbo.ValueMember = "NroSala";
                    cbo.DisplayMember = "TipoSala";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboSalaAsync: {ex.Message}");
            }
        }

        private async Task CargarComboFormatosAsync(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Formatos";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Formato> lfunc = JsonConvert.DeserializeObject<List<Formato>>(dataJson);
                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = lfunc;
                    cbo.ValueMember = "IdFormato";
                    cbo.DisplayMember = "Format";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboFormatosAsync: {ex.Message}");
            }
        }

        private async Task CargarComboPeliAsync(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Peliculas";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Pelicula> lfunc = JsonConvert.DeserializeObject<List<Pelicula>>(dataJson);
                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = lfunc;
                    cbo.ValueMember = "idPeli";
                    cbo.DisplayMember = "nombre";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboPeliAsync: {ex.Message}");
            }
        }

        private async void frmModificarFunciones_LoadAsync(object sender, EventArgs e)
        {
            await CargarComboPeliAsync(cboPelicula);
            await CargarComboSalaAsync(cboSala);
            await CargarComboFormatosAsync(cboFormato);
            cboPelicula.SelectedValue = int.Parse(IdPelicula);
            cboSala.SelectedValue = int.Parse(IdSala);
            cboFormato.SelectedValue = int.Parse(IdFormato);
            cboPelicula.Enabled = false;
            cboSala.Enabled = false;
            dtpFechaHora.Enabled = false;
        }

        private async void btnCrearFuncion_Click(object sender, EventArgs e)
        {
            if (cboFormato.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un formato");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas actualizar la función?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Actualizar();
                }
            }
        }

        private async Task<bool> Actualizar()
        {
            func.IdFormato = int.Parse(cboFormato.SelectedValue.ToString());
            func.IdFuncion = CodFuncion;

            if (await ActualizarFuncionAsync(func))
            {
                MessageBox.Show("Se modificó con éxito la función... 😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                frm.LlenarGrilla();
                return true;
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar la función... 😔"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                return false;
            }

        }

        private async Task<bool> ActualizarFuncionAsync(Funcion func)
        {
            string url = "https://localhost:7114/PutFunc";
            /*string queryString = $"?idCliente={cli.IdCliente}&apellido={cli.Apellido}&nombre={cli.Nombre}&documento={cli.Documento}&telefono={cli.Telefono}&idSexo={cli.IdSexo}&tipoDoc={cli.TipoDoc}";
            string urlWithQueryString = url + queryString;*/
            string bodyContent = JsonConvert.SerializeObject(func);

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
    }
}
