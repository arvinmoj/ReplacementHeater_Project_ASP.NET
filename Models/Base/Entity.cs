using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Base
{
    public class Entity : Object
    {
        public Entity() : base()
        {
            Id = Guid.NewGuid();
            InsertDateTime = Utility.Now;
        }

        // *****
        [Key]
        [DatabaseGenerated
            (DatabaseGeneratedOption.None)]
        //[Display(ResourceType = typeof(DataDictionary),
        //         Name = nameof(DataDictionary.Id))]
        public Guid Id { get; set; }
        // *****

        // *****
        //[Display(ResourceType = typeof(DataDictionary),
        //         Name = nameof(DataDictionary.InsertDateTime))]
        public DateTime InsertDateTime { get; set; }
        // *****
    }
}
