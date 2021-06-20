using System.ComponentModel.DataAnnotations;

namespace ViewModels.ReplacementHeater
{
    public class ReplacementHeaterViewModel
    {
        public ReplacementHeaterViewModel() : base()
        {
        }

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
          Name = nameof(Resources.ReplacementHeater.UserLegalPerson))]
        public bool UserLegalPerson { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
         Name = nameof(Resources.ReplacementHeater.UserNaturalPerson))]
        public bool UserNaturalPerson { get; set; }
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
    }
}