using CineFront.Http;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using CineTPILIb.Servicios.Implementaciones;
using CineTPILIb.Servicios.Interfaces;
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
    public partial class FrmNuevoTicket : Form
    {
        private IServicioTickets servicio;
        private Ticket nuevo;
        public FrmNuevoTicket()
        {
            InitializeComponent();
            nuevo = new Ticket();
            servicio = new ServicioTickets();
        }

        private void FrmNuevoTicket_Load(object sender, EventArgs e)
        {
            ProximoTicket();

        }

        private void LoadClientes(object sender, EventArgs e)
        {
            CargarClientesAsync();
            txtPrecioVenta.Enabled = false;
        }

        private void LoadTxtPrecioVenta(object sender, EventArgs e)
        {
            txtPrecioVenta.Text = cboFuncion.SelectedValue.ToString();
        }
        private void LoadPromociones(object sender, EventArgs e)
        {
            CargarPromocionesAsync();
        }
        private void LoadFormasDePago(object sender, EventArgs e)
        {
            CargarFormasDePagoAsync();
        }
        private void LoadButacas(object sender, EventArgs e)
        {
            CargarButacasAsync();
        }
        private void LoadFuncion(object sender, EventArgs e)
        {
            CargarFuncionAsync();
        }
        private void LoadMediosDeVenta(object sender, EventArgs e)
        {
            CargarMediosDeVentaAsync();
        }

        private void ProximoTicket()
        {
            int next = servicio.ObtenerProximoNro();
            if (next > 0)
                lblTicket.Text = "Ticket Nº: " + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de ticket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void CargarPromocionesAsync()
        {
            string url = "https://localhost:7074/Promociones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Promocion>>(result);

            cboPromocion.DataSource = lst;
            cboPromocion.DisplayMember = "PorcentajeDescuento";
            cboPromocion.ValueMember = "IdPromocion";
        }

        private async void CargarFormasDePagoAsync()
        {
            string url = "https://localhost:7074/Formas de pago";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<FormaDePago>>(result);

            cboFormaDePago.DataSource = lst;
            cboFormaDePago.DisplayMember = "Descripcion";
            cboFormaDePago.ValueMember = "IdFormaPago";
        }

        private async void CargarMediosDeVentaAsync()
        {
            string url = "https://localhost:7074/Medio de venta";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<MedioDeVenta>>(result);

            cboMedioDeVenta.DataSource = lst;
            cboMedioDeVenta.DisplayMember = "Descripcion";
            cboMedioDeVenta.ValueMember = "IdMedioPago";
        }

        private async void CargarButacasAsync()
        {
            string url = "https://localhost:7074/Butacas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Butaca>>(result);

            cboButaca.DataSource = lst;
            cboButaca.DisplayMember = "NroButaca";
            cboButaca.ValueMember = "IdButaca";
        }

        private async void CargarFuncionAsync()
        {
            string url = "https://localhost:7074/Combo Funciones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Funcion>>(result);

            cboFuncion.DataSource = lst;
            cboFuncion.DisplayMember = "Id_funcion";
            cboFuncion.ValueMember = "precio";
        }

        private async void CargarClientesAsync()
        {
            string url = "https://localhost:7074/Clientes";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);

            cboCliente.DataSource = lst;
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "IdCliente";
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            await GuardarTicketAsync();
        }

        private async Task GuardarTicketAsync()
        {
            nuevo.Fecha = dtpFecha.Value;
            nuevo.Id_cliente = Convert.ToInt32(cboCliente.SelectedIndex + 1);
            nuevo.Id_medio_pedido = Convert.ToInt32(cboMedioDeVenta.SelectedIndex + 1);
            nuevo.Id_promocion = Convert.ToInt32(cboPromocion.SelectedIndex + 1);
            nuevo.Total = Convert.ToDecimal(txtPrecioVenta.Text);
            nuevo.Id_forma_pago = Convert.ToInt32(cboFormaDePago.SelectedIndex + 1);

            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7074/api/Tickets";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Ticket registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el Ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar un cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar una función", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboButaca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar una butaca", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboMedioDeVenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar un medio de venta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboFormaDePago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar una forma de pago", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboPromocion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar una promoción", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPrecioVenta.Text == String.Empty)
            {
                MessageBox.Show("Debe de ingresar un precio de venta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //ver
            foreach (DataGridViewRow item in dgvTicket.Rows)
            {
                if (item.Cells["ColButaca"].ToString().Equals(cboButaca.Text))
                {
                    MessageBox.Show("No puede elegir la misma butaca", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            AltaTicketDTO ticketDTO = new AltaTicketDTO();
            ticketDTO.Cliente = cboCliente.Text;
            ticketDTO.NroFuncion = cboFuncion.SelectedIndex + 1;
            ticketDTO.Fecha = dtpFecha.Value;
            ticketDTO.Butaca = cboButaca.Text;
            ticketDTO.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
            ticketDTO.MedioDeVenta = cboMedioDeVenta.Text;
            ticketDTO.FormaDePago = cboFormaDePago.Text;
            ticketDTO.Descuento = Convert.ToInt32(cboPromocion.SelectedIndex + 1);

            Funcion f = (Funcion)cboFuncion.SelectedItem;
            int id_butaca = Convert.ToInt32(cboButaca.SelectedIndex + 1);
            decimal precio_venta = Convert.ToDecimal(txtPrecioVenta.Text);

            DetalleTicket detalle = new DetalleTicket(f, id_butaca, precio_venta);
            nuevo.AgregarDetalle(detalle);
            dgvTicket.Rows.Add(new object[] { ticketDTO.Cliente, ticketDTO.NroFuncion, ticketDTO.Fecha, ticketDTO.Butaca, ticketDTO.PrecioVenta, ticketDTO.MedioDeVenta, ticketDTO.FormaDePago, ticketDTO.Descuento, CalcularTotal() });
        }

        private double CalcularTotal()
        {
            double precioVenta = Convert.ToDouble(txtPrecioVenta.Text);
            int descuento = Convert.ToInt32(cboPromocion.Text);

            double subTotal = precioVenta - (precioVenta * descuento) / 100;

            return subTotal;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTicket.CurrentCell.ColumnIndex == 9)
            {
                dgvTicket.Rows.Remove(dgvTicket.CurrentRow);
                nuevo.RemoverDetalle(dgvTicket.CurrentRow.Index);
            }
        }

        private void FrmNuevoTicket_Load_1(object sender, EventArgs e)
        {

        }
    }
}
