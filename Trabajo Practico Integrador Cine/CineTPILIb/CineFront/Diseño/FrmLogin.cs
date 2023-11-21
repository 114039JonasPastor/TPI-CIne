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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private static FrmLogin instancia;

        public static FrmLogin ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmLogin();
            }
            return instancia;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == String.Empty && txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Ingrese su Usuario y/o contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtUsuario.Text != String.Empty || txtContraseña.Text != String.Empty)
            {
                if (txtUsuario.Text != "Admin" || txtContraseña.Text != "Password")
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //if (txtUsuario.Text == "Admin" && txtContraseña.Text == "Password")
                else
                {
                    FrmMenu menu = FrmMenu.ObtenerInstancia();
                    menu.Show();
                    this.Hide();
                }
            }

        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContraseña.Checked) txtContraseña.UseSystemPasswordChar = false;
            else txtContraseña.UseSystemPasswordChar = true;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            chkContraseña.Checked = false;
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
