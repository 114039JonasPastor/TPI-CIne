using CineTPILIb.Dominio;
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
    public partial class FrmDetallesPelicula : Form
    {
        private Pelicula peli = null;
        public FrmDetallesPelicula(Pelicula peli)
        {
            InitializeComponent();
            this.peli = peli;
        }

        private void FrmDetallesPelicula_Load(object sender, EventArgs e)
        {
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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
