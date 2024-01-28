using GymApp.ViewModels.Challenges;

namespace GymApp.Views.Challenges;

public partial class CurrentPage : ContentPage
{
	private readonly CurrentViewModel viewModel;
    public CurrentPage(CurrentViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}
}