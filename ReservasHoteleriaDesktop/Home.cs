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

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
