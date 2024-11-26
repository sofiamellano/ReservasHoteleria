using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasHoteleriaDesktop.ViewReports
{
    public partial class ServiciosAdicionalesViewReport : Form
    {
        ReportViewer reporte;
        IServicioAdicionalService servicioAdicionalService = new ServicioAdicionalService();
        public ServiciosAdicionalesViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            this.Controls.Add(reporte);
        }

        private async void ServiciosAdicionalesViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ReservasHoteleriaDesktop.Reports.ServiciosAdicionales.rdlc";
            var serviciosAdicionales = await servicioAdicionalService.GetAllAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSServiciosAdicionales", serviciosAdicionales));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
