using GymApp.ViewModels.Home;

namespace GymApp.Views.Home;

public partial class PersonalTrainersPage : ContentPage
{
private	 readonly PersonalTrainersViewModel viewModel;
	public PersonalTrainersPage(PersonalTrainersViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext= viewModel;
	}
}