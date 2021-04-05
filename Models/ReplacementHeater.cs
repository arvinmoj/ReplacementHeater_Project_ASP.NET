using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("ReplacementHeater")]
    public class ReplacementHeater : Base.Entity
    {
        public ReplacementHeater() : base()
        {
            ReplacementHeaterId = Guid.NewGuid();
        }

        // *****
        public Guid ReplacementHeaterId { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
          Name = nameof(Resources.ReplacementHeater.HeaterInstalledType))]
        public string HeaterInstalledType { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.NameCEO))]
        public string NameCEO { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.FullName))]
        public string FullName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.ScrapHeaterType))]
        public string HeaterScrapType { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.Model))]
        public string Model { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.Capacity))]
        public float Capacity { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.ScrapHeaterSerialNumber))]
        public int HeaterScrapSerialNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.HeaterInstalledSerialNumber))]
        public int HeaterInstalledSerialNumber { get; set; }
        // *****

        // *****
        [DataType(DataType.Date)]
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.InstallationDate))]
        public string InstallationDate { get; set; }
        // *****

        // *****
        [DataType(DataType.Time)]
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.InstallationTime))]
        public string InstallationTime { get; set; }
        // *****

        public NaturalPerson NaturalPerson { get; set; }

        public LegalPerson LegalPerson { get; set; }

    }
}