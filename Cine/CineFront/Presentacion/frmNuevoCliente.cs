using Cine_Back.Datos.Implementacion;
using Cine_Back.Datos.Interfaz;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Servicios.Implementacion;
using Cine_Back.Servicios.Interfaz;
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
    public partial class frmNuevoCliente : Form
    {
        IServicio s;
        Cliente cliente;
        IClienteDao daoC;
        public frmNuevoCliente()
        {
            InitializeComponent();
            dtpFechaNac.Value = DateTime.Now.AddYears(-20);
            Load += NuevosClientes_LoadAsync;
            s = new Servicio();
            cliente = new Cliente();
            daoC = new ClienteDao();
        }

        private async void NuevosClientes_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                lblIdCliente.Text = "Cliente Nro: " + s.GetNextCompraNro();
                await CargarComboSexosAsync(cboSexo);
                await CargarComboTiposDocAsync(cboTipo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en NuevoCliente_LoadAsync: {ex.Message}");
            }
        }

        private async Task CargarComboSexosAsync(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Sex";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Sexo> lsex = JsonConvert.DeserializeObject<List<Sexo>>(dataJson);
                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = lsex;
                    cbo.ValueMember = "IdSexo";
                    cbo.DisplayMember = "Sex";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboSexoAsync: {ex.Message}");
            }
        }

        private async Task CargarComboTiposDocAsync(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Docs";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<TipoDoc> ltipos = JsonConvert.DeserializeObject<List<TipoDoc>>(dataJson);
                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = ltipos;
                    cbo.ValueMember = "IdTipoDoc";
                    cbo.DisplayMember = "Tipo";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboTiposDocAsync: {ex.Message}");
            }
        }

        private async Task<bool> GrabarCliente()
        {
            cliente.Apellido = txtApellido.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Documento = Convert.ToInt32(txtDocumento.Text);
            if (long.TryParse(txtTelefono.Text, out long numeroTelefono))
            {
                // La conversión fue exitosa
                cliente.Telefono = numeroTelefono;
            }
            cliente.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
            cliente.TipoDoc = Convert.ToInt32(cboTipo.SelectedValue);

            //if (daoC.CrearCliente(cliente))
            if (await GuardarClienteAsync(cliente))
            {
                MessageBox.Show("Se grabó con éxito el cliente... 😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                return true;
            }
            else
            {
                MessageBox.Show("Hubo un error al grabar el cliente... 😔"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                return false;
            }
        }

        private async Task<bool> GuardarClienteAsync(Cliente cli)
        {
            string url = "https://localhost:7114/SaveCliente";
            string queryString = $"?idCliente={cli.IdCliente}&apellido={cli.Apellido}&nombre={cli.Nombre}&documento={cli.Documento}&telefono={cli.Telefono}&idSexo={cli.IdSexo}&tipoDoc={cli.TipoDoc}";
            string urlWithQueryString = url + queryString;
            var dataJson = await ClienteSingleton.getI().PostAsync(urlWithQueryString);
            if (dataJson == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido... 😡"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre... 😡"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento... 😡"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtDocumento.Text == "")
            {
                MessageBox.Show("Debe ingresar un documento... 😡"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else if (dtpFechaNac.Value > DateTime.Now.AddYears(-13))
            {
                MessageBox.Show("El cliente debe tener al menos 13 años... 🥺"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar un numero de telefono... 😡"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else if (cboSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un sexo... 😡"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                GrabarCliente();
            }
        }
    }
}
