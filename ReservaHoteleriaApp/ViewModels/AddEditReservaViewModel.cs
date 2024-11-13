using ReservaHoteleriaApp.Class;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;

namespace ReservaHoteleriaApp.ViewModels
{
    public class AddEditReservaViewModel : ObjectNotification
    {
        ReservaService reservaService = new ReservaService();

        private RH_Reserva editReserva;
        public RH_Reserva EditReserva
        {
            get { return editReserva; }
            set
            {
                editReserva = value;
                OnPropertyChanged();
                SettingData();
            }
        }

        private void SettingData()
        {
        }

        private DateTime fechaReserva;
        public DateTime FechaReserva
        {
            get { return fechaReserva; }
            set
            {
                fechaReserva = value;
                OnPropertyChanged();
            }
        }

        private DateTime fechaCheckIn;
        public DateTime FechaCheckIn
        {
            get { return fechaCheckIn; }
            set
            {
                fechaCheckIn = value;
                OnPropertyChanged();
            }
        }

        private DateTime fechaCheckOut;
        public DateTime FechaCheckOut
        {
            get { return fechaCheckOut; }
            set
            {
                fechaCheckOut = value;
                OnPropertyChanged();
            }
        }

        private string estadoReserva;
        public string EstadoReserva
        {
            get { return estadoReserva; }
            set
            {
                estadoReserva = value;
                OnPropertyChanged();
            }
        }

        public Command SaveReservaCommand { get; }
        public AddEditReservaViewModel()
        {
            SaveReservaCommand = new Command(async () => await SaveReserva());
        }

        private async Task SaveReserva()
        {
            try
            {
                if (editReserva != null)
                {
                    editReserva.FechaReserva = FechaReserva;
                    editReserva.FechaCheckIn = FechaCheckIn;
                    editReserva.FechaCheckOut = FechaCheckOut;
                    editReserva.EstadoReserva = EstadoReserva;
                    await reservaService.UpdateAsync(editReserva);
                }
                else
                {
                    var reserva = new RH_Reserva()
                    {
                        FechaReserva = FechaReserva,
                        FechaCheckIn = FechaCheckIn,
                        FechaCheckOut = FechaCheckOut,
                        EstadoReserva = EstadoReserva,
                        UsuarioID = 1,
                        HabitacionID = 1,
                    };
                    await reservaService.AddAsync(reserva);
                }
                await Shell.Current.GoToAsync("//ListaReservas");
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el mensaje de error para diagnosticar el problema
                Console.WriteLine(ex.Message);
                // O mostrarlo en una alerta en la UI para verificar en tiempo de ejecución
            }
        }

    }
}
