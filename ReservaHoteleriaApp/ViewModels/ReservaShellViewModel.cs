using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ReservaHoteleriaApp.ViewModels
{
    public partial class ReservaShellViewModel : ObservableObject
    {
        public IRelayCommand LogoutCommand { get; }

        [ObservableProperty]
        private bool isUserLogout = true;

        public ReservaShellViewModel()
        {
            LogoutCommand = new RelayCommand(Logout);
        }

        private void Logout()
        {
            IsUserLogout = true;
            (App.Current.MainPage as ReservaShell).DisableAppAfterLogin();
        }
    }
}
