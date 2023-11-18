using CineFront.Http;
using CineTPILIb.Dominio;
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
    public partial class FrmAltaFuncion : Form
    {
        private Funcion nueva;
        public FrmAltaFuncion()
        {
            InitializeComponent();
            nueva = new Funcion();
        }

        private void lblSala_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaFuncion_Load(object sender, EventArgs e)
        {
            CargarPeliculasAsync();
            CargarSalasAscync();
            CargarFormatosAsync();
        }

        private async void CargarFormatosAsync()
        {
            string url = "https://localhost:7074/clasificaciones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clasificacion>>(result);
        }

        private async void CargarSalasAscync()
        {
            string url = "https://localhost:7074/clasificaciones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clasificacion>>(result);
        }

        private async void CargarPeliculasAsync()
        {
            string url = "https://localhost:7074/clasificaciones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clasificacion>>(result);
        }
    }
}
