using ReservaHoteleriaApp.Class;
using ReservasHoteleriaServices.Models;
using ReservasHoteleriaServices.Services;
using System.Collections.ObjectModel;

namespace ReservaHoteleriaApp.ViewModels
{
    public class AddEditReservaViewModel : ObjectNotification
    {
        ReservaService reservaService = new ReservaService();

        private ObservableCollection<RH_Habitacion> habitaciones;
        public ObservableCollection<RH_Habitacion> Habitaciones
        {
            get { return habitaciones; }
            set
            {
                habitaciones = value;
                OnPropertyChanged();
            }
        }

        private RH_Habitacion selectedHabitacion;
        public RH_Habitacion SelectedHabitacion
        {
            get { return selectedHabitacion; }
            set
            {
                selectedHabitacion = value;
                OnPropertyChanged();
                if (selectedHabitacion != null)
                {
                    HabitacionID = selectedHabitacion.ID; // Actualiza el ID en caso de ser necesario
                }
            }
        }

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
            if (editReserva != null)
            {
                FechaReserva = editReserva.FechaReserva;
                FechaCheckIn = editReserva.FechaCheckIn;
                FechaCheckOut = editReserva.FechaCheckOut;
                EstadoReserva = editReserva.EstadoReserva;
                HabitacionID = editReserva.HabitacionID ?? 0;
            }
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

        private int habitacionID;
        public int HabitacionID
        {
            get { return habitacionID; }
            set
            {
                habitacionID = value;
                OnPropertyChanged();
            }
        }

        private int usuarioID;
        public int UsuarioID
        {
            get { return usuarioID; }
            set
            {
                usuarioID = value;
                OnPropertyChanged();
            }
        }

        public Command SaveReservaCommand { get; }

        public AddEditReservaViewModel()
        {
            
                FechaReserva = DateTime.Now; // Set the current date when adding a new reservation
                FechaCheckIn = DateTime.Now;
                FechaCheckOut = DateTime.Now;
            LoadHabitaciones();
            SaveReservaCommand = new Command(async () => await SaveReserva());
        }

        private async void LoadHabitaciones()
        {
            var habitacionService = new GenericService<RH_Habitacion>();
            Habitaciones = new ObservableCollection<RH_Habitacion>(await habitacionService.GetAllAsync());
            if (editReserva != null)
            {
                SelectedHabitacion = Habitaciones.FirstOrDefault(h => h.ID == editReserva.HabitacionID);
            }
        }
        private async Task SaveReserva()
        {
            try
            {
                if (editReserva != null)
                {
                    editReserva.FechaReserva = this.FechaReserva;
                    editReserva.FechaCheckIn = this.FechaCheckIn;
                    editReserva.FechaCheckOut = this.FechaCheckOut;
                    editReserva.EstadoReserva = this.EstadoReserva;
                    editReserva.HabitacionID = this.HabitacionID;
                    editReserva.Habitacion.TipoHabitacion = SelectedHabitacion.TipoHabitacion;
                    await reservaService.UpdateAsync(editReserva);
                }
                else
                {
                    var reserva = new RH_Reserva()
                    {
                        FechaReserva = this.FechaReserva,
                        FechaCheckIn = this.FechaCheckIn,
                        FechaCheckOut = this.FechaCheckOut,
                        EstadoReserva = this.EstadoReserva,
                        HabitacionID = this.HabitacionID,
                        Habitacion = SelectedHabitacion
                    };
                    await reservaService.AddAsync(reserva);
                }
                await Shell.Current.GoToAsync("//ListaReservas");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
