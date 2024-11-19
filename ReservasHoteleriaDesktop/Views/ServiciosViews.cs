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
    public partial class ServiciosViews : Form
    {
        IServicioService servicioService = new ServicioService();
        BindingSource ListServicios = new BindingSource();
        RH_Servicio servicioCurrent;
        public ServiciosViews()
        {
            InitializeComponent();
            dataGridServicios.DataSource = ListServicios;
            LoadData();
        }
        private async Task LoadData()
        {
            var servicios = await servicioService.GetAllAsync();
            ListServicios.DataSource = servicios;
            if (dataGridServicios != null && dataGridServicios.Columns != null)
            {
                dataGridServicios.Columns["ID"].Visible = false;
                dataGridServicios.Columns["Eliminado"].Visible = false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AgregarEditar);
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (servicioCurrent != null)
            {
                servicioCurrent.Nombre = txtNombre.Text;
                servicioCurrent.Precio = Convert.ToDecimal(numericPrecio.Value);
                await servicioService.UpdateAsync(servicioCurrent);
                servicioCurrent = null;
            }
            else
            {
                var servicio = new RH_Servicio
                {
                    Nombre = txtNombre.Text,
                    Precio = Convert.ToDecimal(numericPrecio.Value),
                };
                await servicioService.AddAsync(servicio);
            }
            await LoadData();
            txtNombre.Text = string.Empty;
            numericPrecio.Value = 0;
            tabControl1.SelectTab(Lista);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            servicioCurrent = null;
            txtNombre.Text = string.Empty;
            numericPrecio.Value = 0;
            tabControl1.SelectTab(Lista);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            servicioCurrent = (RH_Servicio)ListServicios.Current;
            txtNombre.Text = servicioCurrent.Nombre;
            numericPrecio.Value = servicioCurrent.Precio;
            tabControl1.SelectTab(AgregarEditar);

        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            servicioCurrent = (RH_Servicio)ListServicios.Current;
            if (servicioCurrent == null)
            {
                MessageBox.Show(" Debe seleccionar un servicio", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("¿Está seguro de eliminar este servicio?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                servicioCurrent = (RH_Servicio)ListServicios.Current;
                if (servicioCurrent != null)
                {
                    await servicioService.DeleteAsync(servicioCurrent.ID);
                    await LoadData();
                }
            }
            servicioCurrent = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarServicios();
        }

        private async void FiltrarServicios()
        {
            var serviciosFiltrados = await servicioService.GetAllAsync(txtFiltro.Text);
            ListServicios.DataSource = serviciosFiltrados;
        }
    }
}
