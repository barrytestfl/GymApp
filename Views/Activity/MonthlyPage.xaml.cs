using DevExpress.Maui.Editors;
using GymApp.ViewModels.Activity;

namespace GymApp.Views.Activity;

public partial class MonthlyPage : ContentPage
{
    private readonly MonthlyViewModel viewModel;
	public MonthlyPage(MonthlyViewModel viewModel)
	{
		InitializeComponent();
        this.viewModel = viewModel;
        BindingContext=viewModel;
	}
    void CustomDayCellAppearance(object sender, CustomSelectableCellAppearanceEventArgs e)
    {
        if (e.Date.Month == 2 && e.Date.Day == 14)
        {
            e.FontAttributes = FontAttributes.Bold;
            e.EllipseBackgroundColor = Color.FromRgba(e.TextColor.Red, e.TextColor.Green, e.TextColor.Blue, 0.15);
        }

        if (e.Date.Month == 2 && e.Date.Day == 21)
        {
            e.FontAttributes = FontAttributes.Bold;
            Color textColor = Color.FromArgb("F44848");
            e.EllipseBackgroundColor = Color.FromRgba(textColor.Red, textColor.Green, textColor.Blue, 0.25);
            e.TextColor = textColor;
        }
    }
}