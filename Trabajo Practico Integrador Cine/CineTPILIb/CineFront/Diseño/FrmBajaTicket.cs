using CineFront.Http;
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
    public partial class FrmBajaTicket : Form
    {
        public FrmBajaTicket()
        {
            InitializeComponent();
        }

        private void FrmBajaTicket_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtClientes.Text = String.Empty;
            txtNumeroDeTicket.Text = String.Empty;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnConsular_Click(object sender, EventArgs e)
        {
            string nroTicket, fechaEmision, cliente;
            nroTicket = Uri.EscapeDataString(txtNumeroDeTicket.Text);
            fechaEmision = Uri.EscapeDataString(dtpFecha.Value.ToString("yyyy/MM/dd"));
            cliente = Uri.EscapeDataString(txtClientes.Text);

            CargarTicktes(nroTicket, fechaEmision, cliente);
            Limpiar();
        }

        //https://localhost:7074/Tickets Filtro?id=1&fecha=2020-12-12&cliente=jorge

        private async void CargarTicktes(string nroTicket, string fechaEmision, string cliente)
        {
            string url = string.Format("https://localhost:7074/TicketsFiltro?fecha={0}", fechaEmision);
            if (!String.IsNullOrEmpty(cliente))
                url = String.Format(url + "&cliente={0}", cliente);
            if (!String.IsNullOrEmpty(nroTicket))
                url = String.Format(url + "&id={0}", nroTicket);
            var result = await ClientSingleton.GetInstance().GetAsync(url);

            var lst = JsonConvert.DeserializeObject<List<TicketDTO>>(result);

            dgvTicket.Rows.Clear();

            if (lst != null)
            {
                foreach (TicketDTO ticket in lst)
                {
                    dgvTicket.Rows.Add(new object[] { ticket.NroTicket, ticket.Cliente, ticket.FechaEmision });
                }
            }
            else
            {
                MessageBox.Show("Sin datos del ticket para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTicket.CurrentCell.ColumnIndex == 3)
            {
                BajaTicketAsync();
                dgvTicket.Rows.Remove(dgvTicket.CurrentRow);
            }
        }

        private async Task BajaTicketAsync()
        {
            int id = Convert.ToInt32(dgvTicket.Rows[dgvTicket.CurrentRow.Index].Cells[0].Value);

            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres dar de baja este ticket?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string url = $"https://localhost:7074/api/Tickets/{id}";
                try
                {

                    string response = await ClientSingleton.GetInstance().DeleteAsync(url);
                    if (!string.IsNullOrEmpty(response))
                    {
                        MessageBox.Show("El ticket se dio de baja con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Cerrar el formulario después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de baja el ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la solicitud DELETE: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
