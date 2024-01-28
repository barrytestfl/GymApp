using GymApp.ViewModels.WorkOuts;

namespace GymApp.Views.WorkOuts;

public partial class RecordWorkOutsPage : ContentPage
{
	private readonly RecordWorkOutsViewModel viewModel;
	public RecordWorkOutsPage(RecordWorkOutsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}