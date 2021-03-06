﻿namespace WorkAndTravel.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using WorkAndTravel.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        public Address()
        {
            this.WorkPost = new HashSet<WorkPost>();
        }

        [MaxLength(60)]
        public string Name { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<WorkPost> WorkPost { get; set; }
    }
}
