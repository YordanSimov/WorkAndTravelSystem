namespace WorkAndTravel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        public City()
        {
            this.Address = new HashSet<Address>();
        }

        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public int WorkPostId { get; set; }

        public virtual WorkPost WorkPost { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
