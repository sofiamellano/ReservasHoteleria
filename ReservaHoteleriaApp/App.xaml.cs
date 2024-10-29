using ReservaHoteleriaApp.View;

namespace ReservaHoteleriaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new InicioView();
        }
    }
}
