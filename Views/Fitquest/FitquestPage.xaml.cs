using GymApp.ViewModels.Fitquest;

namespace GymApp.Views.Fitquest;

public partial class FitquestPage : ContentPage
{
	private readonly FitquestViewModel viewModel;
	public FitquestPage(FitquestViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}
}