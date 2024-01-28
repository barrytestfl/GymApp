using GymApp.ViewModels.Accounts;

namespace GymApp.Views.Accounts;

public partial class SettingsPage : ContentPage
{
	private readonly SettingsViewModel viewModel;
	public SettingsPage(SettingsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext= viewModel;
	}
}