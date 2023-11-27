using Cine_Back.Datos;
using Cine_Back.Datos.Implementacion;
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
    public partial class ConsultarFunciones : Form
    {
        IServicio s;
        FuncionDao d;
        Parametro idPeliParam = new Parametro();
        Parametro idTipoParam = new Parametro();
        Parametro fechaFuncionParam = new Parametro();
        List<Parametro> lista;
        public ConsultarFunciones()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd HH:mm";
            Load += ConsultarFunciones_LoadAsync;
            s = new Servicio();
            d = new FuncionDao();
            idPeliParam = new Parametro();
            idTipoParam = new Parametro();
            fechaFuncionParam = new Parametro();
            lista = new List<Parametro>();
        }

        private async void ConsultarFunciones_LoadAsync(object sender, EventArgs e)
        {
            try
            {

                await CargarComboPeliAsync(cboPelicula2);
                await CargarComboSalaAsync(cboFuncion2);
                //dgvFunciones.CellContentClick += async (s, ce) => await dgvFunciones_CellContentClickAsync(s, ce);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            idPeliParam.Nombre = "@IdPeli";
            idPeliParam.Valor = cboPelicula2.SelectedValue;
            idTipoParam.Nombre = "@IdTipo";
            idTipoParam.Valor = cboFuncion2.SelectedValue;
            fechaFuncionParam.Nombre = "@FechaFuncion";
            fechaFuncionParam.Valor = dtpFecha.Value.Date;//.ToString("yyyyMMdd");
            lista.Add(idPeliParam);
            lista.Add(idTipoParam);
            lista.Add(fechaFuncionParam);
            LlenarGrilla();
            /*lst.Add(new Parametro("@IdPeli", cboPelicula2.SelectedValue));
            lst.Add(new Parametro("@IdTipo", cboFuncion2.SelectedValue));
            lst.Add(new Parametro("@FechaFuncion", dtpFecha.Value.Date));//.ToString("yyyyMMdd")));*/
        }

        public void LlenarGrilla()
        {
            DataTable tabla = s.GetFuncionesXFiltro(lista);
            dgvFunciones.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvFunciones.Rows.Add(new object[] { fila["codFuncion"].ToString(),
                                                        fila["NombrePelicula"].ToString(),
                                                        fila["tipoSala"].ToString(),
                                                        ((DateTime)fila["fechaHora"]).ToString("yyyy-MM-dd HH:mm:ss"),
                                                        "Eliminar",
                                                        "Modificar",
                                                        fila["CodiPeli"].ToString(),
                                                        fila["CodiFormat"].ToString(),
                                                        fila["nroSala"].ToString()                                  });
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void dgvFunciones_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunciones.Rows.Count == 0)
            {
                return;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvFunciones.Columns["colAccion1"].Index)
            {

                int codFuncion = Convert.ToInt32(dgvFunciones.CurrentRow.Cells[0].Value);
                int fila = Convert.ToInt32(dgvFunciones.CurrentRow.Index);
                Parametro pam = new Parametro("@codFuncion", codFuncion);

                //if (await EliminarFuncionAsync(pam))
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar la función?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (await EliminarFuncionAsync(pam))
                    //if (d.BorrarFuncion(pam))
                    {
                        MessageBox.Show("Se Eliminó con éxito la función... 😎"
                                        , "Informe"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Exclamation);
                        LlenarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al Eliminar la función... 😔"
                                        , "Informe"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Exclamation);
                    }
                }
                

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvFunciones.Columns["colAccion2"].Index)
            {
                DataGridViewRow filaSeleccionada = dgvFunciones.Rows[e.RowIndex];
                string codFuncion = filaSeleccionada.Cells[0].Value.ToString();
                string pelicula = filaSeleccionada.Cells[6].Value.ToString();
                string nroSala = filaSeleccionada.Cells[8].Value.ToString();
                string fechaHora = filaSeleccionada.Cells[3].Value.ToString();
                string format = filaSeleccionada.Cells[7].Value.ToString();

                frmModificarFunciones form = new frmModificarFunciones(codFuncion, pelicula, fechaHora, nroSala, format, this);
                form.ShowDialog();
            }
        }



        private async Task<bool> EliminarFuncionAsync(Parametro pa)
        {
            string url = string.Format("https://localhost:7114/DeleteFunc?codFuncion={0}", pa.Valor);
            //string queryString = $"?nombre={pa.Nombre}&valor={pa.Valor}";
            //string urlWithQueryString = url + queryString;
            var dataJson = await ClienteSingleton.getI().DeleteAsync(url);
            if (dataJson == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //  if (dgvFunciones.CurrentCell.ColumnIndex == 6)
        //{
        //  int nro = int.Parse(dgvFunciones.CurrentRow.Cells["colFuncion"].Value.ToString());
        //new frmModificarFunciones(nro).ShowDialog();
        //}
        //}
    }
}