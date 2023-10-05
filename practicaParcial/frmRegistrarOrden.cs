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
using practicaParcial.Datos;
using practicaParcial.Entidades;
using practicaParcial.Servicios;
using practicaParcial.Servicios.Implementacion;
using practicaParcial.Servicios.Interfaz;

namespace practicaParcial
{
    public partial class frmRegistrarOrden : Form
    {
        IServicio s;
        private Orden orden;
        private FabricaServicio f;
        public frmRegistrarOrden(FabricaServicioImp fa)
        {
            InitializeComponent();
            f = fa;
            s = f.GetServicio();
            orden = new Orden();
        }

        private void Actualizar()
        {
            if (dgvDetalle.Rows.Count > 0 && txtResponsable.Text != "")
            {
                btnAceptar.Enabled = true;
            } else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void frmRegistrarOrden_Load(object sender, EventArgs e)
        {
            CargarCombo(cboMateriales);
            dgvDetalle.Columns[0].DataPropertyName = "Id";
            dgvDetalle.Columns[1].DataPropertyName = "Nombre";
            dgvDetalle.Columns[2].DataPropertyName = "Stock";
            dgvDetalle.Columns[3].DataPropertyName = "Cantidad";
            Actualizar();
        }

        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = s.GetProductos();
            combo.ValueMember = "Id";
            combo.DisplayMember = "Nombre";
        }
            
        private DetalleOrden nuevoDetalle()
        {
            Producto item = (Producto)cboMateriales.SelectedItem;

            /*int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            int stock = Convert.ToInt32(item.Row.ItemArray[2].ToString());
            Producto p = new Producto(nro, nom, stock);*/
            int cant = Convert.ToInt32(nudCantidad.Value);
            DetalleOrden de = new DetalleOrden(item, cant);
            return de;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto pp = (Producto)cboMateriales.SelectedItem;
            if (pp.Stock < nudCantidad.Value)
            {
                MessageBox.Show("No hay stock suficiente...🥺"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            else if (cboMateriales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Material...😤"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            } else if (nudCantidad.Value == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad...😤"
                                                   , "Control"
                                                   , MessageBoxButtons.OK
                                                   , MessageBoxIcon.Exclamation);
                return;
            } else if (txtResponsable.Text == "")
            {
                MessageBox.Show("Debe ingresar un responsable...😤"
                                                   , "Control"
                                                   , MessageBoxButtons.OK
                                                   , MessageBoxIcon.Exclamation);
                return;
            } else if (dgvDetalle.Rows.Count > 0)
            {
                foreach (DataGridViewRow f in dgvDetalle.Rows)
                {
                    if (f.Cells[0].Value.ToString() == cboMateriales.SelectedValue.ToString())
                    {
                        MessageBox.Show("El material ya fue ingresado...😤"
                                                   , "Control"
                                                   , MessageBoxButtons.OK
                                                   , MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            } 
            DetalleOrden de = nuevoDetalle();
            orden.AgregarDetalle(de);
            orden.Responsable = txtResponsable.Text;
            dgvDetalle.Rows.Add(de.PProducto.Id,
                                 de.PProducto.Nombre,
                                 de.PProducto.Stock,
                                 de.Cantidad,
                                 "Quitar");
            Actualizar();

        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                orden.QuitarDetalle(e.RowIndex);
                dgvDetalle.Rows.RemoveAt(e.RowIndex);
                Actualizar();
            } else
            {
                Actualizar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (s.EnviarOrden(orden))
            {
                MessageBox.Show("Se grabó con éxito el presupuesto...😎"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
            } else
            {
                MessageBox.Show("No se pudo grabar el presupuesto...😤"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation); 
                this.Dispose();
            }
        }

        private void txtResponsable_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
