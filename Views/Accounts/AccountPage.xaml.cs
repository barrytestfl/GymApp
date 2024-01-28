using GymApp.ViewModels.Accounts;

namespace GymApp.Views.Accounts;

public partial class AccountPage : ContentPage
{
	private readonly AccountViewModel viewModel;
	public AccountPage(AccountViewModel viewModel)
	{
		InitializeComponent();
		this .viewModel = viewModel;
		BindingContext= viewModel;
	}
}