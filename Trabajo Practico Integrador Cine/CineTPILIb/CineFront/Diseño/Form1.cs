using CineFront.Http;
using CineTPILIb.Dominio;
using CineTPILIb.Dominio.DTO;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Diseño
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MaximizeBox= false;
            CargarGenero();
        }

        private async void CargarGenero()
        {
            string url = "https://localhost:7074/generos";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Genero>>(result);
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "GeneroName";
            comboBox1.ValueMember = "IdGenero";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet1 d = new DataSet1();
            string cs = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CineOK;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select titulo, sinopsis from Peliculas", cnn);
            da.Fill(d, d.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("DataSet1", d.Tables[0]);




            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Diseño.Report1.rdlc";
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aux = (int)comboBox1.SelectedValue;

            DataSet1 d = new DataSet1();
            string cs = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CineOK;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select* from PELICULAS where id_genero = "+aux+"", cnn);
            da.Fill(d, d.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("DataSet1", d.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Diseño.Report1.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
