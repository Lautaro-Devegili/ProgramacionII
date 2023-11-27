using Cine_Back.Datos;
using Cine_Back.Servicios.Implementacion;
using Cine_Back.Servicios.Interfaz;
using CineFront.Servicios;
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
    public partial class frmConsultarCliente : Form
    {
        public IServicio servicio;
        int? idSexo = null;
        Parametro nombreParam;
        Parametro documentoParam;
        Parametro idSexoParam;
        List<Parametro> lista;
        public frmConsultarCliente()
        {
            InitializeComponent();
            servicio = new Servicio();
            nombreParam = new Parametro();
            documentoParam = new Parametro();
            idSexoParam = new Parametro();
            lista = new List<Parametro>();
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (rbtMasculino.Checked)
            {
                idSexo = 1;
            }
            else if (rbtFemenino.Checked)
            {
                idSexo = 2;
            }
            else if (rbtOtro.Checked)
            {
                idSexo = 3;
            }
            lista.Clear();
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                nombreParam.Nombre = "@nombre"; //= new Parametro("@nombre", txtNombre.Text);
                nombreParam.Valor = txtNombre.Text;
                lista.Add(nombreParam);
            }

            if (!string.IsNullOrEmpty(txtDocumento.Text))
            {
                documentoParam.Nombre = "@documento"; //documentoParam = new Parametro("@documento", txtDocumento.Text);
                documentoParam.Valor = txtDocumento.Text;
                lista.Add(documentoParam);
            }

            if (idSexo.HasValue)
            {
                idSexoParam.Nombre = "@idSexo"; //idSexoParam = new Parametro("@idSexo", idSexo.Value);
                idSexoParam.Valor = idSexo.Value;
                lista.Add(idSexoParam);
            }

            LlenarGrilla();
        }

        public void LlenarGrilla()
        {
            DataTable dt = servicio.GetClientesConOSinFiltro(lista);
            dgvDetalleC.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                dgvDetalleC.Rows.Add(new object[]
                {
                    dr["codCliente"].ToString(),
                    dr["apellido"].ToString(),
                    dr["nombre"].ToString(),
                    dr["codTipoDoc"].ToString(),
                    dr["documento"].ToString(),
                    ((DateTime)dr["fechaNacimiento"]).ToShortDateString(),
                    dr["nroTelefono"].ToString(),
                    dr["idSexo"].ToString(),
                    "Editar",
                    "Eliminar"
                });
            }

            foreach (DataGridViewRow row in dgvDetalleC.Rows)
            {
                // Supongamos que el valor de la columna "colCodCliente" es de tipo entero
                int valorCodCliente = Convert.ToInt32(row.Cells["ColId"].Value);
                int tiene = servicio.GetIdCheckeada(valorCodCliente);
                int rowIndex = row.Index;
                if (tiene == 1)
                {
                    dgvDetalleC.Rows[rowIndex].Cells["colEliminar"].ReadOnly = true;
                    dgvDetalleC.Rows[rowIndex].Cells["colEliminar"].Style.BackColor = Color.LightGray;
                    ((DataGridViewButtonCell)dgvDetalleC.Rows[rowIndex].Cells["colEliminar"]).FlatStyle = FlatStyle.Flat;
                    dgvDetalleC.Rows[rowIndex].Cells["colEliminar"].Style.ForeColor = Color.Gray;
                } 
                //var a = dgvDetalleC.Rows[rowIndex].Cells["colEliminar"].ReadOnly;
                //if (valorCodCliente == codCliente)
                //{
                //    // Se encontró la fila con el codCliente deseado
                //    int filaIndex = row.Index;

                //}
            }
        }

        private async void dgvDetalleC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                DataGridViewRow filaSeleccionada = dgvDetalleC.Rows[e.RowIndex];
                string codCliente = filaSeleccionada.Cells[0].Value.ToString();
                string apellido = filaSeleccionada.Cells[1].Value.ToString();
                string nombre = filaSeleccionada.Cells[2].Value.ToString();
                string codTipoDoc = filaSeleccionada.Cells[3].Value.ToString();
                string documento = filaSeleccionada.Cells[4].Value.ToString();
                string fechaNacimiento = filaSeleccionada.Cells[5].Value.ToString();
                string nroTelefono = filaSeleccionada.Cells[6].Value.ToString();
                string idSexo = filaSeleccionada.Cells[7].Value.ToString();

                frmEditarCliente form = new frmEditarCliente(codCliente, apellido, nombre, codTipoDoc, documento, fechaNacimiento, nroTelefono, idSexo, this);
                form.ShowDialog();
                //btnBuscar_Click(this, EventArgs.Empty);
            }
            else if (e.ColumnIndex == 9)
            {
                int index = e.RowIndex;
                int codCliente = Convert.ToInt32(dgvDetalleC.CurrentRow.Cells[0].Value);
                if (((DataGridViewButtonCell)dgvDetalleC.Rows[index].Cells["colEliminar"]).FlatStyle == FlatStyle.Flat)
                {
                    // Aquí puedes mostrar un mensaje indicando que el botón está deshabilitado o realizar cualquier otra acción necesaria.
                    //MessageBox.Show("El botón Eliminar no está disponible para este cliente.");
                    return;
                } else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {

                        if (await EliminarCliente(codCliente))
                        {
                            MessageBox.Show("Cliente eliminado correctamente.");
                            btnBuscar_Click(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el cliente.");
                        }
                    }
                }
                
            }
        }

        public async Task<bool> EliminarCliente(int idCliente)
        {
            string url = string.Format("https://localhost:7114/DeteleCli?id={0}", idCliente);
            var result = await ClienteSingleton.getI().DeleteAsync(url);
            if (result.Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDetalleC.SelectedRows.Count > 0)
            {
                int codCliente = Convert.ToInt32(dgvDetalleC.SelectedRows[0].Cells[0].Value);
                frmDetallesCompra formularioDetalles = new frmDetallesCompra(codCliente);
                formularioDetalles.ShowDialog();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
