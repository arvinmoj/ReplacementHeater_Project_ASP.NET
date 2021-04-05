using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("ShokatHeater")]
    public class ShokatHeater : Base.Entity
    {
        public ShokatHeater() : base()
        {
            IdShokatHeater = Guid.NewGuid();
        }

        // *****
        public Guid IdShokatHeater { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ShokatHeater),
           Name = nameof(Resources.ShokatHeater.HeaterSerialNumber))]
        public int HeaterSerialNumber { get; set; }
        // *****

        // *****
        [DataType(DataType.Date)]
        [Display(ResourceType = typeof(Resources.ShokatHeater),
           Name = nameof(Resources.ShokatHeater.ProductionDate))]
        public string ProductionDate { get; set; }
        // *****

    }
}
