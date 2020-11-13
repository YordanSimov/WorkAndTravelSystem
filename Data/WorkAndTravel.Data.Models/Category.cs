namespace WorkAndTravel.Data.Models
{
    using System.Collections.Generic;

    using WorkAndTravel.Data.Common.Models;

    public class Category : BaseModel<int>
    {
        public Category()
        {
            this.WorkPost = new HashSet<WorkPost>();
        }

        public string Name { get; set; }

        public virtual ICollection<WorkPost> WorkPost { get; set; }
    }
}
