using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_Parcial2.Servicios;
using Practica_Parcial2.Servicios.Int;
using Practica_Parcial2.Dominio;
using Practica_Parcial2.Datos.DTOs;
namespace Practica_Parcial2
{
    public partial class frmConsultas : Form
    {
        IServicio s;

        public frmConsultas(FabricaServicioImp f)
        {
            InitializeComponent();
            s = f.GetServicio();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            CargarCombo(cboClientes);
            dtpDesde.Value = Convert.ToDateTime("01/01/2000");
            dtpHasta.Value = DateTime.Now;
            Actualizar();
        }

        private void CargarCombo(ComboBox cbo)
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente Aux = new Cliente();
            Aux.Id = -2;
            Aux.NombreYApellido = "Todos los Clientes";
            clientes.Add(Aux);
            foreach (Cliente c in s.TraerClientes(dtpDesde.Value, dtpHasta.Value))
            {
                clientes.Add(c);
            }
            cbo.DataSource = clientes;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "NombreYApellido";

        }

        private PedidoDTO nuevoPedidoDTO(Pedido pe, string nom, string ape, int id)
        {
            PedidoDTO p = new PedidoDTO();
            p.Codigo = pe.Codigo;
            p.Cliente = $"{ape}, {nom}";
            p.FechaEntrega = pe.FechaEntrega;
            p.Entregado = pe.Entregado;

            return p;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();
            List<Cliente> clientes = s.TraerClientes(dtpDesde.Value, dtpHasta.Value);
            Cliente cboC = (Cliente)cboClientes.SelectedItem;
            List<PedidoDTO> pedidosDTO = new List<PedidoDTO>();
            
            if (cboC.Id == -2)
            {
                foreach (Cliente cliente in clientes)
                {
                    foreach (Pedido p in cliente.Pedidos)
                    {
                        PedidoDTO pedidoNuevo = nuevoPedidoDTO(p, cliente.Nombre, cliente.Apellido, cliente.Id);
                        pedidosDTO.Add(pedidoNuevo);
                        dgvPedidos.Rows.Add(pedidoNuevo.Codigo, pedidoNuevo.Cliente, pedidoNuevo.FechaEntrega, pedidoNuevo.Entregado, "Entregar", "Dar de Baja");
                    }
                }
            } else
            {
                foreach (Pedido p in cboC.Pedidos)
                {
                    PedidoDTO pedidoNuevo = nuevoPedidoDTO(p, cboC.Nombre, cboC.Apellido, cboC.Id);
                    pedidosDTO.Add(pedidoNuevo);
                    dgvPedidos.Rows.Add(pedidoNuevo.Codigo, pedidoNuevo.Cliente, pedidoNuevo.FechaEntrega, pedidoNuevo.Entregado, "Entregar", "Dar de Baja");
                }
                
            }
            
           


            lblNro.Text = dgvPedidos.Rows.Count.ToString();
        }

        private List<Pedido> Pedidos()
        {
            List<Cliente> clientes = s.TraerClientes(dtpDesde.Value, dtpHasta.Value);
            List<Pedido> pedidos = new List<Pedido>();
            foreach (Cliente cliente in clientes)
            {
                foreach (Pedido p in cliente.Pedidos)
                {
                    pedidos.Add(p);
                }
            }
            return pedidos;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            if(dtpDesde.Value != null && dtpHasta.Value != null && cboClientes.SelectedIndex != -1)
            {
                btnConsultar.Enabled = true;
            } else
            {
                btnConsultar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Cliente> clientes = s.TraerClientes(dtpDesde.Value, dtpHasta.Value);
            string comparacion = string.Empty;
            PedidoDTO pedidoDTO = new PedidoDTO();
            Pedido pedido = new Pedido();
            int nroPedido = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 4)
            {
                foreach (Cliente c in clientes)
                {
                    foreach (Pedido p in c.Pedidos)
                    {
                        if (p.Codigo == nroPedido)
                        {
                            comparacion = p.Entregado;
                            pedido = p;
                            pedidoDTO = nuevoPedidoDTO(p, c.Nombre, c.Apellido, c.Id);
                        }
                    }
                }
                
                if (comparacion == "s" || comparacion == "S")
                {
                    MessageBox.Show("El pedido se entregó anteriormente!🥰");
                } else
                {
                    if (s.Entregar(nroPedido) == 1)
                    {
                        MessageBox.Show("El pedido se entregó correctamente!🥰");
                        dgvPedidos.Rows.RemoveAt(e.RowIndex);
                        pedidoDTO.Entregado = "S";
                        dgvPedidos.Rows.Add(pedidoDTO.Codigo, pedidoDTO.Cliente, pedidoDTO.FechaEntrega, pedidoDTO.Entregado, "Entregar", "Dar de Baja");
                    } else
                    {
                        MessageBox.Show("No se pudo concretar la entrega del pedido!");
                    }
                }
            } else if (e.ColumnIndex == 5)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea dar de baja el pedido?", "Dar de baja pedido", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (s.DarDeBaja(nroPedido) == 1)
                    {
                        MessageBox.Show("El pedido se eliminó correctamente!🥰");
                        dgvPedidos.Rows.RemoveAt(e.RowIndex);
                        lblNro.Text = dgvPedidos.Rows.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el pedido!");
                    }
                }
            }
        }
    }
}
