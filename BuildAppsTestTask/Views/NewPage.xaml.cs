using BuildAppsTestTask.ViewModels;

namespace BuildAppsTestTask.Views;

public partial class NewPage : ContentPage
{
    double currentScale = 1;

    public NewPage(NewPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }

    private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        if (e.Status == GestureStatus.Running)
        {
            double delta = e.Scale - 1;
            currentScale += delta;
            currentScale = Math.Max(1, Math.Min(currentScale, 3));

            scrollView.Scale = currentScale;

            var padding = zoomFrame.Width * (currentScale - 1) / currentScale / 4;

            var paddingVert = scrollView.Height * (currentScale - 1) / currentScale / 2;

            scrollView.Padding = new(padding, paddingVert, padding, 0);
        }
    }
}