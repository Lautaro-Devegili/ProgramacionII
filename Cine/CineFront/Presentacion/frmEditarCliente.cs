using Cine_Back.Datos;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Servicios.Implementacion;
using Cine_Back.Servicios.Interfaz;
using CineFront.Servicios;
using Newtonsoft.Json;
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

namespace CineFront.Presentacion
{
    public partial class frmEditarCliente : Form
    {
        IServicio servicio;
        int CodigoCliente;
        Cliente cliente;
        frmConsultarCliente frm;
        public frmEditarCliente(string codCliente, string apellido, string nombre, string codTipoDoc, string documento, string fechaNacimiento, string nroTelefono, string idSexo, frmConsultarCliente form)
        {
            InitializeComponent();
            servicio = new Servicio();
            string lbltext = label3.Text;
            CodigoCliente = int.Parse(codCliente);
            label3.Text = lbltext + codCliente;
            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            txtDocumento.Text = documento;
            txtTelefono.Text = nroTelefono;
            this.frm = form;
            cliente = new Cliente();
            CargarTipoDoc();
            CargarTipoSexo();

            cboSexo.SelectedValue = int.Parse(idSexo);
            cboTipo.SelectedValue = int.Parse(codTipoDoc);

            DateTime fechaNac;
            if (DateTime.TryParse(fechaNacimiento, out fechaNac))
            {
                dtpFechaNac.Value = fechaNac;
            }
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void CargarTipoDoc()
        {
            cboTipo.DataSource = servicio.TraerComboDoc();
            cboTipo.ValueMember = "IdTipoDoc";
            cboTipo.DisplayMember = "Tipo";
        }

        private void CargarTipoSexo()
        {
            cboSexo.DataSource = servicio.TraerComboSex();
            cboSexo.ValueMember = "IdSexo";
            cboSexo.DisplayMember = "Sex";
        }
        private async Task<bool> Actualizar()
        {
            cliente.IdCliente = CodigoCliente; //Acá estaba el ObtenerNumeroDeLabel
            cliente.Apellido = txtApellido.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Documento = int.Parse(txtDocumento.Text);
            cliente.FechaNac = dtpFechaNac.Value;
            cliente.Telefono = int.Parse(txtTelefono.Text);
            cliente.IdSexo = int.Parse(cboSexo.SelectedValue.ToString());
            cliente.TipoDoc = int.Parse(cboTipo.SelectedValue.ToString());

            if (await ActualizarClienteAsync(cliente))
            {
                MessageBox.Show("Se modificó con éxito el cliente... 😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                frm.LlenarGrilla();
                return true;
            }
            else
            {
                MessageBox.Show("Hubo un error al modificar el cliente... 😔"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
                return false;
            }

        }

        private async Task<bool> ActualizarClienteAsync(Cliente cli)
        {
            string url = "https://localhost:7114/PutCli";
            /*string queryString = $"?idCliente={cli.IdCliente}&apellido={cli.Apellido}&nombre={cli.Nombre}&documento={cli.Documento}&telefono={cli.Telefono}&idSexo={cli.IdSexo}&tipoDoc={cli.TipoDoc}";
            string urlWithQueryString = url + queryString;*/
            string bodyContent = JsonConvert.SerializeObject(cli);

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

        private void btnAgregar_Click(object sender, EventArgs e)
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
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas Actualizarlo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Actualizar();
                }
            }

        }



        /*private int ObtenerNumeroDeLabel(string textoLabel)
        {
            int indiceInicio = textoLabel.IndexOf("Cliente N°");

            if (indiceInicio != -1)
            {
                string numeroStr = textoLabel.Substring(indiceInicio + "Cliente N°".Length);

                if (int.TryParse(numeroStr, out int numero))
                {
                    return numero;
                }
            }

            throw new InvalidOperationException("Formato de label incorrecto");
        }*/
    }
}
