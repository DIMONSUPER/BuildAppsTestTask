using BuildAppsTestTask.ViewModels;

namespace BuildAppsTestTask.Views;

public partial class Tab2 : ContentPage
{
    public Tab2(Tab2ViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}