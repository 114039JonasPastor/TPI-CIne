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
    public partial class FrmAltaPelicula : Form
    {
        private Pelicula nuevo;
        private PeliculaDTO nuevoDTO;
        public FrmAltaPelicula()
        {
            InitializeComponent();
            nuevo = new Pelicula();
            nuevoDTO = new PeliculaDTO();
        }

        private void FrmAltaPelicula_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = "Nueva película";
            txtTitulo.Focus();
            txtDuracion.Text = "0";
            txtSinopsis.Text = "Sinopsis...";
            CargarClasificacionesAsync();
            CargarIdiomasAsync();
            CargarGenerosAsync();
        }

        private async void CargarClasificacionesAsync()
        {
            string url = "https://localhost:7074/clasificaciones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clasificacion>>(result);
            cboClasif.DataSource = lst;
            cboClasif.DisplayMember = "ClasificacionName";
            cboClasif.ValueMember = "IdClasificacion";
        }
        private async void CargarIdiomasAsync()
        {
            string url = "https://localhost:7074/idiomas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Idioma>>(result);
            cboIdioma.DataSource = lst;
            cboIdioma.DisplayMember = "IdiomaName";
            cboIdioma.ValueMember = "IdIdioma";
        }
        private async void CargarGenerosAsync()
        {
            string url = "https://localhost:7074/generos";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Genero>>(result);
            cboGenero.DataSource = lst;
            cboGenero.DisplayMember = "GeneroName";
            cboGenero.ValueMember = "IdGenero";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Debe ingresar un titulo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtDuracion.Text == "0")
            {
                MessageBox.Show("La duracion no puede ser 0!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevoDTO.Titulo = txtTitulo.Text;
            nuevoDTO.Duracion = Convert.ToInt32(txtDuracion.Text);
            nuevoDTO.Clasificacion = cboClasif.Text;
            nuevoDTO.Genero = cboGenero.Text;
            nuevoDTO.Idioma = cboIdioma.Text;

            dgvAltaPelicula.Rows.Add(new object[] { nuevoDTO.Titulo, nuevoDTO.Duracion, nuevoDTO.Clasificacion, nuevoDTO.Genero, nuevoDTO.Idioma });

            await GuardarPeliculaAsync();
        }

        private async Task GuardarPeliculaAsync()
        {
            //datos de la pelicula:
            nuevo.Titulo = txtTitulo.Text;
            nuevo.Duracion = Convert.ToInt32(txtDuracion.Text);
            nuevo.Sinopsis = txtSinopsis.Text;
            nuevo.Id_clasificacion = cboClasif.SelectedIndex + 1;
            nuevo.Id_genero = cboGenero.SelectedIndex + 1;
            nuevo.Id_idioma = cboIdioma.SelectedIndex + 1;

            string bodyContent = JsonConvert.SerializeObject(nuevo);
            string url = "https://localhost:7074/api/Peliculas";//tenia mal la url
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))  //servicio.CrearPelicula(nuevo)
            {
                MessageBox.Show("Pelicula agregada al catalogo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //agregar al listado
            }
            else
            {
                MessageBox.Show("No se pudo agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
