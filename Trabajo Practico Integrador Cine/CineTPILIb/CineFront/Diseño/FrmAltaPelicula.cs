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
        }
    }
}
