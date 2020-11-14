namespace WorkAndTravel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using WorkAndTravel.Data.Common.Models;

    public class WorkPost : BaseDeletableModel<int>
    {
        public WorkPost()
        {
            this.Image = new HashSet<Image>();
            this.Rating = new HashSet<Rating>();
        }

        [MaxLength(80)]
        public string Title { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        [MaxLength(300)]
        public string Comment { get; set; }

        public string WorkLengthDescription { get; set; }

        public int? PaymentPerDay { get; set; }

        public int RatingId { get; set; }

        public virtual ICollection<Rating> Rating { get; set; }

        public int ImageId { get; set; }

        public virtual ICollection<Image> Image { get; set; }

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
    }
}
