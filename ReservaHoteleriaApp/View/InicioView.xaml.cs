using ReservaHoteleriaApp.ViewModel;

namespace ReservaHoteleriaApp.View;

public partial class InicioView : ContentPage
{
	public InicioView()
	{
		InitializeComponent();
        BindingContext = new InicioViewModel();
    }
}