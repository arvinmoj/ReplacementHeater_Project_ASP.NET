using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Country")]
    public class Country : Base.Entity
    {
        public Country() : base()
        {
            IdCountry = Guid.NewGuid();
        }

        // *****
        public Guid IdCountry { get; set; }
        // *****

        // *****
        public string CountryName { get; set; }
        // *****

        // *****
        public List<City> Cities { get; set; }
        // *****
    }
}