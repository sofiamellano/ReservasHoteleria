using ReservaHoteleriaApp.ViewModels;
using ReservasHoteleriaServices.Models;

namespace ReservaHoteleriaApp.Views;
[QueryProperty(nameof(Reserva), "ReservaToEdit")]
public partial class AddEditReservaView : ContentPage
{
    public RH_Reserva Reserva {
        set
        {
            var reserva = value;
            var viewModel = this.BindingContext as AddEditReservaViewModel;
            if (viewModel != null)
            {
                viewModel.EditReserva = reserva;  
            }
        }

    }
	public AddEditReservaView()
	{
		InitializeComponent();
	}
    public AddEditReservaView(RH_Reserva reserva)
    {
        InitializeComponent();
        var viewModel = this.BindingContext as AddEditReservaViewModel;
        if (viewModel != null)
        {
            viewModel.EditReserva = reserva;
        }
    }
}