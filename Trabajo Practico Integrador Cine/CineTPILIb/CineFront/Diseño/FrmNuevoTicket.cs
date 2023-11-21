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
    public partial class FrmNuevoTicket : Form
    {
        private Ticket nuevo;
        public FrmNuevoTicket()
        {
            InitializeComponent();
            nuevo = new Ticket();
        }

        private void FrmNuevoTicket_Load(object sender, EventArgs e)
        {
            CargarClientesAsync();
            CargarFuncionAsync();
            CargarButacasAsync();
            CargarMediosDeVentaAsync();
            CargarFormasDePagoAsync();
            CargarPromocionesAsync();
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

            cboPromocion.DataSource = lst;
            cboPromocion.DisplayMember = "Recargo";
            cboPromocion.ValueMember = "IdFormaPago";
        }

        private async void CargarMediosDeVentaAsync()
        {
            string url = "https://localhost:7074/Medio de venta";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<MedioDeVenta>>(result);

            cboPromocion.DataSource = lst;
            cboPromocion.DisplayMember = "Descripcion";
            cboPromocion.ValueMember = "IdMedioPago";
        }

        private async void CargarButacasAsync()
        {
            string url = "https://localhost:7074/Butacas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Butaca>>(result);

            cboPromocion.DataSource = lst;
            cboPromocion.DisplayMember = "NroButaca";
            cboPromocion.ValueMember = "IdButaca";
        }

        private async void CargarFuncionAsync()
        {
            string url = "https://localhost:7074/Combo Funciones";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Funcion>>(result);

            cboPromocion.DataSource = lst;
            cboPromocion.DisplayMember = "Id_funcion";
            cboPromocion.ValueMember = "Id_funcion";
        }

        private async void CargarClientesAsync()
        {
            string url = "https://localhost:7074/Clientes";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);

            cboPromocion.DataSource = lst;
            cboPromocion.DisplayMember = "Nombre";
            cboPromocion.ValueMember = "IdCliente";
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

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)
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
            if(cboCliente.SelectedIndex == -1)
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
            if(txtPrecioVenta.Text == String.Empty)
            {
                MessageBox.Show("Debe de ingresar un precio de venta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Funcion f = (Funcion)cboFuncion.SelectedItem;
            int id_butaca = Convert.ToInt32(cboButaca.SelectedIndex + 1);
            double precio_venta = Convert.ToDouble(txtPrecioVenta.Text);

            DetalleTicket detalle = new DetalleTicket(f,id_butaca,precio_venta);
            nuevo.AgregarDetalle(detalle);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
