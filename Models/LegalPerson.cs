using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("LegalPerson")]
    public class LegalPerson : Base.Entity
    {
        public LegalPerson() : base()
        {
            LegalPersonId = Guid.NewGuid();
        }

        // *****
        public Guid LegalPersonId { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
          Name = nameof(Resources.ReplacementHeater.UserLegalPerson))]
        public bool UserLegalPerson { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
           Name = nameof(Resources.LegalPerson.InstallerUserName))]
        public string InstallerUserName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
            Name = nameof(Resources.LegalPerson.CompanyName))]
        public string CompanyName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.NameCEO))]
        public string NameCEO { get; set; }
        // *****

        // *****
        [EmailAddress]
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.EmailAddress))]
        public string EmailAddress { get; set; }
        // *****

        // *****
        [Phone]
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.PhoneNumber))]
        public string PhoneNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.City))]
        public string City { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.State))]
        public string State { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.Address))]
        public string Address { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.RegistrationNumber))]
        public float RegistrationNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.EconomicCode))]
        public float EconomicCode { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.RecipientName))]
        public string RecipientName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.InstallationLocation))]
        public string InstallationLocation { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.GasometerType))]
        public string GasometerType { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.GasometerNumber))]
        public string GasometerNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
          Name = nameof(Resources.LegalPerson.PersonNumber))]
        public string PersonNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.LegalPerson),
         Name = nameof(Resources.LegalPerson.Attachment))]
        public string Attachment { get; set; }
        // *****

        public Installer Installer { get; set; }

        public List<ReplacementHeater> ReplacementHeaters { get; set; }
    }
}
