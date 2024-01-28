using GymApp.ViewModels.Home;

namespace GymApp.Views.Home;

public partial class AddFriendPage : ContentPage
{
	private readonly AddFriendViewModel viewModel;
	public AddFriendPage(AddFriendViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}
}