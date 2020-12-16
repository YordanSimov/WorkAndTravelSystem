namespace WorkAndTravel.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class WorkPostsForIndexViewModel
    {
        public IEnumerable<IndexViewModel> WorkPosts { get; set; }

        public int WorkPostsCount { get; set; }

        public int CountriesCount { get; set; }

        public int CitiesCount { get; set; }
    }
}
