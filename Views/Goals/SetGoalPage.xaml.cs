using GymApp.ViewModels.Goals;

namespace GymApp.Views.Goals;

public partial class SetGoalPage : ContentPage
{
	private readonly SetGoalViewModel viewModel;
	public SetGoalPage(SetGoalViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext= viewModel;
	}
}