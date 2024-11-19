using ReservasHoteleriaServices.Interfaces;
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
    public partial class HabitacionesViews : Form
    {
        IHabitacionService habitacionService = new HabitacionService();
        BindingSource ListHabitaciones = new BindingSource();
        RH_Habitacion habitacionCurrent;
        public HabitacionesViews()
        {
            InitializeComponent();
            dataGridHabitaciones.DataSource = ListHabitaciones;
            LoadData();
        }

        private async Task LoadData()
        {
            var habitaciones = await habitacionService.GetAllAsync();
            ListHabitaciones.DataSource = habitaciones;
            if (dataGridHabitaciones != null && dataGridHabitaciones.Columns != null)
            {
                dataGridHabitaciones.Columns["ID"].Visible = false;
                dataGridHabitaciones.Columns["Eliminado"].Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (habitacionCurrent != null)
            {
                habitacionCurrent.TipoHabitacion = txtTipoHabitacion.Text;
                habitacionCurrent.PrecioPorNoche = Convert.ToDecimal(numericPrecioPorNoche.Value);
                habitacionCurrent.Disponible = checkDisponible.Checked;
                await habitacionService.UpdateAsync(habitacionCurrent);
                habitacionCurrent = null;
            }
            else
            {
                var habitacion = new RH_Habitacion
                {
                    TipoHabitacion = txtTipoHabitacion.Text,
                    PrecioPorNoche = Convert.ToDecimal(numericPrecioPorNoche.Value),
                    Disponible = checkDisponible.Checked
                };
                await habitacionService.AddAsync(habitacion);
            }
            await LoadData();
            txtTipoHabitacion.Text = string.Empty;
            numericPrecioPorNoche.Value = 0;
            tabControl1.SelectTab(Lista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habitacionCurrent = null;
            txtTipoHabitacion.Text = string.Empty;
            numericPrecioPorNoche.Value = 0;
            tabControl1.SelectTab(Lista);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habitacionCurrent = (RH_Habitacion)ListHabitaciones.Current;
            txtTipoHabitacion.Text = habitacionCurrent.TipoHabitacion;
            numericPrecioPorNoche.Value = habitacionCurrent.PrecioPorNoche;
            checkDisponible.Checked = habitacionCurrent.Disponible;
            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            habitacionCurrent = (RH_Habitacion)ListHabitaciones.Current;
            if (habitacionCurrent == null)
            {
                MessageBox.Show(" Debe seleccionar una habitacion", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("¿Está seguro de eliminar esta habitacion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                habitacionCurrent = (RH_Habitacion)ListHabitaciones.Current;
                if (habitacionCurrent != null)
                {
                    await habitacionService.DeleteAsync(habitacionCurrent.ID);
                    await LoadData();
                }
            }
            habitacionCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarHabitaciones();
        }

        private async void FiltrarHabitaciones()
        {
            var habitacionesFiltradas = await habitacionService.GetAllAsync(txtFiltro.Text);
            ListHabitaciones.DataSource = habitacionesFiltradas;
        }
    }
}
