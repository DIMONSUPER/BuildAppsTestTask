using BuildAppsTestTask.Models;
using BuildAppsTestTask.Services.Profile;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BuildAppsTestTask.ViewModels;
public partial class Tab1ViewModel(IProfileService profileService) : ObservableObject
{
    #region -- Public properties --

    private ICommand _loadProfilesCommand;
    public ICommand LoadProfilesCommand => _loadProfilesCommand ??= new AsyncRelayCommand(LoadProfilesAsync);

    private ICommand _profileTappedCommand;
    public ICommand ProfileTappedCommand => _profileTappedCommand ??= new AsyncRelayCommand<Profile>(ProfileTappedAsync);

    private ICommand _openNewPageCommand;
    public ICommand OpenNewPageCommand => _openNewPageCommand ??= new AsyncRelayCommand(OpenNewPageAsync);

    [ObservableProperty]
    private ObservableCollection<Profile> _profiles;

    #endregion

    #region -- Private helpers --

    private async Task LoadProfilesAsync()
    {
        if (Profiles is null || Profiles.Count == 0)
        {
            var profiles = await profileService.GetProfilesAsync().ConfigureAwait(false);

            Profiles = new ObservableCollection<Profile>(profiles);
        }
    }

    private Task ProfileTappedAsync(Profile? profile)
    {
        var navigationParameter = new Dictionary<string, object>
        {
            { nameof(Profile), profile }
        };

        return Shell.Current.GoToAsync($"///{Constants.PagesRoutes.Tab2}", navigationParameter);
    }

    private Task OpenNewPageAsync()
    {
        var navigationParameter = new Dictionary<string, object>
        {
            { nameof(Profiles), Profiles }
        };

        return Shell.Current.GoToAsync($"{Constants.PagesRoutes.NewPage}", navigationParameter);
    }

    #endregion
}
