namespace WorkAndTravel.Web.ViewModels.Account
{
    using AutoMapper;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class PostsViewModel : IMapFrom<AppliedUsersWorkPosts>, IHaveCustomMappings
    {
        public virtual WorkPost WorkPost { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<WorkPost, PostsViewModel>()
                .ForMember(x => x.ApplicationUser, opt => opt.MapFrom(x => x.AppliedUsersWorkPosts))
                .ForMember(x => x.WorkPost, opt => opt.MapFrom(x => x.AppliedUsersWorkPosts));
        }
    }
}
