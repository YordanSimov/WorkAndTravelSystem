namespace WorkAndTravel.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using WorkAndTravel.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        [ForeignKey(nameof(WorkPost))]
        public int WorkPostId { get; set; }

        public virtual WorkPost WorkPost { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Parent { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
