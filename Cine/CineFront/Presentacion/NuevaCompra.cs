using Cine_Back.Datos.Implementacion;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Compras;
using Cine_Back.Entidades.Funciones;
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
    public partial class NuevaCompra : Form
    {
        IServicio s;
        Compra com;
        int vez;
        CompraDao compraDao;
        public NuevaCompra()
        {
            InitializeComponent();
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpFechaHora.Enabled = false;
            dtpFechaCompra.Format = DateTimePickerFormat.Custom;
            dtpFechaCompra.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpFechaCompra.Enabled = false;
            dtpFechaCompra.Value = DateTime.Now;
            vez = 0;
            Load += NuevaCompra_LoadAsync;
            s = new Servicio();
            com = new Compra();
            compraDao = new CompraDao();
        }

        private void cboFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcion f = (Funcion)cboFuncion.SelectedItem;
            txtFormato.Text = f.Format;
            txtSala.Text = f.TipoSala;
            ActualizarPrecio();
            dtpFechaHora.Value = f.FechaHora;
        }

        private void cboDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Descuento d = (Descuento)cboDescuento.SelectedItem;
            if (d == null)
            {
                return;
            } else
            {
                txtDescuento.Text = d.Porcentaje.ToString();
            }
        }

        private async Task CargarComboClientes(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Clientes";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Cliente> ltipos = JsonConvert.DeserializeObject<List<Cliente>>(dataJson);
                /* cbo.DataSource = ltipos;
                 cbo.ValueMember = "IdCliente";
                 cbo.DisplayMember = "ApeNombre";*/

                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = ltipos;
                    cbo.ValueMember = "IdCliente";
                    cbo.DisplayMember = "ApeNombre";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboFormatosAsync: {ex.Message}");
            }
        }

        private async Task CargarComboFunciones(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Funciones";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Funcion> ltipos = JsonConvert.DeserializeObject<List<Funcion>>(dataJson);
                /*cbo.DataSource = ltipos;
                cbo.ValueMember = "IdFuncion";
                cbo.DisplayMember = "Show";*/

                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = ltipos;
                    cbo.ValueMember = "IdFuncion";
                    cbo.DisplayMember = "Show";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboFormatosAsync: {ex.Message}");
            }
        }

        private async Task CargarComboDescuentos(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/Descuentos";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<Descuento> ltipos = JsonConvert.DeserializeObject<List<Descuento>>(dataJson);
                /*cbo.DataSource = ltipos;
                cbo.ValueMember = "IdDescuento";
                cbo.DisplayMember = "Descripcion";*/
                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = ltipos;
                    cbo.ValueMember = "IdDescuento";
                    cbo.DisplayMember = "Descripcion";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboFormatosAsync: {ex.Message}");
            }
        }

        private async Task CargarComboFormasPago(ComboBox cbo)
        {
            var cts = new CancellationTokenSource(150);
            try
            {
                await Task.Delay(150, cts.Token);
                string url = "https://localhost:7114/FormasPago";
                var dataJson = await ClienteSingleton.getI().GetAsync(url);
                List<FormaPago> ltipos = JsonConvert.DeserializeObject<List<FormaPago>>(dataJson);
                /*cbo.DataSource = ltipos;
                cbo.ValueMember = "IdFormaPago";
                cbo.DisplayMember = "FormPago";*/

                cbo.Invoke((MethodInvoker)delegate
                {
                    cbo.DataSource = ltipos;
                    cbo.ValueMember = "IdFormaPago";
                    cbo.DisplayMember = "FormPago";
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarComboFormatosAsync: {ex.Message}");
            }
        }

        private async void NuevaCompra_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                lblNroCompra.Text = "Compra Nro: " + s.GetNextCompraNro();
                await CargarComboClientes(cboCliente);
                await CargarComboFunciones(cboFuncion);
                await CargarComboDescuentos(cboDescuento);
                await CargarComboFormasPago(cboFormaPago);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en NuevoCliente_LoadAsync: {ex.Message}");
            }
        }

        private async void btnComprar_Click(object sender, EventArgs e)
        {
            if (cboDescuento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un descuento... 😡");
                return;
            }
            else if (cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una función... 😡");
                return;
            }
            else if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente... 😡");
                return;
            }
            else if (rbtPagar.Checked == false && rbtReservar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opción de compra... 😡");
                return;
            }
            else if (txtCant.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad de entradas ... 😡");
                return;
            }
            else
            {
                for (int i = 0; i < int.Parse(txtCant.Text); i++)
                {
                    int prueba = i;
                    Entrada ent = new Entrada();
                    ent.CodFuncion = ((Funcion)cboFuncion.SelectedItem).IdFuncion;
                    ent.CodDescuento = ((Descuento)cboDescuento.SelectedItem).IdDescuento;
                    ent.Precio = ((Funcion)cboFuncion.SelectedItem).Precio;
                    ent.Descuento = ((Descuento)cboDescuento.SelectedItem).Porcentaje;
                    com.AgregarEntrada(ent);
                }
                await GrabarCompra();
            }
        }

        private async Task GrabarCompra()
        {
            com.IdFormaPago = ((FormaPago)cboFormaPago.SelectedItem).IdFormaPago;
            com.IdCliente = ((Cliente)cboCliente.SelectedItem).IdCliente;
            com.FechaCompra = dtpFechaCompra.Value;
            if (rbtPagar.Checked)
            {
                com.IdEstado = 1;
            }
            else
            {
                com.IdEstado = 2;
            }

            //if (compraDao.CrearCompra(com))
            await GuardarCompraAsync(com);
            /*if (await GuardarCompraAsync(com))
            {
                MessageBox.Show("Se grabó con éxito la compra... 😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                //return true;
            }
            else
            {
                MessageBox.Show("Hubo un error al grabar la compra... 😔"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                //return false;
            }*/
        }
        private async Task GuardarCompraAsync(Compra comp)
        {
            string url = "https://localhost:7114/PostCompra";
            string bodyContent = JsonConvert.SerializeObject(comp);
            //string queryString = $"?nroCompra={comp.NroCompra}&idFormaPago={comp.IdFormaPago}&idCliente={comp.IdCliente}&fechaCompra={comp.FechaCompra}&idEstado={comp.IdEstado}";//&entradas={comp.Entradas}";
            //string urlWithQueryString = url + queryString;
            var dataJson = await ClienteSingleton.getI().PostAsync(url, bodyContent);

            if (dataJson.Equals("true"))
            {
                MessageBox.Show("Se grabó con éxito la compra... 😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Hubo un error al grabar la compra... 😔"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            /*if (dataJson == "true")
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void ActualizarPrecio()
        {
            Funcion f = (Funcion)cboFuncion.SelectedItem;
            if (vez == 0 || txtCant.Text == "")
            {
                vez++;
            }
            else if (vez == 1 || txtCant.Text == "")
            {
                txtPrecio.Text = f.Precio.ToString();
                vez++;
            }
            else
            {
                decimal prexcantidad = f.Precio * Convert.ToInt32(txtCant.Text);
                txtPrecio.Text = (prexcantidad - (prexcantidad * Convert.ToDecimal(txtDescuento.Text) / 100)).ToString();
            }


        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }
    }
}
