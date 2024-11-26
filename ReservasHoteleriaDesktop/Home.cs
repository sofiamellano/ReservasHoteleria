using ReservasHoteleriaDesktop.ViewReports;
using ReservasHoteleriaDesktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasHotelDesktop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void MenuReservas_Click(object sender, EventArgs e)
        {
            ReservasViews reservasViews = new ReservasViews();
            reservasViews.ShowDialog();
        }

        private void MenuEmpleados_Click(object sender, EventArgs e)
        {
            EmpleadosViews empleadosViews = new EmpleadosViews();
            empleadosViews.ShowDialog();
        }

        private void MenuHabitaciones_Click(object sender, EventArgs e)
        {
            HabitacionesViews habitacionesViews = new HabitacionesViews();
            habitacionesViews.ShowDialog();
        }

        private void MenuServicios_Click(object sender, EventArgs e)
        {
            ServiciosViews serviciosViews = new ServiciosViews();
            serviciosViews.ShowDialog();
        }

        private void MenuServiciosAdicionales_Click(object sender, EventArgs e)
        {
            ServiciosAdiconalesViews serviciosAdiconalesViews = new ServiciosAdiconalesViews();
            serviciosAdiconalesViews.ShowDialog();
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMenuEmpleados_Click(object sender, EventArgs e)
        {
            EmpleadosViewReport empleadosViewReport = new EmpleadosViewReport();
            empleadosViewReport.ShowDialog();
        }

        private void iconMenuHabitaciones_Click(object sender, EventArgs e)
        {
            HabitacionesViewReport habitacionesViewReport = new HabitacionesViewReport();
            habitacionesViewReport.ShowDialog();
        }

        private void iconMenuServicios_Click(object sender, EventArgs e)
        {
            ServiciosViewReport serviciosViewReport = new ServiciosViewReport();
            serviciosViewReport.ShowDialog();
        }

        private void iconMenuServiciosAdicionales_Click(object sender, EventArgs e)
        {
            ServiciosAdicionalesViewReport serviciosAdicionalesViewReport = new ServiciosAdicionalesViewReport();
            serviciosAdicionalesViewReport.ShowDialog();
        }
    }
}
