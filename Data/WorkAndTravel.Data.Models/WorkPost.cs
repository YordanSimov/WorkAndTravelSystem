namespace WorkAndTravel.Data.Models
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
        }

        [MaxLength(80)]
        public string Title { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        [MaxLength(300)]
        public string Comment { get; set; }

        public string Responsibility { get; set; }

        public int? PaymentPerDay { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Image> Images { get; set; }

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
    }
}
