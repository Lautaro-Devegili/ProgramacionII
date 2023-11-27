using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineFront.Servicios;
using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;
using Cine_Back.Servicios.Interfaz;
using Cine_Back.Servicios.Implementacion;
using Cine_Back.Entidades.Funciones;
using Cine_Back.Datos;
using Cine_Back.Datos.Interfaz;
using Cine_Back.Datos.Implementacion;

namespace CineFront
{
    public partial class NuevaFuncion : Form
    {
        IServicio s;
        private Funcion fun = new Funcion();
        IFuncionDao c;
        public NuevaFuncion()
        {
            InitializeComponent();
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.CustomFormat = "yyyy-MM-dd HH:mm";

            // Link MaskedTextBox to DateTimePicker
            mtbFechaHora.Mask = "0000-00-00 00:00";
            mtbFechaHora.Visible = false;
            Load += NuevaFuncion_LoadAsync;
            s = new Servicio();
            c = new FuncionDao();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /*private async void NuevaFuncion_Load(object sender, EventArgs e)
        {
            //lblFuncion.Text = "Funcion Nro: " + await ClienteSingleton.getI().GetNextFuncionIdAsync();
            lblFuncion.Text = "Funcion Nro: " + s.GetNextFuncionId();
            await CargarComboPeliAsync(cboPelicula);
            await CargarComboSalaAsync(cboSala);
            await CargarComboFormatosAsync(cboFormato);
        }*/

        private async void NuevaFuncion_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                lblFuncion.Text = "Funcion Nro: " + s.GetNextFuncionId();
                await CargarComboPeliAsync(cboPelicula);
                await CargarComboSalaAsync(cboSala);
                await CargarComboFormatosAsync(cboFormato);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en NuevaFuncion_LoadAsync: {ex.Message}");
            }
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
                cbo.DataSource = lfunc;
                cbo.ValueMember = "NroSala";
                cbo.DisplayMember = "TipoSala";
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
                cbo.DataSource = lfunc;
                cbo.ValueMember = "IdFormato";
                cbo.DisplayMember = "Format";
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
                cbo.DataSource = lfunc;
                cbo.ValueMember = "idPeli";
                cbo.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboPeliAsync: {ex.Message}");
            }
        }

        /*private async void CargarComboSalaAsync(ComboBox cbo)
        {
            string url = "https://localhost:7114/Salas";
            var dataJson = await ClienteSingleton.getI().GetAsync(url);
            List<Sala> lfunc = JsonConvert.DeserializeObject<List<Sala>>(dataJson);
            cbo.DataSource = lfunc;
            cbo.ValueMember = "NroSala";
            cbo.DisplayMember = "TipoSala";
        }

        private async void CargarComboFormatosAsync(ComboBox cbo)
        {
            string url = "https://localhost:7114/Formatos";
            var dataJson = await ClienteSingleton.getI().GetAsync(url);
            List<Formato> lfunc = JsonConvert.DeserializeObject<List<Formato>>(dataJson);
            cbo.DataSource = lfunc;
            cbo.ValueMember = "IdFormato";
            cbo.DisplayMember = "Format";
        }

        private async void CargarComboPeliAsync(ComboBox cbo)
        {
            string url = "https://localhost:7114/Peliculas";
            var dataJson = await ClienteSingleton.getI().GetAsync(url);
            List<Pelicula> lfunc = JsonConvert.DeserializeObject<List<Pelicula>>(dataJson);
            cbo.DataSource = lfunc;
            cbo.ValueMember = "idPeli";
            cbo.DisplayMember = "nombre";

        }*/

        private void dtpFechaHora_ValueChanged(object sender, EventArgs e)
        {
            mtbFechaHora.Text = dtpFechaHora.Value.ToString("yyyy-MM-dd HH:mm");
        }

        private void btnCrearFuncion_Click(object sender, EventArgs e)
        {
            if (cboFormato.SelectedIndex <0)
            {
                MessageBox.Show("Debe seleccionar un formato");
                return;
            } else if (cboPelicula.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una pelicula");
                return;
            } else if (cboSala.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una sala");
            } else
            {
                GrabarFuncion();
            }
        }

        private async void GrabarFuncion()
        {
            fun.IdFuncion = 0;
            fun.IdPeli = Convert.ToInt32(cboPelicula.SelectedValue);
            fun.Peli = cboPelicula.Text;
            fun.FechaHora = dtpFechaHora.Value;
            fun.NroSala = Convert.ToInt32(cboSala.SelectedValue);
            fun.IdFormato = Convert.ToInt32(cboFormato.SelectedValue);
            if (await GuardarFuncionAsync(fun))
            //if (c.CrearFuncion(fun))
            {
                MessageBox.Show("Se grabó con éxito la función... 😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
            } else
            {
                MessageBox.Show("Hubo un error al grabar la función... 😔"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
            }
        }

        private async Task<bool> GuardarFuncionAsync(Funcion fun)
        {
            string url = "https://localhost:7114/PostFuncion";
            //string queryString = $"?idFuncion={fun.IdFuncion}&idPeli={fun.IdPeli}&peli={fun.Peli}&fechaHora={fun.FechaHora}&nroSala={fun.NroSala}&idFormato={fun.IdFormato}";
            string bodyContent = JsonConvert.SerializeObject(fun);
            //string urlWithQueryString = url + queryString;
            var dataJson = await ClienteSingleton.getI().PostAsync(url, bodyContent);
            if (dataJson == "true")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
