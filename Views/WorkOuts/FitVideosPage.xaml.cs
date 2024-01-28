using GymApp.ViewModels.WorkOuts;

namespace GymApp.Views.WorkOuts;

public partial class FitVideosPage : ContentPage
{
	private readonly FitVideosViewModel viewModel;
	public FitVideosPage(FitVideosViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}