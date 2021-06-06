using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Installer")]
    public class Installer : Base.Entity
    {
        public Installer() : base()
        {
            InstallerId = Guid.NewGuid();
        }

        // *****
        public Guid InstallerId { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.FullName))]
        public string FullName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.UserName))]
        public string InstallerUserName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.UserNumber))]
        public string UserNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.NationalCode))]
        public string NationalCode { get; set; }
        // *****

        // *****
        [Phone]
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.PhoneNumber))]
        public string PhoneNumber { get; set; }
        // *****

        // *****
        [Phone]
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.MobileNumber))]
        public string MobileNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.Address))]
        public string Address { get; set; }
        // *****

        public List<LegalPerson> LegalPeople { get; set; }

        public List<NaturalPerson> NaturalPeople { get; set; }

    }
}