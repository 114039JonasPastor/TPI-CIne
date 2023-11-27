using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporteGanancias : Form
    {
        public FrmReporteGanancias()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CineOKDataSet3 d = new CineOKDataSet3();
            SqlConnection cnn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CineOK;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SP_Reporte2", cnn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;
            da.SelectCommand.Parameters.AddWithValue("@desde", fechaDesde);
            da.SelectCommand.Parameters.AddWithValue("@hasta", fechaHasta);
            da.Fill(d, d.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("DataSet10", d.Tables[0]);
            this.reportViewer3.LocalReport.DataSources.Clear();
            this.reportViewer3.LocalReport.DataSources.Add(rds);
            reportViewer3.LocalReport.ReportEmbeddedResource = "CineFront.Diseño.Report3.rdlc";
            reportViewer3.RefreshReport();
        }
    }
}
