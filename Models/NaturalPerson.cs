using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("NaturalPerson")]
    public class NaturalPerson : Base.Entity
    {
        public NaturalPerson() : base()
        {
            NaturalPersonId = Guid.NewGuid();
        }

        // *****
        public Guid NaturalPersonId { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.ReplacementHeater),
         Name = nameof(Resources.ReplacementHeater.UserNaturalPerson))]
        public bool UserNaturalPerson { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.InstallerUserName))]
        public string InstallerUserName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.FullName))]
        public string FullName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.NationalCode))]
        public string NationalCode { get; set; }
        // *****

        // *****
        [EmailAddress]
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.EmailAddress))]
        public string EmailAddress { get; set; }
        // *****

        // *****
        [Phone]
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.PhoneNumber))]
        public string PhoneNumber { get; set; }
        // *****

        // *****
        [Phone]
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.MobileNumber))]
        public string MobileNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.City))]
        public string City { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.State))]
        public string State { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.Address))]
        public string Address { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.InstallationLocation))]
        public string InstallationLocation { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.GasometerType))]
        public string GasometerType { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.GasometerNumber))]
        public string GasometerNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
           Name = nameof(Resources.NaturalPersons.PersonNumber))]
        public string PersonNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.NaturalPersons),
            Name = nameof(Resources.LegalPerson.Attachment))]
        public string Attachment { get; set; }
        // *****

        public Installer Installer { get; set; }

        public List<ReplacementHeater> ReplacementHeaters { get; set; }
    }
}