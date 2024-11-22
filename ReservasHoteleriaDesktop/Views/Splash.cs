using Microsoft.Reporting.WinForms;
using ReservasHotelDesktop;
using ReservasHoteleriaServices.Models;
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

namespace ReservasHoteleriaDesktop.Views
{
    public partial class Splash : Form
    {
        bool DataRedy = false;
        bool PrintReady = false;
        public Splash()
        {
            InitializeComponent();
        }

        private async void Splash_Activated(object sender, EventArgs e)
        {
            var conectarDbTask = ConectarConDb();
            var imprimirReporteTask = ImprimirReporte();
            await Task.WhenAll(conectarDbTask, imprimirReporteTask);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 98)
                progressBar.Value += 2;
            if (DataRedy && PrintReady)
            {
                timer1.Enabled = false;
                this.Visible = false;
                var frmHome = new Home();
                frmHome.ShowDialog();
                this.Close();
            }
        }
        private async Task ImprimirReporte()
        {
            await Task.Run(() =>
            {
                var inicio = DateTime.Now;
                ReportViewer report = new ReportViewer();
                report.LocalReport.ReportEmbeddedResource = "ReservasHoteleriaDesktop.Reports.ReservasReport.rdlc";
                var reserva = new List<object>{
                    new { ID = 1, NombreCliente = "Maria Gomez", EstadoReserva = "Cancelada", FechaCheckIn = DateTime.Now.AddDays(-1), FechaCheckOut = DateTime.Now, TipoHabitacion = "Doble" }
                };
                report.LocalReport.DataSources.Add(new ReportDataSource("DSReservas", reserva));
                report.SetDisplayMode(DisplayMode.PrintLayout);
                report.RefreshReport();
                PrintReady = true;
            });
        }
        private async Task ConectarConDb()
        {
            await Task.Run(async () =>
            {
                ReservaService reservaService = new ReservaService();
                var reservas = await reservaService.GetAllAsync();
                DataRedy = true;
            });
        }
    }
}
