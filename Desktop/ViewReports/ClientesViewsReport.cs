using Desktop.Services;
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

namespace Desktop.ViewReports
{
    public partial class ClientesViewsReport : Form
    {
        ReportViewer _report;
        ClientesApiService clientesApiService = new ClientesApiService();
        public ClientesViewsReport()
        {
            InitializeComponent();
            _report = new ReportViewer();
            _report.Dock = DockStyle.Fill;
            this.Controls.Add(_report);
        }


        private async void ClientesViewsReport_Load(object sender, EventArgs e)
        {
            _report.LocalReport.ReportEmbeddedResource = "Desktop.Report.Clientes.rdlc";

            var clientes = await clientesApiService.GetAllAsync();
            _report.LocalReport.DataSources.Add(new ReportDataSource("DSClientes", clientes));
            _report.SetDisplayMode(DisplayMode.PrintLayout);
            _report.ZoomMode = ZoomMode.Percent;
            _report.ZoomPercent = 100;

            _report.RefreshReport();
        }
    }
}
