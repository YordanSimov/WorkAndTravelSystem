namespace WorkAndTravel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public Country()
        {
            this.City = new HashSet<City>();
            this.WorkPost = new HashSet<WorkPost>();
        }

        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<WorkPost> WorkPost { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
