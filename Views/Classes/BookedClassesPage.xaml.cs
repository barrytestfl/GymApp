using GymApp.ViewModels.Classes;

namespace GymApp.Views.Classes;

public partial class BookedClassesPage : ContentPage
{
	private readonly BookedClassesViewModel viewModel;
	public BookedClassesPage(BookedClassesViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext= viewModel;
	}
}