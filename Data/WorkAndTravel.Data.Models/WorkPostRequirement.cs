namespace WorkAndTravel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WorkPostRequirement
    {
        public int Id { get; set; }

        public int RequirementId { get; set; }

        public virtual Requirement Requirement { get; set; }

        public int WorkPostId { get; set; }

        public virtual WorkPost WorkPost { get; set; }
    }
}
