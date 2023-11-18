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
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                FrmLogin frmLogin = FrmLogin.ObtenerInstancia();
                this.Dispose();
                frmLogin.Dispose();
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                FrmLogin frmLogin = FrmLogin.ObtenerInstancia();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void consultarPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPelicula consultaPelicula = new FrmConsultaPelicula();
            consultaPelicula.ShowDialog();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin frmLogin = FrmLogin.ObtenerInstancia();
            frmLogin.Dispose();
        }

        private void nuevaPelículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPelicula frmAltaPelicula = new FrmAltaPelicula();
            frmAltaPelicula.ShowDialog();
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
    }
}
