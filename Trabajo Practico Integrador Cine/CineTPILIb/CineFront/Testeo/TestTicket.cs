using CineTPILIb.Dominio;
using CineTPILIb.Servicios.Implementaciones;
using CineTPILIb.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Testeo
{
    public partial class TestTicket : Form
    {
        Ticket ticket;
        IServicioFunciones servicioFunciones = null;
        IServicioTickets servicioTickets = null;
        public TestTicket()
        {
            InitializeComponent();
            servicioFunciones = new ServicioFunciones();
            servicioTickets = new ServicioTickets();
            ticket = new Ticket();
        }

        private void TestTicket_Load(object sender, EventArgs e)
        {
            //CargarClientes();
            CargarFunciones();
            //CargarPromociones();
            //CargarMetodosDeVenta();
            //CargarButacas();
            //CargarFormasDePago();
        }

        //private void CargarFormasDePago()
        //{
        //    cboFormaDePago.DataSource = servicioTickets.GetFormaDePagos();
        //    cboFormaDePago.ValueMember = "id_forma_pago";
        //    cboFormaDePago.DisplayMember = "descripcion";
        //}

        //private void CargarButacas()
        //{
        //    cboButaca.DataSource = servicioTickets.GetButacas();
        //    cboButaca.ValueMember = "id_butaca";
        //    cboButaca.DisplayMember = "numero";
        //}

        //private void CargarMetodosDeVenta()
        //{
        //    cboMedioDeVenta.DataSource = servicioTickets.GetMedioDeVenta();
        //    cboMedioDeVenta.ValueMember = "id_medio_pedido";
        //    cboMedioDeVenta.DisplayMember = "descripcion";
        //}

        //private void CargarPromociones()
        //{
        //    cboPromocion.DataSource = servicioTickets.GetPromociones();
        //    cboPromocion.ValueMember = "id_promocion";
        //    cboPromocion.DisplayMember = "porcentaje_descuento";
        //}

        private void CargarFunciones()
        {
            cboFuncion.DataSource = servicioTickets.GetFunciones();
            cboFuncion.ValueMember = "id_funcion";
            cboFuncion.DisplayMember = "id_funcion";
        }

        //private void CargarClientes()
        //{
        //    cboCliente.DataSource = servicioTickets.GetClientes();
        //    cboCliente.ValueMember = "ID";
        //    cboCliente.DisplayMember = "Nombre";
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int id_funcion = 1;
            int id_pelicula = 1;
            Funcion f = new Funcion(id_funcion, id_pelicula);
            int id_butaca = 1;
            decimal precio_venta = 1;

            DetalleTicket detalle = new DetalleTicket(f, id_butaca, precio_venta);
            ticket.AgregarDetalle(detalle);



            ticket.Fecha = dtpFecha.Value;
            ticket.Id_cliente = 1;
            ticket.Id_medio_pedido = 1;
            ticket.Id_promocion = 1;
            ticket.Total = 2000;
            ticket.Id_forma_pago = 1;
            if (servicioTickets.NuevoTicket(ticket))
            {
                MessageBox.Show("Se ingreo el ticket", "Contro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
