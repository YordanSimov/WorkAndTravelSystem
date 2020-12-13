﻿namespace WorkAndTravel.Web.ViewModels.Account
{
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class ProfilePostViewModel : IMapFrom<WorkPost>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string RemoteImageUrl { get; set; }
    }
}