using CineFront.Http;
using CineTPILIb.Dominio;
using Newtonsoft.Json;

namespace CineFront.Diseño
{
    public partial class FrmConsultaPelicula : Form
    {
        public FrmConsultaPelicula()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmConsultaPelicula_Load(object sender, EventArgs e)
        {
            CargarIdiomasAsync();
            CargarGenerosAsync();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string titulo = Uri.EscapeDataString(txtTitulo.Text);
            string sinopsis = Uri.EscapeDataString(txtSinopsis.Text);
            int id_genero = Convert.ToInt32(cboGenero.SelectedIndex + 1);
            int id_idioma = Convert.ToInt32(cboIdioma.SelectedIndex + 1);
            CargarPeliculas(id_genero, id_idioma, sinopsis, titulo);

        }

        private async void CargarPeliculas(int id_genero, int id_idioma, string sinopsis, string titulo)
        {
            // Construir la URL con los parámetros
            string url = string.Format("https://localhost:7074/peliculas?id_genero={0}&id_idioma={1}",
                                       id_genero, id_idioma, sinopsis, titulo);

            if (!String.IsNullOrEmpty(sinopsis))
                url = String.Format(url + "&sinopsis={0}", sinopsis);

            if (!String.IsNullOrEmpty(titulo))
                url = String.Format(url + "&titulo={0}", titulo);

            // Realizar la solicitud GET a la API
            var result = await ClientSingleton.GetInstance().GetAsync(url);

            // Deserializar la respuesta JSON en una lista de objetos Pelicula
            var lst = JsonConvert.DeserializeObject<List<Pelicula>>(result);

            // Limpiar las filas existentes en el DataGridView
            dgvPelicula.Rows.Clear();

            // Verificar si se obtuvieron datos
            if (lst != null)
            {
                // Iterar sobre la lista de Peliculas y agregarlas al DataGridView
                foreach (Pelicula pelicula in lst)
                {
                    dgvPelicula.Rows.Add(new object[] {
                                            pelicula.Id_pelicula,
                                            pelicula.Titulo,
                                            pelicula.Sinopsis,
                                            pelicula.Clasificacion.ClasificacionName,
                                            pelicula.Genero.GeneroName,
                                            pelicula.Idioma.IdiomaName, "Ver Detalles"     });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de películas para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chkConsulta_CheckedChanged(object sender, EventArgs e)
        {
            //txtTitulo.Enabled = false;
            //txtSinopsis.Enabled = false;
            //cboGenero.Enabled = false;
            //cboIdioma.Enabled = false;
        }

        private void FrmConsultaPelicula_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
