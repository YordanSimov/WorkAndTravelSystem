namespace WorkAndTravel.Data.Models
{
    using System.Collections.Generic;

    using WorkAndTravel.Data.Common.Models;

    public class Requirement : BaseDeletableModel<int>
    {
        public Requirement()
        {
            this.WorkPostRequirement = new HashSet<WorkPostRequirement>();
        }

        public string Text { get; set; }

        public virtual ICollection<WorkPostRequirement> WorkPostRequirement { get; set; }
    }
}
