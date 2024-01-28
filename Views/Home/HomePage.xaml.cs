using GymApp.ViewModels.Home;

namespace GymApp.Views.Home;

public partial class HomePage : ContentPage
{
	private readonly HomeViewModel viewModel;
	public HomePage(HomeViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
}