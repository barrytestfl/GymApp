using GymApp.ViewModels.Notifications;

namespace GymApp.Views.Notifications;

public partial class NotificationCenterPage : ContentPage
{
	private readonly NotificationCenterViewModel viewModel;
	public NotificationCenterPage(NotificationCenterViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
}