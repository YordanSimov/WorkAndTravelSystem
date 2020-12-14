namespace WorkAndTravel.Web.ViewModels.Account
{
    using System.Linq;

    using AutoMapper;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class ProfilePostViewModel : IMapFrom<WorkPost>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string RemoteImageUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<WorkPost, ProfilePostViewModel>()
                .ForMember(x => x.RemoteImageUrl, opt =>
                    opt.MapFrom(x =>
                     x.Images.FirstOrDefault().RemoteImageUrl));
        }
    }
}