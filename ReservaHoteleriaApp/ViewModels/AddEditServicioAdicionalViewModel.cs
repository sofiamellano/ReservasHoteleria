using ReservaHoteleriaApp.Class;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;

namespace ReservaHoteleriaApp.ViewModels
{
    public class AddEditServicioAdicionalViewModel : ObjectNotification
    {
        ServicioAdicionalService servicioAdicionalService = new ServicioAdicionalService();
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
                ReservaID = editServicioAdicional.ReservaID ?? 0;
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
        private int reservaID;
        public int ReservaID
        {
            get { return reservaID; }
            set
            {
                reservaID = value;
                OnPropertyChanged();
            }
        }

        public Command SaveServicioAdicionalCommand { get; }
        public AddEditServicioAdicionalViewModel()
        {
            FechaSolicitud = DateTime.Now;
            SaveServicioAdicionalCommand = new Command(async () => await SaveServicioAdicional());
        }

        private async Task SaveServicioAdicional()
        {
            try
            {
                if (editServicioAdicional != null)
                {
                    editServicioAdicional.TipoServicio = this.TipoServicio;
                    editServicioAdicional.ReservaID = this.ReservaID;

                    // Verificación de que Id tenga un valor válido
                    if (editServicioAdicional.ID == 0)
                    {
                        throw new InvalidOperationException("El valor de la propiedad 'Id' no puede ser 0");
                    }

                    await servicioAdicionalService.UpdateAsync(editServicioAdicional);
                }
                else
                {
                    var servicioAdicional = new RH_ServicioAdicional()
                    {
                        TipoServicio = this.TipoServicio,
                    };
                    await servicioAdicionalService.AddAsync(servicioAdicional);
                }
                await Shell.Current.GoToAsync("//ListaServiciosAdicionales");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el servicio adicional: {ex.Message}");
                throw new InvalidOperationException("Error al guardar el servicio adicional", ex);
            }
        }
    }
}
