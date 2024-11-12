using ReservaHoteleriaApp.ViewModels;
using ReservasHoteleriaServices.Models;

namespace ReservaHoteleriaApp.Views;
[QueryProperty(nameof(ServicioAdicional), "ServicioAdicionalToEdit")]
public partial class AddEditServicioAdicionalView : ContentPage
{
    public RH_ServicioAdicional ServicioAdicional {
        set
        {
            var servicioAdicional = value;
            var viewModel = this.BindingContext as AddEditServicioAdicionalViewModel;
            viewModel.EditServicioAdicional = servicioAdicional;
        }
        
    }
	public AddEditServicioAdicionalView()
	{
		InitializeComponent();
	}
    public AddEditServicioAdicionalView(RH_ServicioAdicional servicioAdicional)
    {
        InitializeComponent();
        var viewModel = this.BindingContext as AddEditServicioAdicionalViewModel;
        viewModel.EditServicioAdicional = servicioAdicional;
    }
}