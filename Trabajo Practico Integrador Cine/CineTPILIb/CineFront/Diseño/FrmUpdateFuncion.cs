using CineFront.Http;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Diseño
{
    public partial class FrmUpdateFuncion : Form
    {
        private int id;
        public FrmUpdateFuncion(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FrmSeleccionarFuncion_Load(object sender, EventArgs e)
        {
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
        }

        private void LoadHorarios(object sender, EventArgs e)
        {
            CargarHorariosAsync();
        }
        private void LoadPeliculass(object sender, EventArgs e)
        {
            CargarPeliculasAsync();
        }
        private void LoadSalas(object sender, EventArgs e)
        {
            CargarSalasAscync();
        }

        private async void CargarHorariosAsync()
        {
            string url = "https://localhost:7074/Combo Horarios";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Horario>>(result);

            cboHorarios.DataSource = lst;
            cboHorarios.DisplayMember = "hora";
            cboHorarios.ValueMember = "IdHorario";
        }

        private async void CargarSalasAscync()
        {
            string url = "https://localhost:7074/Combo Salas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Sala>>(result);

            cboSala.DataSource = lst;
            cboSala.DisplayMember = "NroSala";
            cboSala.ValueMember = "IdSala";
        }

        private async void CargarPeliculasAsync()
        {
            string url = "https://localhost:7074/Combo Peliculas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<PeliculaDTO>>(result);

            cboPelicula.DataSource = lst;
            cboPelicula.DisplayMember = "ID";
            cboPelicula.ValueMember = "Titulo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese un precio.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ActualizarFuncionAsync();
        }
        private async void ActualizarFuncionAsync()
        {
            Funcion funcionModificada = new Funcion
            {
                Id_funcion = id,
                Id_sala = Convert.ToInt32(cboSala.SelectedIndex + 1),
                Id_pelicula = Convert.ToInt32(cboPelicula.SelectedIndex + 1),
                Precio = Convert.ToDouble(txtPrecio.Text),
                FechaDesde = Convert.ToDateTime(dtpDesde.Value),
                FechaHasta = Convert.ToDateTime(dtpHasta.Value),
                IdHorario = Convert.ToInt32(cboHorarios.SelectedIndex + 1)
            };

            string funcionJson = JsonConvert.SerializeObject(funcionModificada);
            string url = string.Format("https://localhost:7074/api/Funciones/{0}", id);

            try
            {
                string response = await ClientSingleton.GetInstance().UpdateAsync(url, funcionJson);

                if (!string.IsNullOrEmpty(response))
                {
                    MessageBox.Show("La función se modificó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al modificar la función.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud PUT: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUpdateFuncion_Load(object sender, EventArgs e)
        {
            CargarPeliculasAsync();
            CargarSalasAscync();
            CargarHorariosAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
