using Microsoft.Reporting.WinForms;
using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Services;

namespace ReservasHoteleriaDesktop.ViewReports
{
    public partial class ServiciosViewReport : Form
    {
        ReportViewer reporte;
        IServicioService servicioService = new ServicioService();
        public ServiciosViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            this.Controls.Add(reporte);
        }

        private async void ServiciosViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ReservasHoteleriaDesktop.Reports.Servicios.rdlc";
            var servicios = await servicioService.GetAllAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSServicios", servicios));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
