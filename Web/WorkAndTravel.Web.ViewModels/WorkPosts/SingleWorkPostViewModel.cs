﻿namespace WorkAndTravel.Web.ViewModels.WorkPosts
{
    using System;
    using System.Linq;

    using AutoMapper;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class SingleWorkPostViewModel : IMapFrom<WorkPost>, IHaveCustomMappings
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AddedByUserUserName { get; set; }

        public string RemoteImageUrl { get; set; }

        public string CityName { get; set; }

        public string CountryName { get; set; }

        public string AddressName { get; set; }

        public string Comment { get; set; }

        public string WorkLengthDescription { get; set; }

        public int? PaymentPerDay { get; set; }

        public string Requirement { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<WorkPost, SingleWorkPostViewModel>()
                .ForMember(x => x.RemoteImageUrl, opt =>
                    opt.MapFrom(x =>
                     x.Images.FirstOrDefault().RemoteImageUrl != null ?
                     x.Images.FirstOrDefault().RemoteImageUrl :
                     "/images/workposts/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}