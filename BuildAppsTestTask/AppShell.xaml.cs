using BuildAppsTestTask.Views;

namespace BuildAppsTestTask;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(Constants.PagesRoutes.NewPage, typeof(NewPage));
    }
}
