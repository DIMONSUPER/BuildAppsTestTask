
using System.Diagnostics;
using System.Text.Json;

namespace BuildAppsTestTask.Services.Profile;

public class ProfileService : IProfileService
{
    private const string API_URL = "https://490c85a9-7a74-42e4-bf2e-96ac3bcff5b1.mock.pstmn.io/profiles";

    //TODO: move to the rest service
    private readonly HttpClient _client = new();

    public ProfileService()
    {
    }

    #region -- IProfileService implementation --

    public async Task<IEnumerable<Models.Profile>> GetProfilesAsync()
    {
        var result = new List<Models.Profile>();

        try
        {
            var response = await _client.GetAsync(API_URL).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();

                result = JsonSerializer.Deserialize<List<Models.Profile>>(stream)!;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception in {nameof(ProfileService)}.{nameof(GetProfilesAsync)}: {ex.Message}");
        }

        return result;
    }

    #endregion
}
