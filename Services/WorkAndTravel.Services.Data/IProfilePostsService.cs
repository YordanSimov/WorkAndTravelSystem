namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;

    public interface IProfilePostsService
    {
        public IEnumerable<T> GetAll<T>(string id);
    }
}
