namespace WorkAndTravel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using WorkAndTravel.Data.Common.Models;

    public class City : BaseModel<int>
    {
        public City()
        {
            this.Address = new HashSet<Address>();
            this.WorkPost = new HashSet<WorkPost>();
        }

        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<WorkPost> WorkPost { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
