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
            if(txtContrase�a.Text == String.Empty && txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Ingrese su Usuario y/o contrase�a", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(txtUsuario.Text != String.Empty && txtContrase�a.Text != String.Empty)
            {
                if(txtUsuario.Text == "Admin" && txtContrase�a.Text == "Password")
                {
                    FrmMenu menu = FrmMenu.ObtenerInstancia();
                    menu.Show();
                    this.Hide();
                }
            }
            if(txtUsuario.Text != "Admin" || txtContrase�a.Text != "Password")
            {
                MessageBox.Show("Usuario y/o contrasela incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkContrase�a_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContrase�a.Checked) txtContrase�a.UseSystemPasswordChar = false;
            else txtContrase�a.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}