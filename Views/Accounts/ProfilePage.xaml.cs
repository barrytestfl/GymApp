using GymApp.ViewModels.Accounts;

namespace GymApp.Views.Accounts;

public partial class ProfilePage : ContentPage
{
	private readonly ProfileViewModel viewModel;
	public ProfilePage(ProfileViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}