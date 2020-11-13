namespace WorkAndTravel.Web.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateWorkPostsInputModel
    {
        [MinLength(5)]
        [Required]
        public string Title { get; set; }

        [MinLength(40)]
        [Required]
        [Display(Name = "Description of the work")]

        public string Description { get; set; }

        [Required]
        [MinLength(5)]
        [Display(Name = "Working hours description")]
        public string WorkLengthDescription { get; set; }

        [Display(Name = "Salary per day (if any)")]
        public int? PaymentPerDay { get; set; }

        [Display(Name ="Type of post")]
        public int CategoryId { get; set; }

        [Required]
        public string City { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        public string Address { get; set; }

        [MinLength(10)]
        [Required]
        [Display(Name = "Our requirements and what we expect")]
        public string Requirements { get; set; }

        public IEnumerable<KeyValuePair<string,string>> CountryItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoryItems { get; set; }
    }
}
