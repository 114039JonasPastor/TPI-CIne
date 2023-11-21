using System.Diagnostics;

namespace CineFront.Diseño
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/alexis-chanam%C3%A9-181638237/";
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/leandro-gomez-aparicio";
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/114039JonasPastor/";
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/luciano-manzanelli";
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Luciano1732";
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/franco-dominguez-208425228/";
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

