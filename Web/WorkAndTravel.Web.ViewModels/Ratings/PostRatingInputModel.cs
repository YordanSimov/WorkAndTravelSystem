namespace WorkAndTravel.Web.ViewModels.Ratings
{
    using System.ComponentModel.DataAnnotations;

    public class PostRatingInputModel
    {
        public int WorkPostId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}
