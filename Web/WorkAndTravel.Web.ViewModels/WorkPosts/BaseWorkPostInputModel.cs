namespace WorkAndTravel.Web.ViewModels.WorkPosts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseWorkPostInputModel
    {
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string Title { get; set; }

        [MinLength(40)]
        [Required]
        [Display(Name = "Description")]

        public string Description { get; set; }

        [Required]
        [MinLength(5)]
        [Display(Name = "Responsibilities")]
        public string Responsibility { get; set; }

        [Display(Name = "Salary per day in dollars (if any)")]
        public int? PaymentPerDay { get; set; }

        [Display(Name = "Type of post")]
        public int CategoryId { get; set; }

        [MinLength(10)]
        [Required]
        [Display(Name = "Your requirements")]
        public string Requirement { get; set; }

        [Display(Name = "What you provide")]
        public string Providing { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoryItems { get; set; }
    }
}
