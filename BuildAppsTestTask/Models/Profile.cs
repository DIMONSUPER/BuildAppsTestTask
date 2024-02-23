namespace BuildAppsTestTask.Models;

public class Profile
{
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string ImageUrl { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Gender { get; set; }
}
