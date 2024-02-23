using BuildAppsTestTask.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BuildAppsTestTask.ViewModels;

[QueryProperty(nameof(Profiles), nameof(Profiles))]
public partial class NewPageViewModel : ObservableObject
{
    #region -- Public properties --

    [ObservableProperty]
    private ObservableCollection<Profile> _profiles;

    #endregion
}
