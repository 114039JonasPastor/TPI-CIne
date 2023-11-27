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
    public partial class FrmAltaFuncion : Form
    {
        private Funcion nueva;
        private FuncionDTO nuevaDTO;
        public FrmAltaFuncion()
        {
            InitializeComponent();
            nueva = new Funcion();
            nuevaDTO = new FuncionDTO();
        }

        private void FrmAltaFuncion_Load(object sender, EventArgs e)
        {
            dtpHasta.Value = dtpHasta.Value.AddDays(14);
        }

        private void cboSala_Click(object sender, EventArgs e)
        {
            CargarSalasAscync();

        }

        private void cboPelicula_Click(object sender, EventArgs e)
        {
            CargarPeliculasAsync();

        }

        private void cboHorarios_Click(object sender, EventArgs e)
        {
            CargarHorariosAsync();

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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboHorarios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar una pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboSala.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar una sala", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboHorarios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar un horario", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio.Text == String.Empty)
            {
                MessageBox.Show("Debe de ingresar un precio", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvFunciones.Rows.Count == 1)
            {
                MessageBox.Show("Solo puede cargar una funcion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nuevaDTO.Pelicula = cboPelicula.Text;
            nuevaDTO.Sala = Convert.ToInt32(cboSala.Text);
            nuevaDTO.Horario = cboHorarios.Text;
            nuevaDTO.FechaDesde = dtpDesde.Value;
            nuevaDTO.FechaHasta = dtpHasta.Value;
            nuevaDTO.Precio = Convert.ToDouble(txtPrecio.Text);

            dgvFunciones.Rows.Add(new object[] { nuevaDTO.ID, nuevaDTO.Pelicula, nuevaDTO.Sala, nuevaDTO.Horario, nuevaDTO.FechaDesde, nuevaDTO.FechaHasta, nuevaDTO.Precio });
            await GuardarFuncionAsync();
        }

        private async Task GuardarFuncionAsync()
        {
            nueva.Id_sala = cboSala.SelectedIndex + 1;
            nueva.Id_pelicula = cboPelicula.SelectedIndex + 1;
            nueva.Precio = Convert.ToDouble(txtPrecio.Text);
            nueva.FechaDesde = dtpDesde.Value;
            nueva.FechaHasta = dtpHasta.Value;
            nueva.IdHorario = cboHorarios.SelectedIndex + 1;

            string bodyContent = JsonConvert.SerializeObject(nueva);
            string url = "https://localhost:7074/api/Funciones";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Funcion agregada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar la funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunciones.CurrentCell.ColumnIndex == 7)
            {
                dgvFunciones.Rows.Remove(dgvFunciones.CurrentRow);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmAltaFuncion_Load_1(object sender, EventArgs e)
        {

        }
    }
}
