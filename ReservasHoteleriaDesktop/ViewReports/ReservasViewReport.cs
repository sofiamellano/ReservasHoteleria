using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using ReservasHoteleriaServices.Models;
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
    public partial class ReservasViewReport : Form
    {
        ReportViewer report;
        private RH_Reserva nuevaReserva;
        public ReservasViewReport()
        {
            InitializeComponent();
            report = new ReportViewer();
            report.Dock = DockStyle.Fill;
            Controls.Add(report);
            nuevaReserva = new RH_Reserva();
        }
         public ReservasViewReport(RH_Reserva? nuevaReserva)
        {
            InitializeComponent();
            this.nuevaReserva = nuevaReserva ?? new RH_Reserva();
            report = new ReportViewer();

            report.Dock = DockStyle.Fill;
            Controls.Add(report);
        }

        private void ReservasViewReport_Load(object sender, EventArgs e)
        {
            if (nuevaReserva == null)
            {
                MessageBox.Show("Error: nuevaReserva no está inicializado.");
                return;
            }

            try
            {
                report.LocalReport.ReportEmbeddedResource = "ReservasHoteleriaDesktop.Reports.ReservasReport.rdlc";
                var reserva = new List<object>
                {
                    new
                    {
                        ID = nuevaReserva.ID,
                        FechaReserva = nuevaReserva.FechaReserva,
                        FechaCheckIn = nuevaReserva.FechaCheckIn,
                        FechaCheckOut = nuevaReserva.FechaCheckOut,
                        EstadoReserva = nuevaReserva.EstadoReserva,
                        TipoHabitacion = nuevaReserva.Habitacion?.TipoHabitacion
                    }
                };
                report.LocalReport.DataSources.Add(new ReportDataSource("DSReservas", reserva));



                report.SetDisplayMode(DisplayMode.PrintLayout);
                report.ZoomMode = ZoomMode.Percent;
                report.ZoomPercent = 100;
                report.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}");
            }
        }
    }
}
