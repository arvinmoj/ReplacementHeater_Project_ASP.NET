using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class CommonDataViewModels
    {
        public CommonDataViewModels() : base()
        {
        }

        // *****
        [Required]
        [Display(Name = "شماره")]
        public int Number { get; set; }
        // *****

        // *****
        [Required]
        [Display(Name = "تاریخ")]
        public DateTime Date { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.HeaterInstalledType))]
        public string HeaterInstalledType { get; set; }
        // *****

        // *****
        [DataType(DataType.Date)]
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.InstallationDate))]
        public DateTime InstallationDate { get; set; }
        // *****

        // *****
        [DataType(DataType.Time)]
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.InstallationDate))]
        public TimeSpan InstallationTime { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
           Name = nameof(Resources.ReplacementHeater.HeaterInstalledSerialNumber))]
        public int HeaterInstalledSerialNumber { get; set; }
        // *****

    }
}