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

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id_funcion = Convert.ToInt32(txtNumero.Text);
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;

            CargarFunciones(id_funcion, desde, hasta);
        }
        private async void CargarFunciones(int id_funcion, DateTime desde, DateTime hasta)
        {
            string url = string.Format("https://localhost:7074/funciones?desde={0}&hasta={1}&id_funcion={0}", desde, hasta,id_funcion);
            var result = await ClientSingleton.GetInstance().GetAsync(url);

            var lst = JsonConvert.DeserializeObject<List<FuncionDTO>>(result);

            dgvFunciones.Rows.Clear();
            if (lst != null)
            {
                foreach (FuncionDTO funcion in lst)
                {
                    dgvFunciones.Rows.Add(new object[] {funcion.Pelicula, funcion.Sala, funcion.Horario, funcion.FechaDesde, funcion.FechaHasta, funcion.Precio});
                }
            }
            else
            {
                MessageBox.Show("Sin datos de la funcion para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
