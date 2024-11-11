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

        public ServiciosAdicionalesViewModel()
        {
            ObtenerServiciosAdicionalesCommand = new Command(async () => await ObtenerServiciosAdicionales());
            FiltarServiciosAdicionalesCommand = new Command(async () => await FiltarServiciosAdicionales());
            ObtenerServiciosAdicionales();
        }

        private async Task FiltarServiciosAdicionales()
        {
            if (ServicioAdicionalListToFilter != null)
            {
                var serviciosAdicionalesFiltrados = ServicioAdicionalListToFilter.Where(s => s.TipoServicio && s.FechaSolicitud.ToUpper().Contains(FilterServicioAdicional.ToLower())).ToList();
            }

            if (ServicioAdicionalListToFilter != null)
            {
                // Filtrar los servicios adicionales por el tipo de servicio
                var serviciosAdicionalesFiltrados = ServicioAdicionalListToFilter
                    .Where(s => s.TipoServicio != null && s.TipoServicio.ToLower().Contains(FilterServicioAdicional.ToLower()))
                    .ToList();
            }
        }

        public async Task ObtenerServiciosAdicionales()
        {
            FilterServicioAdicional = string.Empty;
            ActivityStart = true;
            ServicioAdicionalListToFilter = await servicioAdicionalService.GetAllAsync();

            // Filtrar los tipos de servicios al obtener la lista
            var serviciosAdicionalesFiltrados = ServicioAdicionalListToFilter
                .Where(s => s.TipoServicio != null && s.TipoServicio.ToLower().Contains(FilterServicioAdicional.ToLower()))
                .Where(s => !s.Eliminado)
                .ToList();

            ServiciosAdicionales = new ObservableCollection<RH_ServicioAdicional>(serviciosAdicionalesFiltrados);
            ActivityStart = false;
        }
    }

}



