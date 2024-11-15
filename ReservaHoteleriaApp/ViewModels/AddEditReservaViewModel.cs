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
                    HabitacionID = selectedHabitacion.ID;
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
                // Si editReserva está configurada, se asignan los valores
                FechaReserva = editReserva.FechaReserva;
                FechaCheckIn = editReserva.FechaCheckIn;
                FechaCheckOut = editReserva.FechaCheckOut;
                EstadoReserva = editReserva.EstadoReserva;

                // Verificar que la habitación esté correctamente asignada
                SelectedHabitacion = Habitaciones?.FirstOrDefault(h => h.ID == editReserva.HabitacionID);
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
            FechaReserva = DateTime.Now;
            FechaCheckIn = DateTime.Now;
            FechaCheckOut = DateTime.Now;
            SaveReservaCommand = new Command(async () => await SaveReserva());
            LoadHabitaciones();
        }

        private async void LoadHabitaciones()
        {
            // Cargar las habitaciones para el combo
            var habitacionService = new GenericService<RH_Habitacion>();
            Habitaciones = new ObservableCollection<RH_Habitacion>(await habitacionService.GetAllAsync());

            // Si ya hay una reserva editando, seleccionar la habitación correcta
            if (editReserva != null && Habitaciones != null)
            {
                SelectedHabitacion = Habitaciones.FirstOrDefault(h => h.ID == editReserva.HabitacionID);
            }
        }

        private async Task SaveReserva()
        {
            try
            {
                // Validación de selección de habitación
                if (SelectedHabitacion == null)
                {
                    Console.WriteLine("Debe seleccionar una habitación antes de guardar.");
                    return;
                }

                // Si editReserva no es null, es una edición
                if (editReserva != null && editReserva.ID > 0)
                {
                    // Aquí se actualiza la reserva
                    editReserva.FechaReserva = this.FechaReserva;
                    editReserva.FechaCheckIn = this.FechaCheckIn;
                    editReserva.FechaCheckOut = this.FechaCheckOut;
                    editReserva.EstadoReserva = this.EstadoReserva;
                    editReserva.HabitacionID = this.HabitacionID;

                    // Actualizar la reserva en el servicio
                    await reservaService.UpdateAsync(editReserva);
                }
                else
                {
                    // Crear una nueva reserva
                    var reserva = new RH_Reserva()
                    {
                        FechaReserva = this.FechaReserva,
                        FechaCheckIn = this.FechaCheckIn,
                        FechaCheckOut = this.FechaCheckOut,
                        EstadoReserva = this.EstadoReserva,
                        HabitacionID = this.HabitacionID,
                    };
                    // Agregar la nueva reserva
                    await reservaService.AddAsync(reserva);
                }

                // Regresar a la lista de reservas
                await Shell.Current.GoToAsync("//ListaReservas");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la reserva: {ex.Message}");
            }
        }
    }
}
