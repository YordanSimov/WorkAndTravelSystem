namespace WorkAndTravel.Data.Models
{
    public class AppliedUsersWorkPosts
    {
        public int Id { get; set; }

        public int WorkPostId { get; set; }

        public virtual WorkPost WorkPost { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
