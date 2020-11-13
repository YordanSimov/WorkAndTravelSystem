namespace WorkAndTravel.Data.Models
{
    using System;

    using WorkAndTravel.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int WorkPostId { get; set; }

        public virtual WorkPost WorkPost { get; set; }

        public string Extension { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
