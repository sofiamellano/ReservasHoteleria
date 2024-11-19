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
    public partial class ServiciosAdiconalesViews : Form
    {
        IServicioAdicionalService servicioAdicionalService = new ServicioAdicionalService();
        BindingSource ListServiciosAdicionales = new BindingSource();
        RH_ServicioAdicional servicioAdicionalCurrent;
        public ServiciosAdiconalesViews()
        {
            InitializeComponent();
            dataGridServiciosAdicionales.DataSource = ListServiciosAdicionales;
            LoadData();
        }

        private async Task LoadData()
        {
            var serviciosAdicionales = await servicioAdicionalService.GetAllAsync();
            ListServiciosAdicionales.DataSource = serviciosAdicionales;
            if (dataGridServiciosAdicionales != null && dataGridServiciosAdicionales.Columns != null)
            {
                dataGridServiciosAdicionales.Columns["ID"].Visible = false;
                dataGridServiciosAdicionales.Columns["Eliminado"].Visible = false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (servicioAdicionalCurrent != null)
            {
                servicioAdicionalCurrent.TipoServicio = txtTipoServicio.Text;
                await servicioAdicionalService.UpdateAsync(servicioAdicionalCurrent);
                servicioAdicionalCurrent = null;
            }
            else
            {
                var servicioAdicional = new RH_ServicioAdicional
                {
                    TipoServicio = txtTipoServicio.Text
                };
                await servicioAdicionalService.AddAsync(servicioAdicional);
            }
            await LoadData();
            txtTipoServicio.Text = string.Empty;
            tabControl1.SelectTab(Lista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            servicioAdicionalCurrent = null;
            txtTipoServicio.Text = string.Empty;
            tabControl1.SelectTab(Lista);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            servicioAdicionalCurrent = (RH_ServicioAdicional)ListServiciosAdicionales.Current;
            txtTipoServicio.Text = servicioAdicionalCurrent.TipoServicio;
            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            servicioAdicionalCurrent = (RH_ServicioAdicional)ListServiciosAdicionales.Current;
            if (servicioAdicionalCurrent == null)
            {
                MessageBox.Show(" Debe seleccionar un servicio adicional", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("¿Está seguro de eliminar este servicio adicional?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                servicioAdicionalCurrent = (RH_ServicioAdicional)ListServiciosAdicionales.Current;
                if (servicioAdicionalCurrent != null)
                {
                    await servicioAdicionalService.DeleteAsync(servicioAdicionalCurrent.ID);
                    await LoadData();
                }
            }
            servicioAdicionalCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarServiciosAdicionales();
        }

        private async void FiltrarServiciosAdicionales()
        {
            var serviciosAdicionalesFiltrados = await servicioAdicionalService.GetAllAsync(txtFiltro.Text);
            ListServiciosAdicionales.DataSource = serviciosAdicionalesFiltrados;
        }
    }
}
