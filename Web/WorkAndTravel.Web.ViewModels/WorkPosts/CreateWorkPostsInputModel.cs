namespace WorkAndTravel.Web.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;
    using WorkAndTravel.Web.ViewModels.WorkPosts;

    public class CreateWorkPostsInputModel : BaseWorkPostInputModel
    {
        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CountryItems { get; set; }
    }
}
