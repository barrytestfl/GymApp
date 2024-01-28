using GymApp.ViewModels.Classes;

namespace GymApp.Views.Classes;

public partial class GymClassesPage : ContentPage
{
	private readonly GymClassesViewModel viewModel;
	public GymClassesPage(GymClassesViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}