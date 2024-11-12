using ReservaHoteleriaApp;
using ReservaHoteleriaApp.Class;

namespace ReservaHoteleriaApp.ViewModels
{
    public class IniciarSesionViewModel : ObjectNotification
    {
		private string email;
		public string Email
		{
			get { return email; }
			set { email = value; OnPropertyChanged(); IniciarSesionCommand.ChangeCanExecute();
			}
		}

		private string password;
		public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); IniciarSesionCommand.ChangeCanExecute();
            }
        } 

		private bool recordarContraseña;
		public bool RecordarContraseña
        {
            get { return recordarContraseña; }
            set { recordarContraseña = value; OnPropertyChanged();
            }
        }

        public Command IniciarSesionCommand { get; set; }
        public Command RegistrarseCommand { get; set; }

        public IniciarSesionViewModel()
        {
            IniciarSesionCommand = new Command(IniciarSesion, PermitirIniciarSesion);
        }

        private bool PermitirIniciarSesion(object arg)
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }

        private void IniciarSesion(object obj)
        {
            //WeakReferenceMessenger.Default.Send(new Message("AbrirkioscoShell"));
            var shellReserva = (ReservaShell)App.Current.MainPage;
            shellReserva.EnableAppAfterLogin();
        }
    }
}
