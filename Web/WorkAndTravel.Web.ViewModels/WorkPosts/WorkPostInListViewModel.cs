namespace WorkAndTravel.Web.ViewModels.WorkPosts
{
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class WorkPostInListViewModel : IMapFrom<WorkPost>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string RemoteImageUrl { get; set; }
    }
}
