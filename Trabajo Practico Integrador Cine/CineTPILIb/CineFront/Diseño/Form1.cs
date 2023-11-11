namespace CineFront
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
            if(txtContraseña.Text == String.Empty && txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Ingrese su Usuario y/o contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(txtUsuario.Text != String.Empty && txtContraseña.Text != String.Empty)
            {
                if(txtUsuario.Text == "Admin" && txtContraseña.Text == "Password")
                {
                    FrmMenu menu = FrmMenu.ObtenerInstancia();
                    menu.Show();
                    this.Hide();
                }
            }
            if(txtUsuario.Text != "Admin" || txtContraseña.Text != "Password")
            {
                MessageBox.Show("Usuario y/o contrasela incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContraseña.Checked) txtContraseña.UseSystemPasswordChar = false;
            else txtContraseña.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}