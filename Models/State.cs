using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models

{
    [Table("State")]
    public class State : Base.Entity
    {
        public State() : base()
        {
            IdState = Guid.NewGuid();  
        }

        // *****
        public Guid IdState { get; set; }
        // *****

        // *****
        public string StateName { get; set; }
        // *****

        // *****
        public City City { get; set; }
        // *****
    }
}