using ReservaHoteleriaApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReservaHoteleriaApp.ViewModel
{
    internal class InicioViewModel : ObjectNotification
    {
        public ICommand ReservasCommand { get; set; }
        public ICommand ServiciosCommand { get; set; }
        public ICommand PerfilCommand { get; set; }

        public InicioViewModel()
        {
            ReservasCommand = new Command(Reservas);
            ServiciosCommand = new Command(Servicios);
            PerfilCommand = new Command(Perfil);
        }

        private void Servicios(object obj)
        {
            throw new NotImplementedException();
        }

        private void Reservas(object obj)
        {
            throw new NotImplementedException();
        }

        private async void Perfil(object obj)
        {
            await Shell.Current.GoToAsync(nameof(Perfil));    
        }

        private async void ServiciosPage(object obj)
        {
           await Shell.Current.GoToAsync(nameof(Servicios));
        }

        private async void ReservasPage(object obj)
        {
            await Shell.Current.GoToAsync(nameof(Reservas));
        }
    }
}
