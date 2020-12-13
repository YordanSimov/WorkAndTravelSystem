namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;

    public interface IProfileService
    {
        T GetUserId<T>(string id);
        IEnumerable<T> GetUserAppliedToPosts<T>(string id);
    }
}
