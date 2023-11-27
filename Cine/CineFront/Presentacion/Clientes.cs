namespace CineFront.Presentacion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoCliente nuevo = new frmNuevoCliente();
            nuevo.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente nuevo = new frmConsultarCliente();
            nuevo.Show();
        }
    }
}
