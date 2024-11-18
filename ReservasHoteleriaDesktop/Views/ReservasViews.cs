using Microsoft.EntityFrameworkCore.Diagnostics;
using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;

namespace ReservasHoteleriaDesktop.Views
{
    public partial class ReservasViews : Form
    {
        IReservaService reservaService = new ReservaService();
        IHabitacionService habitacionService = new HabitacionService();
        BindingSource ListReservas = new BindingSource();

        RH_Reserva reservaCurrent;
        public ReservasViews()
        {
            InitializeComponent();
            dataGridReservas.DataSource = ListReservas;
            LoadData();
            LoadCombo();
        }

        private async Task LoadCombo()
        {
            comboHabitacion.DataSource = await habitacionService.GetAllAsync();
            comboHabitacion.DisplayMember = "TipoHabitacion";
            comboHabitacion.ValueMember = "ID";
            comboHabitacion.SelectedIndex = -1;
        }

        private async Task LoadData()
        {
            var reservas = await reservaService.GetAllAsync(null);
            ListReservas.DataSource = reservas;

            dataGridReservas.Columns["ID"].Visible = false;
            dataGridReservas.Columns["HabitacionID"].Visible = false;
            dataGridReservas.Columns["Eliminado"].Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (reservaCurrent != null)
            {
                reservaCurrent.HabitacionID = (int)comboHabitacion.SelectedValue;
                reservaCurrent.FechaReserva = dateTimeFechaReserva.Value;
                reservaCurrent.FechaCheckIn = dateTimeCheckIn.Value;
                reservaCurrent.FechaCheckOut = dateTimeCheckOut.Value;
                reservaCurrent.EstadoReserva = txtEstadoReserva.Text;
                reservaCurrent.Habitacion = (RH_Habitacion)comboHabitacion.SelectedItem;
                await reservaService.UpdateAsync(reservaCurrent);
                reservaCurrent = null;
            }
            else
            {
                var reserva = new RH_Reserva
                {
                    HabitacionID = (int)comboHabitacion.SelectedValue,
                    FechaReserva = dateTimeFechaReserva.Value,
                    FechaCheckIn = dateTimeCheckIn.Value,
                    FechaCheckOut = dateTimeCheckOut.Value,
                    EstadoReserva = txtEstadoReserva.Text,
                    Habitacion = (RH_Habitacion)comboHabitacion.SelectedItem
                };
                await reservaService.AddAsync(reserva);
            }
            await LoadData();
            txtEstadoReserva.Text = string.Empty;
            dateTimeFechaReserva.Value = DateTime.Now;
            dateTimeCheckIn.Value = DateTime.Now;
            dateTimeCheckOut.Value = DateTime.Now;
            comboHabitacion.SelectedIndex = -1;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reservaCurrent = null;
            txtEstadoReserva.Text = string.Empty;
            dateTimeFechaReserva.Value = DateTime.Now;
            dateTimeCheckIn.Value = DateTime.Now;
            dateTimeCheckOut.Value = DateTime.Now;
            comboHabitacion.SelectedIndex = -1;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            reservaCurrent = (RH_Reserva)ListReservas.Current;
            txtEstadoReserva.Text = reservaCurrent.EstadoReserva;
            dateTimeFechaReserva.Value = reservaCurrent.FechaReserva;
            dateTimeCheckIn.Value = reservaCurrent.FechaCheckIn;
            dateTimeCheckOut.Value = reservaCurrent.FechaCheckOut;
            comboHabitacion.SelectedValue = reservaCurrent.HabitacionID;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            reservaCurrent = (RH_Reserva)ListReservas.Current;
            if (reservaCurrent == null)
            {
                MessageBox.Show(" Debe seleccionar una reserva", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("¿Está seguro de eliminar la reserva?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                reservaCurrent = (RH_Reserva)ListReservas.Current;
                if (reservaCurrent != null)
                {
                    await reservaService.DeleteAsync(reservaCurrent.ID);
                    await LoadData();
                }
            }
            reservaCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarReservas();
        }

        private async void FiltrarReservas()
        {
            var reservasFiltradas = await reservaService.GetAllAsync(txtFiltro.Text);
            ListReservas.DataSource = reservasFiltradas;
        }
    }
}
    