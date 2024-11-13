using ReservaHoteleriaApp.ViewModels;

namespace ReservaHoteleriaApp.Views;

public partial class ReservasView : ContentPage
{
	public ReservasView()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as ReservasViewModel;
        //if (viewmodel.NotaSeleccionada != null)
        //{
        viewmodel.ObtenerReservas();
        viewmodel.SelectedReserva = null;
        //}
    }

}