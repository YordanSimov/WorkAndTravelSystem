namespace WorkAndTravel.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using WorkAndTravel.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        [MaxLength(60)]
        public string Name { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }
    }
}
