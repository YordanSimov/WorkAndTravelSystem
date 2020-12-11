namespace WorkAndTravel.Services.Data
{
    public interface IProfileService
    {
        T GetUserId<T>(string id);
    }
}
