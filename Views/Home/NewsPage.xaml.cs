using GymApp.ViewModels.Home;

namespace GymApp.Views.Home;

public partial class NewsPage : ContentPage
{
	private readonly NewsViewModel viewModel;
	public NewsPage(NewsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext= viewModel;
	}
}