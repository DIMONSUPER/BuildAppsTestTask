using BuildAppsTestTask.ViewModels;

namespace BuildAppsTestTask.Views;

public partial class NewPage : ContentPage
{
    public NewPage(NewPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}