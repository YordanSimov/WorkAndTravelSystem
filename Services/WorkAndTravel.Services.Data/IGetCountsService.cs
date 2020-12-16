namespace WorkAndTravel.Services.Data
{
    public interface IGetCountsService
    {
        int GetCountriesCounts();

        int GetCitiesCounts();

        int GetPostsCounts();
    }
}
