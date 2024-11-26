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
    public partial class HabitacionesViewReport : Form
    {
        ReportViewer reporte;
        IHabitacionService habitacionService = new HabitacionService();
        public HabitacionesViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            this.Controls.Add(reporte);
        }

        private async void HabitacionesViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ReservasHoteleriaDesktop.Reports.HabitacionesReport.rdlc";
            var habitacion = await habitacionService.GetAllAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSHabitaciones", habitacion));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
