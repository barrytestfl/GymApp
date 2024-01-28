using GymApp.ViewModels.Goals;

namespace GymApp.Views.Goals;

public partial class YourGoalsPage : ContentPage
{
	private readonly YourGoalsViewModel	viewModel;
	public YourGoalsPage(YourGoalsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}