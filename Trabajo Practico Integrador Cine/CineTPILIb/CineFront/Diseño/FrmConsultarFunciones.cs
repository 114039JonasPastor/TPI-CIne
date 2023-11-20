using CineFront.Http;
using CineTPILIb.Dominio;
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
            CargarPeliculasAsync();
        }

        private async void CargarPeliculasAsync()
        {
            string url = "https://localhost:7074/peliculas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Pelicula>>(result);

            cboTitulo.DataSource = lst;
            cboTitulo.DisplayMember = "Titulo";
            cboTitulo.ValueMember = "Id_pelicula";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("Periodo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String fecDesde, fecHasta, pelicula;
            fecDesde = Uri.EscapeDataString(dtpDesde.Value.ToString("yyyy/MM/dd"));
            fecHasta = Uri.EscapeDataString(dtpHasta.Value.ToString("yyyy/MM/dd"));
            pelicula = Uri.EscapeDataString(cboTitulo.Text);

            CargarFuncion(fecDesde, fecHasta, pelicula);
        }

        private async void CargarFuncion(string desde, string hasta, string pelicula)
        {
            string url = string.Format("https://localhost:7074/api/Funciones?desde={0}&hasta={1}", desde, hasta);
            if (!String.IsNullOrEmpty(pelicula))
                url = String.Format(url + "&pelicula={0}", pelicula);

            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<FuncionDTO>>(result);
            dgvFunciones.Rows.Clear();
            if (lst != null)
            {
                foreach (FuncionDTO funcion in lst)
                {
                    dgvFunciones.Rows.Add(new object[] {
                    funcion.Pelicula,
                    funcion.Sala,
                    funcion.Horario,
                    funcion.FechaDesde,
                    funcion.FechaHasta,
                    funcion.Precio
                    });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de la funcion para los filtros ingresados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
