﻿namespace WorkAndTravel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using WorkAndTravel.Data.Common.Models;

    public class WorkPost : BaseDeletableModel<int>
    {
        public WorkPost()
        {
            this.Images = new HashSet<Image>();
            this.Ratings = new HashSet<Rating>();
            this.Comments = new HashSet<Comment>();
            this.AppliedUsersWorkPosts = new HashSet<AppliedUsersWorkPosts>();
        }

        [MaxLength(80)]
        public string Title { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public string Responsibility { get; set; }

        public int? PaymentPerDay { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        [MaxLength(300)]

        public string Requirement { get; set; }

        public string Providing { get; set; }

        public virtual ICollection<AppliedUsersWorkPosts> AppliedUsersWorkPosts { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Image> Images { get; set; }

    }
}
