namespace BuildAppsTestTask.Services.Profile;

public interface IProfileService
{
    public Task<IEnumerable<Models.Profile>> GetProfilesAsync();
}
