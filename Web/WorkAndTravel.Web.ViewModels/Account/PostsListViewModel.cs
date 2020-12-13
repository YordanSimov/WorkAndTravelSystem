namespace WorkAndTravel.Web.ViewModels.Account
{
    using System.Collections.Generic;

    using AutoMapper;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class PostsListViewModel : IHaveCustomMappings
    {
        public IEnumerable<PostsViewModel> WorkPosts { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<WorkPost, PostsListViewModel>()
                .ForMember(x => x.WorkPosts, opt => opt.MapFrom(x => x.AppliedUsersWorkPosts));
        }
    }
}
