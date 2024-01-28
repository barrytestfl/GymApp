using GymApp.ViewModels.Accounts;

namespace GymApp.Views.Accounts;

public partial class FAQsPage : ContentPage
{
	private readonly FAQsViewModel viewModel;
	public FAQsPage(FAQsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}
}