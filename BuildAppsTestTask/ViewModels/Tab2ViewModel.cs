using BuildAppsTestTask.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BuildAppsTestTask.ViewModels;

[QueryProperty(nameof(SelectedProfile), nameof(Profile))]
public partial class Tab2ViewModel : ObservableObject
{
    #region -- Public properties --

    [ObservableProperty]
    private Profile _selectedProfile;

    #endregion
}
