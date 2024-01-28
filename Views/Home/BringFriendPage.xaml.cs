using GymApp.ViewModels.Home;
using Sharpnado.Tabs;

namespace GymApp.Views.Home;

public partial class BringFriendPage : ContentPage
{
	private readonly BringFriendViewModel viewModel;
	
	public BringFriendPage(BringFriendViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
        TabHostBadge.SelectedIndex = 0;
        

    }
    private async Task TakeScreenshot()
    {
        var screenshot = await Screenshot.CaptureAsync();
        var stream = await screenshot.OpenReadAsync();

        var image = new Image
        {
            Margin = new Thickness(0, 20, 0, 0),
            HorizontalOptions = LayoutOptions.Fill,
            VerticalOptions = LayoutOptions.Fill,
            Aspect = Aspect.AspectFit,
            Rotation = -90,
            Source = ImageSource.FromStream(() => stream),
        };

       // ScreenshotContainer.Content = image;
    }
}