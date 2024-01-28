using GymApp.ViewModels.Home;

namespace GymApp.Views.Home;

public partial class PersonalTrainerInfoPage : ContentPage
{
	private readonly PersonalTrainerInfoViewModel viewModel;
	public PersonalTrainerInfoPage(PersonalTrainerInfoViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}