using GymApp.ViewModels.Activity;

namespace GymApp.Views.Activity;

public partial class YearlyPage : ContentPage
{
	private readonly YearlyViewModel viewModel;
	public YearlyPage(YearlyViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}