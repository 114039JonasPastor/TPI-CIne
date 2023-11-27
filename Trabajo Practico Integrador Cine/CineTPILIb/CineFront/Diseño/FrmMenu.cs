using CineFront.Diseño;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class FrmMenu : Form
    {
        private static FrmMenu instancia;

        public static FrmMenu ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmMenu();
            }
            return instancia;
        }
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                FrmLogin frmLogin = FrmLogin.ObtenerInstancia();
                this.Dispose();
                frmLogin.Dispose();
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                FrmLogin frmLogin = FrmLogin.ObtenerInstancia();
                frmLogin.Show();
                this.Hide();
            }
        }


        private void consultarPeliculasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmConsultaPelicula consultaPelicula = new FrmConsultaPelicula();
            consultaPelicula.ShowDialog();
        }

        private void nuevaPelículaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAltaPelicula frmAltaPelicula = new FrmAltaPelicula();
            frmAltaPelicula.ShowDialog();
        }

        private void agregarFuncionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaFuncion frmAltaFuncion = new FrmAltaFuncion();
            frmAltaFuncion.ShowDialog();
        }

        private void consultarFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarFunciones frmConsultarFuncion = new FrmConsultarFunciones();
            frmConsultarFuncion.ShowDialog();
        }

        private void nuevoTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoTicket frmNuevoTicket = new FrmNuevoTicket();
            frmNuevoTicket.ShowDialog();
        }

        private void bajaTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaTicket frmBajaTicket = new FrmBajaTicket();
            frmBajaTicket.ShowDialog();
        }

        private void consultarPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPelicula frmConsultaPelicula = new FrmConsultaPelicula();
            frmConsultaPelicula.ShowDialog();
        }

        private void nuevaPelículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPelicula frmAltaPelicula = new FrmAltaPelicula();
            frmAltaPelicula.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void quienesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void gananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteGanancias form = new FrmReporteGanancias();
            form.ShowDialog();
        }
    }
}