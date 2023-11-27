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
using System.Runtime.Intrinsics.X86;
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
            CargarReporte();
        }

        private void CargarReporte()
        {
            CineOKDataSet d = new CineOKDataSet();

            SqlConnection cnn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CineOK;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SP_GENEROS", cnn);
            da.Fill(d, d.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("DataSetTest", d.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Diseño.Report1.rdlc";
            reportViewer1.RefreshReport();

            CineOKDataSet1 d1 = new CineOKDataSet1();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT titulo, sinopsis, duracion FROM PELICULAS", cnn);
            da1.Fill(d1, d1.Tables[0].TableName);

            ReportDataSource rds1 = new ReportDataSource("DataSet2", d1.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Diseño.Report1.rdlc";
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CineOKDataSet d = new CineOKDataSet();

            SqlConnection cnn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CineOK;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SP_GENEROS", cnn);
            da.Fill(d, d.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("DataSetTest", d.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Diseño.Report1.rdlc";

            int aux = (int)comboBox1.SelectedValue;
            CineOKDataSet1 d1 = new CineOKDataSet1();
            SqlDataAdapter da1 = new SqlDataAdapter("select* from PELICULAS where id_genero = " + aux + "", cnn);
            da1.Fill(d1, d1.Tables[0].TableName);

            ReportDataSource rds1 = new ReportDataSource("DataSet2", d1.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Diseño.Report1.rdlc";
            reportViewer1.RefreshReport();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
