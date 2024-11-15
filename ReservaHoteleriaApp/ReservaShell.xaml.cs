using CommunityToolkit.Mvvm.Messaging;
using ReservaHoteleriaApp.Class;
using ReservaHoteleriaApp.ViewModels;
using ReservaHoteleriaApp.Views;
namespace ReservaHoteleriaApp
{
    public partial class ReservaShell : Shell
    {
        public ReservaShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            RegisterRoute();
        }

        private void RegisterRoute()
        {
            Routing.RegisterRoute("Registrarse", typeof(RegistrarseView));
        }

        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as ReservaShellViewModel;
            viewmodel.IsUserLogout = false;
        }

        public void DisableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
    }
}
