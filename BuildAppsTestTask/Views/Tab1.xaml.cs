using BuildAppsTestTask.ViewModels;

namespace BuildAppsTestTask.Views;

public partial class Tab1 : ContentPage
{
    public Tab1(Tab1ViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}