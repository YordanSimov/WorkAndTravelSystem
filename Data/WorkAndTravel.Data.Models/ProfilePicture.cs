namespace WorkAndTravel.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using WorkAndTravel.Data.Common.Models;

    public class ProfilePicture : BaseDeletableModel<int>
    {
        [Required]
        public string Url { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
