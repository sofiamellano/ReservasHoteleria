using ReservaHoteleriaApp.Class;
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
                FiltarServiciosAdicionales();
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

        public Command ObtenerServiciosAdicionalesCommand { get; set; }
        public Command FiltarServiciosAdicionalesCommand { get; set; }
        public Command AgregarServiciosAdicionalesCommand { get; set; }
        public Command EditarServiciosAdicionalesCommand { get; set; }

        public ServiciosAdicionalesViewModel()
        {
            ObtenerServiciosAdicionalesCommand = new Command(async () => await ObtenerServiciosAdicionales());
            FiltarServiciosAdicionalesCommand = new Command(async () => await FiltarServiciosAdicionales());
            AgregarServiciosAdicionalesCommand = new Command(async () => await AgregarServiciosAdicionales());
            EditarServiciosAdicionalesCommand = new Command(async () => await EditarServiciosAdicionales(), PermitirEditar);
            ObtenerServiciosAdicionales();
        }

        private bool PermitirEditar()
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
                { "ServicioAdicionalToEdit",  selectedServicioAdicional }
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



