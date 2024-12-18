﻿using ReservaHoteleriaApp.Class;
using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;
using System.Collections.ObjectModel;

namespace ReservaHoteleriaApp.ViewModels
{
    public class ServiciosAdicionalesViewModel : ObjectNotification
    {
        private GenericService<RH_ServicioAdicional> servicioAdicionalService = new GenericService<RH_ServicioAdicional>();

        private string filterServicioAdicional;
        public string FilterServicioAdicional
        {
            get { return filterServicioAdicional; }
            set
            {
                filterServicioAdicional = value;
                OnPropertyChanged();
                if ( filterServicioAdicional != string.Empty)
                {
                    FiltarServiciosAdicionales();
                }

            }
        }

        private ObservableCollection<RH_ServicioAdicional> serviciosAdicionales;
        public ObservableCollection<RH_ServicioAdicional> ServiciosAdicionales
        {
            get { return serviciosAdicionales; }
            set
            {
                serviciosAdicionales = value;
                OnPropertyChanged();
            }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private List<RH_ServicioAdicional>? ServicioAdicionalListToFilter;
        public RH_ServicioAdicional selectedServicioAdicional;
        public RH_ServicioAdicional SelectedServicioAdicional
        {
            get { return selectedServicioAdicional; }
            set
            {
                selectedServicioAdicional = value;
                OnPropertyChanged();
                EditarServiciosAdicionalesCommand.ChangeCanExecute();
                EliminarServicioAdicionalCommand.ChangeCanExecute();
            }
        }

        private bool activityStart;
        public bool ActivityStart
        {
            get { return activityStart; }
            set
            {
                activityStart = value;
                OnPropertyChanged();
            }
        }

        public Command ObtenerServiciosAdicionalesCommand { get; }
        public Command FiltarServiciosAdicionalesCommand { get; }
        public Command AgregarServiciosAdicionalesCommand { get; }
        public Command EditarServiciosAdicionalesCommand { get; }
        public Command EliminarServicioAdicionalCommand { get; }

        public ServiciosAdicionalesViewModel()
        {
            ObtenerServiciosAdicionalesCommand = new Command(async () => await ObtenerServiciosAdicionales());
            FiltarServiciosAdicionalesCommand = new Command(async () => await FiltarServiciosAdicionales());
            AgregarServiciosAdicionalesCommand = new Command(async () => await AgregarServiciosAdicionales());
            EditarServiciosAdicionalesCommand = new Command(async (obj) => await EditarServiciosAdicionales(), PermitirEditar);
            EliminarServicioAdicionalCommand = new Command(async (obj) => await EliminarServicioAdicional(), PermitirEliminar);
            ObtenerServiciosAdicionales();
        }

        private bool PermitirEliminar(object arg)
        {
            return selectedServicioAdicional != null;
        }

        private async Task EliminarServicioAdicional()
        {
            if (selectedServicioAdicional != null)
            {
                await servicioAdicionalService.DeleteAsync(selectedServicioAdicional.ID);
                await ObtenerServiciosAdicionales();
            }
            else
            {
                Console.WriteLine("SelectedServicioAdicional is null");
            }
        }

        private bool PermitirEditar(object arg)
        {
            return selectedServicioAdicional != null;
        }

        private async Task EditarServiciosAdicionales()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "ServicioAdicionalToEdit",  selectedServicioAdicional }
            };
            await Shell.Current.GoToAsync("//AgregarEditarServicioAdicional", navigationParameter);
        }

        private async Task AgregarServiciosAdicionales()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "ServicioAdicionalToEdit",  null }
            };
            await Shell.Current.GoToAsync("//AgregarEditarServicioAdicional", navigationParameter);
        }

        private async Task FiltarServiciosAdicionales()
        {
            if (ServicioAdicionalListToFilter != null)
            {
                var serviciosAdicionalesFiltrados = ServicioAdicionalListToFilter
                    .Where(s => s.TipoServicio != null && s.TipoServicio.ToLower().Contains(FilterServicioAdicional.ToLower()))
                    .ToList();

                ServiciosAdicionales = new ObservableCollection<RH_ServicioAdicional>(serviciosAdicionalesFiltrados);
            }
        }

        public async Task ObtenerServiciosAdicionales()
        {
            FilterServicioAdicional = string.Empty;
            ActivityStart = true;
            ServicioAdicionalListToFilter = await servicioAdicionalService.GetAllAsync();

            ServiciosAdicionales = new ObservableCollection<RH_ServicioAdicional>(ServicioAdicionalListToFilter);
            ActivityStart = false;
        }
    }

}



