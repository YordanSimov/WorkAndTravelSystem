namespace WorkAndTravel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using WorkAndTravel.Data.Common.Models;

    public class Rating : BaseModel<int>
    {
        public ApplicationUser AddedByUser { get; set; }

        public string AddedByUserId { get; set; }

        [Range(1, 5)]
        public int Stars { get; set; }

        public int WorkPostId { get; set; }

        public virtual WorkPost WorkPost { get; set; }
    }
}
