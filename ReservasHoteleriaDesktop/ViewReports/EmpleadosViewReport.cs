using Microsoft.Reporting.WinForms;
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
    public partial class EmpleadosViewReport : Form
    {
        ReportViewer reporte;
        IEmpleadosService empleadosService = new EmpleadosService();
        public EmpleadosViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            this.Controls.Add(reporte);
        }

        private async void EmpleadosViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ReservasHoteleriaDesktop.Reports.EmpleadosReport.rdlc";
            var empleados = await empleadosService.GetAllAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleados", empleados));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
