using CineFront.Http;
using CineTPILIb.Dominio.DTO;
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

namespace CineFront.Diseño
{
    public partial class FrmConsultarFunciones : Form
    {
        public FrmConsultarFunciones()
        {
            InitializeComponent();
        }

        private void FrmConsultarFunciones_Load(object sender, EventArgs e)
        {
            Limpiar();
            dtpDesde.Value = dtpDesde.Value.AddYears(-3);
            dtpHasta.Value = dtpHasta.Value.AddMonths(1);
        }

        private void Limpiar()
        {
            txtNumero.Text = String.Empty;
            dgvFunciones.Rows.Clear();
        }


        private async void CargarFunciones(string id_funcion, string desde, string hasta)
        {
            string url = string.Format("https://localhost:7074/funciones?desde={0}&hasta={1}", desde, hasta);
            if (!String.IsNullOrEmpty(id_funcion))
                url = String.Format(url + "&id_funcion={0}", id_funcion);
            var result = await ClientSingleton.GetInstance().GetAsync(url);

            var lst = JsonConvert.DeserializeObject<List<FuncionDTO>>(result);

            dgvFunciones.Rows.Clear();
            if (lst != null)
            {
                foreach (FuncionDTO funcion in lst)
                {
                    dgvFunciones.Rows.Add(new object[] { funcion.ID, funcion.Pelicula, funcion.Sala, funcion.TipoSala, funcion.Horario, funcion.FechaDesde, funcion.FechaHasta, funcion.Precio });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de la funcion para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private async Task BajaFuncionAsync()
        {
            int id = Convert.ToInt32(dgvFunciones.Rows[dgvFunciones.CurrentRow.Index].Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres dar de baja esta función?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string url = $"https://localhost:7074/api/Funciones/{id}";
                try
                {

                    string response = await ClientSingleton.GetInstance().DeleteAsync(url);
                    if (!string.IsNullOrEmpty(response))
                    {
                        MessageBox.Show("La función se dio de baja con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Cerrar el formulario después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de baja la función.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la solicitud DELETE: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            //

            string desde, hasta, id_funcion;
            id_funcion = Uri.EscapeDataString(txtNumero.Text);
            desde = Uri.EscapeDataString(dtpDesde.Value.ToString("yyyy/MM/dd"));
            hasta = Uri.EscapeDataString(dtpHasta.Value.ToString("yyyy/MM/dd"));

            CargarFunciones(id_funcion, desde, hasta);
            Limpiar();
        }

        private async void dgvFunciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunciones.CurrentCell.ColumnIndex == 8)
            {
                await BajaFuncionAsync();
                dgvFunciones.Rows.Remove(dgvFunciones.CurrentRow);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvFunciones.CurrentRow.Cells["ColID"].Value.ToString());
            new FrmUpdateFuncion(nro).ShowDialog();
        }

        private void FrmConsultarFunciones_Load_1(object sender, EventArgs e)
        {

        }
    }
}
