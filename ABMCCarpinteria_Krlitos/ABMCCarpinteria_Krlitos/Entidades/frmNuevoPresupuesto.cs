using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ABMCCarpinteria_Krlitos.Datos;

namespace ABMCCarpinteria_Krlitos.Entidades
{
    public partial class frmNuevoPresupuesto : Form
    {
        private Presupuesto pres;
        private DBHelper g = new DBHelper();
        public frmNuevoPresupuesto()
        {
            InitializeComponent();
            pres = new Presupuesto();
            CargarCombo(cboProducto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToString();
            txtCliente.Text = "Consumidor Final";
            txtDescuento.Text = "0";
            txtCantidad.Text = "1";
            ProximoPresupuesto();
        }

        private void CargarCombo(ComboBox combo)
        {
            DataTable tabla = g.CargarProductos();
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void ProximoPresupuesto()
        { 
            lblPresupuestoNro.Text = lblPresupuestoNro.Text + g.ProximoPresupuesto().ToString();
        }

        private DetallePresupuesto NuevoDetalle()
        {
            DataRowView item = (DataRowView)cboProducto.SelectedItem;

            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre = Convert.ToDouble(item.Row.ItemArray[2].ToString());
            Producto p = new Producto(nro,nom,pre);
            int cant = Convert.ToInt32(txtCantidad.Text);
            DetallePresupuesto de = new DetallePresupuesto(p, cant);
            return de;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto... PUTO"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida... PUTO"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            if (double.Parse(txtDescuento.Text)< 0 || double.Parse(txtDescuento.Text) > 100)
            {
                MessageBox.Show("Debe ingresar un descuento entre 0 y 100... PUTO"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count > 0) { }
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
                {

                    if (fila.Cells["colProducto"].Value.ToString().Equals(cboProducto.Text))
                    {
                        MessageBox.Show("El producto ya está presupuestado... PUTO"
                                    , "Control"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            DetallePresupuesto de = NuevoDetalle();
            pres.AgregarDetalle(de);
            dgvDetalles.Rows.Add(de.PProducto.ProductoNro,
                                 de.PProducto.Nombre,
                                 de.PProducto.Precio,
                                 de.Cantidad,
                                 "Quitar");
            CalcularTotales();

        }

        private void CalcularTotales()
        {
            double total = pres.CalcularTotal();
            txtSubTotal.Text = total.ToString();
            double dto = total * Convert.ToDouble(txtDescuento.Text) / 100;
            txtTotal.Text = (total - dto).ToString();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                    pres.QuitarDetalle(e.RowIndex);
                    dgvDetalles.Rows.RemoveAt(e.RowIndex);
                    CalcularTotales();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar😎 (Carita Refacherita)
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                MessageBox.Show("Debe ingresar un cliente... PUTO"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count==0)
            {
                MessageBox.Show("Debe ingresar al menos un producto... PUTO"
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                return;
            } else
            {
                GrabarPresupuesto();
            }
            
        }
        private void GrabarPresupuesto()
        {
            pres.Fecha = Convert.ToDateTime(txtFecha.Text);
            pres.Cliente = Convert.ToString(txtCliente.Text);
            pres.Descuento = Convert.ToDouble(txtDescuento.Text);
            if (g.ConfirmarPresupuesto(pres))
            {
                MessageBox.Show("Se grabó con éxito el presupuesto... PUTO"
                                , "Informe"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {

            }
        }
    }
}
