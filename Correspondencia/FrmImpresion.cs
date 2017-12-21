using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correspondencia
{
    public partial class FrmImpresion : Form
    {
        DataTable dt;
        public FrmImpresion(DataTable dt_ref)
        {
            InitializeComponent();
            dt = dt_ref;
        }

        private LocalReport parametros_locales()
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"Reporte.rdlc";

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("NroRecepcion", "holamundo"));
            report.SetParameters(reportParams);

            return report;
        }

        private void FrmImpresion_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Report", parametros_locales());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
