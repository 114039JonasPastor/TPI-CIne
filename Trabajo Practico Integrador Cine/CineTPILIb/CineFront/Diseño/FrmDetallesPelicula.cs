using CineFront.Http;
using CineTPILIb.Dominio;
using Newtonsoft.Json;

namespace CineFront.Diseño
{
    public partial class FrmDetallesPelicula : Form
    {
        private int id;
        public FrmDetallesPelicula(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FrmDetallesPelicula_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            Activar(false);
            CargarPelicula();

        }

        private void Activar(bool activar)
        {
            txtTitulo.Enabled = activar;
            txtSinopsis.Enabled = activar;
            txtDuracion.Enabled = activar;
            cboClasificacion.Enabled = activar;
            cboGenero.Enabled = activar;
            cboIdioma.Enabled = activar;
        }


        private async void CargarPelicula()
        {
            string url = string.Format("https://localhost:7074/api/Peliculas/{0}", id);
            var result = await ClientSingleton.GetInstance().GetAsync(url);

            var peli = JsonConvert.DeserializeObject<Pelicula>(result);
            if (peli != null)
            {
                lblID.Text = peli.Id_pelicula.ToString();
                txtTitulo.Text = peli.Titulo.ToString();
                txtSinopsis.Text = peli.Sinopsis.ToString();
                txtDuracion.Text = peli.Duracion.ToString();
                cboClasificacion.Text = peli.Clasificacion.ClasificacionName.ToString();
                cboGenero.Text = peli.Genero.GeneroName.ToString();
                cboIdioma.Text = peli.Idioma.IdiomaName.ToString();
            }
            else
            {
                MessageBox.Show("No se pudo recuperar información de la pelicula", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            Activar(true);

        }
        private void cboClasificacion_Click(object sender, EventArgs e)
        {
            CargarClasificacionesAsync();

        }

        private void cboGenero_Click(object sender, EventArgs e)
        {
            CargarGenerosAsync();

        }

        private void cboIdioma_Click(object sender, EventArgs e)
        {
            CargarIdiomasAsync();

        }

        private async void CargarClasificacionesAsync()
        {
            string url = "https://localhost:7074/clasificaciones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clasificacion>>(result);

            cboClasificacion.DataSource = lst;
            cboClasificacion.DisplayMember = "ClasificacionName";
            cboClasificacion.ValueMember = "IdClasificacion";
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
        private async void CargarIdiomasAsync()
        {
            string url = "https://localhost:7074/idiomas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Idioma>>(result);

            cboIdioma.DataSource = lst;
            cboIdioma.DisplayMember = "IdiomaName";
            cboIdioma.ValueMember = "IdIdioma";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            chkBaja.Checked = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            Activar(false);
            CargarPelicula();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (chkBaja.Checked)
            {
                BajaPelicula();

            }
            else
            {
                ActualizarPelicula();

                btnModificar.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                Activar(false);
                CargarPelicula();
            }


        }

        private async void BajaPelicula()
        {

            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta película?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string url = $"https://localhost:7074/api/Peliculas/{id}";

                try
                {

                    string response = await ClientSingleton.GetInstance().DeleteAsync(url);
                    if (!string.IsNullOrEmpty(response))
                    {
                        MessageBox.Show("La película se eliminó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Cerrar el formulario después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la solicitud DELETE: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ActualizarPelicula()
        {

            Pelicula peliculaModificada = new Pelicula
            {
                Id_pelicula = id,
                Titulo = txtTitulo.Text,
                Sinopsis = txtSinopsis.Text,
                Duracion = Convert.ToInt32(txtDuracion.Text),
                Clasificacion = (Clasificacion)cboClasificacion.SelectedItem,
                Genero = (Genero)cboGenero.SelectedItem,
                Idioma = (Idioma)cboIdioma.SelectedItem
            };

            string jsonPelicula = JsonConvert.SerializeObject(peliculaModificada);
            string url = string.Format("https://localhost:7074/api/Peliculas/{0}", id);

            try
            {
                string response = await ClientSingleton.GetInstance().UpdateAsync(url, jsonPelicula);

                if (!string.IsNullOrEmpty(response))
                {
                    MessageBox.Show("La película se modificó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al modificar la película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud PUT: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaja.Checked)
            {
                Activar(true);
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
            }
            else
            {
                Activar(false);
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
            }

        }

    }
}






