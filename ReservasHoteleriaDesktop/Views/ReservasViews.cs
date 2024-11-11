using Microsoft.EntityFrameworkCore.Diagnostics;
using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;

namespace ReservasHoteleriaDesktop.Views
{
    public partial class ReservasViews : Form
    {
        IGenericService<RH_Reserva> reservaService = new GenericService<RH_Reserva>();

        BindingSource ListReservas = new BindingSource();

        List<RH_Reserva> ListaFiltro = new List<RH_Reserva>();

        RH_Reserva reservaCurrent;
        public ReservasViews()
        {
            InitializeComponent();
            dataGridReservas.DataSource = ListReservas;
            LoadData();
        }

        private void LoadData()
        {
            ListReservas.DataSource = reservaService.GetAllAsync();
            ListaFiltro = ListReservas.DataSource as List<RH_Reserva>;
            dataGridReservas.Columns["ID"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            reservaCurrent = (RH_Reserva) ListReservas.Current;
            //terminar de hacer los textbox
        }
    }
}
