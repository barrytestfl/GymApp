using GymApp.ViewModels.Accounts;

namespace GymApp.Views.Accounts;

public partial class MyGymPage : ContentPage
{
	private readonly MyGymViewModel viewModel;
	public MyGymPage(MyGymViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}
}