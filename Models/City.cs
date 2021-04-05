using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("City")]
    public class City : Base.Entity
    {
        public City() : base() 
        {
            IdCity = Guid.NewGuid();
        }
        
        // *****
        public Guid IdCity { get; set; }
        // *****

        // *****
        public string CityName { get; set; }
        // *****

        // *****
        public Country Country { get; set; }
        // *****

        // *****
        public List<State> States { get; set; }
        // *****
    }
}