﻿using ReservaHoteleriaApp.Class;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;
using System.Collections.ObjectModel;

namespace ReservaHoteleriaApp.ViewModels
{
    public class ReservasViewModel : ObjectNotification
    {
        private GenericService<RH_Reserva> reservaService = new GenericService<RH_Reserva>();

        private string filterreservas;
        public string FilterReservas
        {
            get { return filterreservas; }
            set
            {
                filterreservas = value;
                OnPropertyChanged();
                _ = FiltarReservas();
            }
        }

        //porque hacemos esto, porque lo dijo Gabriel
        //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
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

        private ObservableCollection<RH_Reserva> reservas;
        public ObservableCollection<RH_Reserva> Reservas
        {
            get { return reservas; }
            set
            {
                reservas = value;
                OnPropertyChanged();
            }
        }

        private List<RH_Reserva>? ReservaListToFilter;
        private RH_Reserva selectedReserva;
         public RH_Reserva SelectedReserva
        {
            get { return selectedReserva; }
            set 
            {
                selectedReserva = value;
                OnPropertyChanged();
                EditarReservasCommand.ChangeCanExecute();
                EliminarReservaCommand.ChangeCanExecute();
            }
        }

        public Command ObtenerReservasCommand { get; }
        public Command FiltrarReservasCommand { get; }
        public Command AgregarReservasCommand { get; }
        public Command EditarReservasCommand { get; }
        public Command EliminarReservaCommand { get; }


        public ReservasViewModel()
        {
            ObtenerReservasCommand = new Command(async () => await ObtenerReservas());
            FiltrarReservasCommand = new Command(async () =>  await FiltarReservas());
            AgregarReservasCommand = new Command(async () => await AgregarReservas());
            EditarReservasCommand = new Command(async (obj) => await EditarReservas(), PermitirEditar);
            EliminarReservaCommand = new Command(async (obj) => await EliminarReserva(), PermitirEliminar);
            ObtenerReservas();
        }

        private bool PermitirEliminar(object arg)
        {
            return selectedReserva != null;
        }

        private async Task EliminarReserva()
        {
            if (selectedReserva != null)
            {
                await reservaService.DeleteAsync(selectedReserva.ID);
                await ObtenerReservas();
            }
            else
            {
                Console.WriteLine("SelectedReserva is null");
            }
        }

        private bool PermitirEditar(object arg)
        {
            return selectedReserva != null;
        }

        private async Task EditarReservas()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "ReservaToEdit",  selectedReserva }
            };
            await Shell.Current.GoToAsync("//AgregarEditarReserva", navigationParameter);
        }

        private async Task AgregarReservas()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "ReservaToEdit",  null }
            };
            await Shell.Current.GoToAsync("//AgregarEditarReserva", navigationParameter);
        }

        private async Task FiltarReservas()
        {
            if (DateTime.TryParse(FilterReservas, out DateTime fechaFiltrada))
            {
                var reservasFiltradas = ReservaListToFilter.Where(p => p.FechaReserva.Date == fechaFiltrada.Date).ToList();
                Reservas = new ObservableCollection<RH_Reserva>(reservasFiltradas);
            }
            else
            {
                // Si el filtro no es una fecha válida, mostramos todas las reservas
                Reservas = new ObservableCollection<RH_Reserva>(ReservaListToFilter);
            }
        }

        public async Task ObtenerReservas()
        {
            Reservas = null;
            //FilterReservas = string.Empty;
            IsRefreshing = true;
            ReservaListToFilter = await reservaService.GetAllAsync();
            Reservas = new ObservableCollection<RH_Reserva>(ReservaListToFilter);
            IsRefreshing = false;
        }

    }
}
