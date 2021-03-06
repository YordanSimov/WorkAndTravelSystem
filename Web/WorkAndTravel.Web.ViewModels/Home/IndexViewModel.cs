﻿using AutoMapper;
using System.Linq;
using WorkAndTravel.Data.Models;
using WorkAndTravel.Services.Mapping;

namespace WorkAndTravel.Web.ViewModels.Home
{
    public class IndexViewModel : IMapFrom<WorkPost>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string RemoteImageUrl { get; set; }

        public string CityName { get; set; }

        public double AverageRating { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<WorkPost, IndexViewModel>()
                .ForMember(x => x.AverageRating, opt =>
                    opt.MapFrom(x => x.Ratings.Count() == 0 ? 0 : x.Ratings.Average(a => a.Value)))
                .ForMember(x => x.RemoteImageUrl, opt =>
                    opt.MapFrom(x =>
                     x.Images.FirstOrDefault().RemoteImageUrl));
        }
    }
}
