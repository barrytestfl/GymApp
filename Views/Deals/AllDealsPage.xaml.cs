using GymApp.ViewModels.Deals;

namespace GymApp.Views.Deals;

public partial class AllDealsPage : ContentPage
{
	private readonly AllDealsViewModel viewModel;
	public AllDealsPage(AllDealsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}
}