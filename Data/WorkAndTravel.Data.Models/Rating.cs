namespace WorkAndTravel.Data.Models
{
    using WorkAndTravel.Data.Common.Models;

    public class Rating : BaseModel<int>
    {
        public ApplicationUser AddedByUser { get; set; }

        public string AddedByUserId { get; set; }

        public byte Value { get; set; }

        public int WorkPostId { get; set; }

        public virtual WorkPost WorkPost { get; set; }
    }
}
