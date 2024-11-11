using ReservaHoteleriaApp.Class;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;

namespace ReservaHoteleriaApp.ViewModels
{
    public class AddEditServicioAdicionalViewModel : ObjectNotification
    {
        GenericService<RH_ServicioAdicional> servicioAdicionalService = new GenericService<RH_ServicioAdicional>();
        private RH_ServicioAdicional editServicioAdicional;
        public RH_ServicioAdicional EditServicioAdicional
        {
            get { return editServicioAdicional; }
            set
            {
                editServicioAdicional = value;
                OnPropertyChanged();
                SettingData();
            }
        }

        private void SettingData()
        {
            if (editServicioAdicional != null)
            {
                TipoServicio = editServicioAdicional.TipoServicio;
                FechaSolicitud = editServicioAdicional.FechaSolicitud;
            }
        }

        private string tipoServicio;
        public string TipoServicio
        {
            get { return tipoServicio; }
            set
            {
                tipoServicio = value;
                OnPropertyChanged();
            }
        }

        private DateTime fechaSolicitud;
        public DateTime FechaSolicitud
        {
            get { return fechaSolicitud; }
            set
            {
                fechaSolicitud = value;
                OnPropertyChanged();
            }
        }

        public Command SaveServicioAdicionalCommand { get; }
        public AddEditServicioAdicionalViewModel()
        {
            SaveServicioAdicionalCommand = new Command(async () => await SaveServicioAdicional());
        }

        private async Task SaveServicioAdicional()
        {
            if (editServicioAdicional != null)
            {
                editServicioAdicional.TipoServicio = this.TipoServicio;
                editServicioAdicional.FechaSolicitud = this.FechaSolicitud;
                await servicioAdicionalService.UpdateAsync(editServicioAdicional);
            }
            else
            {
                var servicioAdicional = new RH_ServicioAdicional()
                {
                    TipoServicio = this.TipoServicio,
                    FechaSolicitud = this.FechaSolicitud
                };
                await servicioAdicionalService.AddAsync(servicioAdicional);
            }
            await Shell.Current.GoToAsync("//ListaServiciosAdicionales");
        }
    }
}
