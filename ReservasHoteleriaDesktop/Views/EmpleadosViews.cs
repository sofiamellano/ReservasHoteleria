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
    public partial class EmpleadosViews : Form
    {
        IEmpleadosService empleadosService = new EmpleadosService();
        BindingSource ListEmpleados = new BindingSource();
        RH_Empleado empleadoCurrent;
        public EmpleadosViews()
        {
            InitializeComponent();
            dataGridEmpleados.DataSource = ListEmpleados;
            LoadData();
        }

        private async Task LoadData()
        {
            var empleados = await empleadosService.GetAllAsync();
            ListEmpleados.DataSource = empleados;

            if (dataGridEmpleados != null && dataGridEmpleados.Columns != null)
            {
                dataGridEmpleados.Columns["ID"].Visible = false;
                dataGridEmpleados.Columns["Eliminado"].Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (empleadoCurrent != null)
            {
                empleadoCurrent.Nombre = txtNombre.Text;
                empleadoCurrent.Cargo = txtCargo.Text;
                await empleadosService.UpdateAsync(empleadoCurrent);
                empleadoCurrent = null;
            }
            else
            {
                var empleado = new RH_Empleado
                {
                    Nombre = txtNombre.Text,
                    Cargo = txtCargo.Text
                };
                await empleadosService.AddAsync(empleado);
            }
            await LoadData();
            txtNombre.Text = string.Empty;
            txtCargo.Text = string.Empty;
            tabControl1.SelectTab(Lista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            empleadoCurrent = null;
            txtNombre.Text = string.Empty;
            txtCargo.Text = string.Empty;
            tabControl1.SelectTab(Lista);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            empleadoCurrent = (RH_Empleado)ListEmpleados.Current;
            txtNombre.Text = empleadoCurrent.Nombre;
            txtCargo.Text = empleadoCurrent.Cargo;
            tabControl1.SelectTab(AgregarEditar);
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            empleadoCurrent = (RH_Empleado)ListEmpleados.Current;
            if (empleadoCurrent == null)
            {
                MessageBox.Show(" Debe seleccionar un empleado", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                empleadoCurrent = (RH_Empleado)ListEmpleados.Current;
                if (empleadoCurrent != null)
                {
                    await empleadosService.DeleteAsync(empleadoCurrent.ID);
                    await LoadData();
                }
            }
            empleadoCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private async void FiltrarEmpleados()
        {
            var empleadosFiltrados = await empleadosService.GetAllAsync(txtFiltro.Text);
            ListEmpleados.DataSource = empleadosFiltrados;
        }

       
    }
}
