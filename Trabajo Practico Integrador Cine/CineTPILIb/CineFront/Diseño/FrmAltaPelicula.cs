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
        }

        private void cboClasif_Click(object sender, EventArgs e)
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


            await GuardarPeliculaAsync();

            if (guardar)
            {
                dgvAltaPelicula.Rows.Add(new object[] { nuevo.Id_pelicula, nuevoDTO.Titulo, nuevoDTO.Duracion, nuevoDTO.Clasificacion, nuevoDTO.Genero, nuevoDTO.Idioma });
                MessageBox.Show("Pelicula agregada al catalogo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        bool guardar = false;
        private async Task GuardarPeliculaAsync()
        {
            //datos de la pelicula:
            nuevo.Titulo = txtTitulo.Text;
            nuevo.Duracion = Convert.ToInt32(txtDuracion.Text);
            nuevo.Sinopsis = txtSinopsis.Text;
            nuevo.Clasificacion = new Clasificacion();
            nuevo.Clasificacion.IdClasificacion = cboClasif.SelectedIndex + 1;
            nuevo.Clasificacion.ClasificacionName = cboClasif.Text;
            nuevo.Genero = new Genero();
            nuevo.Genero.IdGenero = cboGenero.SelectedIndex + 1;
            nuevo.Genero.GeneroName = cboGenero.Text;
            nuevo.Idioma = new Idioma();
            nuevo.Idioma.IdIdioma = cboIdioma.SelectedIndex + 1;
            nuevo.Idioma.IdiomaName = cboIdioma.Text;

            string bodyContent = JsonConvert.SerializeObject(nuevo);
            string url = "https://localhost:7074/api/Peliculas";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                guardar = true;
            }
            else
            {
                MessageBox.Show("No se pudo agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //private async Task BorrarPresupuestoAsync(int idPelicula)
        //{
        //    string url = $"http://localhost:5031/api/Peliculas/{idPelicula}";
        //    var result = await ClientSingleton.GetInstance().DeleteAsync(url);

        //    if (!string.IsNullOrEmpty(result))
        //    {
        //        MessageBox.Show("Película eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        // Realiza otras acciones necesarias después de la eliminación
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se pudo eliminar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}




        //private async void dgvAltaPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvAltaPelicula.CurrentCell.ColumnIndex == 6)
        //    {
        //        int id = Convert.ToInt32(dgvAltaPelicula.Rows[e.RowIndex].Cells["colId"].Value);

        //        await BorrarPresupuestoAsync(id);

        //        dgvAltaPelicula.Rows.Remove(dgvAltaPelicula.CurrentRow);
        //        //presupuesto.quitarDetalle();


        //    }
        //}
    }
}