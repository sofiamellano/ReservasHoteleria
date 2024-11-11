using KioscoInformaticoApp.ViewModels;
using ReservaHoteleriaApp.ViewModels;

namespace ReservaHoteleriaApp.Views;

public partial class ServiciosAdicionalesView : ContentPage
{
	public ServiciosAdicionalesView()
	{
        InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as ServiciosAdicionalesViewModel;
        //if (viewmodel.NotaSeleccionada != null)
        //{
        viewmodel.ObtenerServiciosAdicionales();
        //}
    }
}